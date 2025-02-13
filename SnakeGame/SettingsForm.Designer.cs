namespace SnakeGame
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnSlow = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnFast = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "SNAKE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 187);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rychlost hada:";
            // 
            // rbtnSlow
            // 
            this.rbtnSlow.AutoSize = true;
            this.rbtnSlow.Checked = true;
            this.rbtnSlow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnSlow.Location = new System.Drawing.Point(182, 277);
            this.rbtnSlow.Name = "rbtnSlow";
            this.rbtnSlow.Size = new System.Drawing.Size(56, 24);
            this.rbtnSlow.TabIndex = 6;
            this.rbtnSlow.TabStop = true;
            this.rbtnSlow.Text = "Slow";
            this.rbtnSlow.UseVisualStyleBackColor = true;
            this.rbtnSlow.CheckedChanged += new System.EventHandler(this.rbtnSlow_CheckedChanged_1);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnMedium.Location = new System.Drawing.Point(182, 307);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(75, 24);
            this.rbtnMedium.TabIndex = 7;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged_1);
            // 
            // rbtnFast
            // 
            this.rbtnFast.AutoSize = true;
            this.rbtnFast.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnFast.Location = new System.Drawing.Point(182, 337);
            this.rbtnFast.Name = "rbtnFast";
            this.rbtnFast.Size = new System.Drawing.Size(52, 24);
            this.rbtnFast.TabIndex = 8;
            this.rbtnFast.Text = "Fast";
            this.rbtnFast.UseVisualStyleBackColor = true;
            this.rbtnFast.CheckedChanged += new System.EventHandler(this.rbtnFast_CheckedChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(197, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Uložit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtnFast);
            this.Controls.Add(this.rbtnMedium);
            this.Controls.Add(this.rbtnSlow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnSlow;
        private System.Windows.Forms.RadioButton rbtnFast;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.Button btnSave;
    }
}