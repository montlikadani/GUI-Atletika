namespace atletikaGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.aranyermetSzerzett = new System.Windows.Forms.ListBox();
            this.aranyosNemzetek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.versenyszamok = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ermesHelyezes = new System.Windows.Forms.NumericUpDown();
            this.kereses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.versenyzoNev = new System.Windows.Forms.Label();
            this.versenyzoEredmenye = new System.Windows.Forms.Label();
            this.versenyzoNemzete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ermesHelyezes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // aranyermetSzerzett
            // 
            this.aranyermetSzerzett.FormattingEnabled = true;
            this.aranyermetSzerzett.ItemHeight = 18;
            this.aranyermetSzerzett.Location = new System.Drawing.Point(25, 52);
            this.aranyermetSzerzett.Name = "aranyermetSzerzett";
            this.aranyermetSzerzett.Size = new System.Drawing.Size(265, 472);
            this.aranyermetSzerzett.TabIndex = 1;
            // 
            // aranyosNemzetek
            // 
            this.aranyosNemzetek.BackColor = System.Drawing.Color.Transparent;
            this.aranyosNemzetek.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.aranyosNemzetek.FlatAppearance.BorderSize = 2;
            this.aranyosNemzetek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.aranyosNemzetek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aranyosNemzetek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aranyosNemzetek.Location = new System.Drawing.Point(43, 561);
            this.aranyosNemzetek.Name = "aranyosNemzetek";
            this.aranyosNemzetek.Size = new System.Drawing.Size(211, 36);
            this.aranyosNemzetek.TabIndex = 2;
            this.aranyosNemzetek.Text = "aranyos - nemzetek";
            this.aranyosNemzetek.UseVisualStyleBackColor = false;
            this.aranyosNemzetek.Click += new System.EventHandler(this.aranyosNemzetek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // versenyszamok
            // 
            this.versenyszamok.FormattingEnabled = true;
            this.versenyszamok.ItemHeight = 18;
            this.versenyszamok.Location = new System.Drawing.Point(378, 56);
            this.versenyszamok.Name = "versenyszamok";
            this.versenyszamok.Size = new System.Drawing.Size(250, 94);
            this.versenyszamok.Sorted = true;
            this.versenyszamok.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Válassza ki az érmes helyezést:";
            // 
            // ermesHelyezes
            // 
            this.ermesHelyezes.Location = new System.Drawing.Point(381, 202);
            this.ermesHelyezes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ermesHelyezes.Name = "ermesHelyezes";
            this.ermesHelyezes.Size = new System.Drawing.Size(76, 27);
            this.ermesHelyezes.TabIndex = 6;
            this.ermesHelyezes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kereses
            // 
            this.kereses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kereses.FlatAppearance.BorderSize = 2;
            this.kereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kereses.Location = new System.Drawing.Point(420, 358);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(157, 47);
            this.kereses.TabIndex = 7;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = true;
            this.kereses.Click += new System.EventHandler(this.kereses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Versenyző adatai:";
            // 
            // versenyzoNev
            // 
            this.versenyzoNev.AutoSize = true;
            this.versenyzoNev.Location = new System.Drawing.Point(435, 462);
            this.versenyzoNev.Name = "versenyzoNev";
            this.versenyzoNev.Size = new System.Drawing.Size(54, 18);
            this.versenyzoNev.TabIndex = 9;
            this.versenyzoNev.Text = "neve:";
            // 
            // versenyzoEredmenye
            // 
            this.versenyzoEredmenye.AutoSize = true;
            this.versenyzoEredmenye.Location = new System.Drawing.Point(384, 496);
            this.versenyzoEredmenye.Name = "versenyzoEredmenye";
            this.versenyzoEredmenye.Size = new System.Drawing.Size(105, 18);
            this.versenyzoEredmenye.TabIndex = 10;
            this.versenyzoEredmenye.Text = "eredménye:";
            // 
            // versenyzoNemzete
            // 
            this.versenyzoNemzete.AutoSize = true;
            this.versenyzoNemzete.Location = new System.Drawing.Point(403, 535);
            this.versenyzoNemzete.Name = "versenyzoNemzete";
            this.versenyzoNemzete.Size = new System.Drawing.Size(86, 18);
            this.versenyzoNemzete.TabIndex = 11;
            this.versenyzoNemzete.Text = "nemzete:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.versenyzoNemzete);
            this.Controls.Add(this.versenyzoEredmenye);
            this.Controls.Add(this.versenyzoNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.ermesHelyezes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versenyszamok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aranyosNemzetek);
            this.Controls.Add(this.aranyermetSzerzett);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Férfiak eredménye a 2017-es VB-n";
            ((System.ComponentModel.ISupportInitialize)(this.ermesHelyezes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aranyermetSzerzett;
        private System.Windows.Forms.Button aranyosNemzetek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox versenyszamok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ermesHelyezes;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label versenyzoNev;
        private System.Windows.Forms.Label versenyzoEredmenye;
        private System.Windows.Forms.Label versenyzoNemzete;
    }
}

