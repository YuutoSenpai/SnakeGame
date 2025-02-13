using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Rectangle> snake;
        private Rectangle jidlo;
        private int smer;
        private int skore;
        private Timer GameTimer = null;
        private Random random;
        public int SnakeSpeed { get; set; }


        // Velikost herního pole
        private const int sirka = 40; // Počet sloupců
        private const int vyska = 40; // Počet řádků
        private const int CellSize = 10; // Velikost každé buňky

        
        public Form1()
        {
            InitializeComponent();
            GameTimer = new Timer();
            InitializeGame();

        }

        private void InitializeGame()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.SnakeSpeed = this.SnakeSpeed;
            settingsForm.ShowDialog();  // Zobrazení nastavení

            this.SnakeSpeed = settingsForm.SnakeSpeed;
            if (GameTimer == null)
            {
                GameTimer = new Timer();
            }

            // Pokud je SnakeSpeed menší nebo rovno nule, nastavíme výchozí hodnotu
            if (SnakeSpeed <= 0)
            {
                SnakeSpeed = 100;  // Výchozí hodnota pro interval timeru (100 ms)
            }

            // Nastavení interval timeru
            GameTimer.Interval = SnakeSpeed;
            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Start();


            // Nastavení velikosti okna
            this.ClientSize = new Size(sirka * CellSize, vyska * CellSize);
            this.Text = "Snake Game";

            // Inicializace hada
            snake = new List<Rectangle> { new Rectangle(100, 100, CellSize, CellSize) };

            // Vytvoření náhodného generátoru pro pozici jídla
            random = new Random();
            GenerujJidlo();

            // Nastavení počátečního směru hada
            smer = 0; // 0 - right, 1 - down, 2 - left, 3 - up

            // Inicializace skóre
            skore = 0;

            // Inicializace timeru a spuštění
          

            // Připojení události pro stisk kláves
            this.KeyDown += GameForm_KeyDown;

            // Zabránění blikání při vykreslování
            this.DoubleBuffered = true;

            // Fixní velikost okna
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }




        private void GenerujJidlo()
        {
            // Generování náhodné pozice pro jídlo
            int x = random.Next(0, sirka) * CellSize;
            int y = random.Next(0, vyska) * CellSize;
            jidlo = new Rectangle(x, y, CellSize, CellSize);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PohybSnake();
            ZkontrolujKolizi();
            Invalidate(); // Vykreslení znovu (zavolá OnPaint)
        }

        private void PohybSnake()
        {
            Rectangle novaHlava = snake[0];

            switch (smer)
            {
                case 0: // right
                    novaHlava.X += CellSize;
                    break;
                case 1: // down
                    novaHlava.Y += CellSize;
                    break;
                case 2: // left
                    novaHlava.X -= CellSize;
                    break;
                case 3: // up
                    novaHlava.Y -= CellSize;
                    break;
            }

            // Kontrola, zda hlava hada překročila hranici, a přesun na opačnou stranu
            if (novaHlava.X < 0)
            {
                novaHlava.X = (sirka - 1) * CellSize; // Přesun na pravou stranu
            }
            else if (novaHlava.X >= sirka * CellSize)
            {
                novaHlava.X = 0; // Přesun na levou stranu
            }

            if (novaHlava.Y < 0)
            {
                novaHlava.Y = (vyska - 1) * CellSize; // Přesun na dolní stranu
            }
            else if (novaHlava.Y >= vyska * CellSize)
            {
                novaHlava.Y = 0; // Přesun na horní stranu
            }

            // Přidání nové hlavy
            snake.Insert(0, novaHlava);

            // Kontrola, zda had snědl jídlo
            if (novaHlava.Equals(jidlo))
            {
                skore += 10;
                GenerujJidlo(); // Vygenerování nového jídla
            }
            else
            {
                // Odstranění posledního segmentu hada
                snake.RemoveAt(snake.Count - 1);
            }
        }

        private void ZkontrolujKolizi()
        {
            // Kolize s tělem
            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0].IntersectsWith(snake[i]))
                {
                    GameOver();
                }
            }

        }

        private void GameOver()
        {
            GameTimer.Stop();
            MessageBox.Show("Game Over! Tvoje Skóré: " + skore);
            this.Close();
            MainMenuForm menuForm = new MainMenuForm();
            menuForm.Show();

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && smer != 1) smer = 3;
            if (e.KeyCode == Keys.Down && smer != 3) smer = 1;
            if (e.KeyCode == Keys.Left && smer != 0) smer = 2;
            if (e.KeyCode == Keys.Right && smer != 2) smer = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Kreslení hada
            foreach (var segment in snake)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), segment);
            }

            // Kreslení jídla
            e.Graphics.FillRectangle(Brushes.Red, jidlo);

            // Zobrazení skóre
            this.Text = "Skóré: " + skore;
        }
    }
}
