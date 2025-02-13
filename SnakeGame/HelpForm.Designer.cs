namespace SnakeGame
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 25.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "SNAKE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 187);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(97, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ovládání: Šipky ←↑↓→";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(97, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 115);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cílem hry je nasbírat co nejvíce bodů tím, že necháte hada jíst ovoce a snažíte s" +
    "e nenarazit do zdí či sami do sebe.";
            // 
            // btnCloseHelp
            // 
            this.btnCloseHelp.AutoSize = true;
            this.btnCloseHelp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseHelp.Location = new System.Drawing.Point(195, 443);
            this.btnCloseHelp.Name = "btnCloseHelp";
            this.btnCloseHelp.Size = new System.Drawing.Size(75, 32);
            this.btnCloseHelp.TabIndex = 8;
            this.btnCloseHelp.Text = "Zavřít";
            this.btnCloseHelp.UseVisualStyleBackColor = true;
            this.btnCloseHelp.Click += new System.EventHandler(this.btnCloseHelp_Click_1);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.btnCloseHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseHelp;
    }
}