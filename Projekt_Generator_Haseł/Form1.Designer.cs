namespace Projekt_Generator_Haseł
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxDuze = new System.Windows.Forms.CheckBox();
            this.checkBoxCyfry = new System.Windows.Forms.CheckBox();
            this.checkBoxZnaki = new System.Windows.Forms.CheckBox();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(57, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(57, 95);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(106, 24);
            this.checkBoxMale.TabIndex = 1;
            this.checkBoxMale.Text = "Małe litery";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuze
            // 
            this.checkBoxDuze.AutoSize = true;
            this.checkBoxDuze.Location = new System.Drawing.Point(202, 95);
            this.checkBoxDuze.Name = "checkBoxDuze";
            this.checkBoxDuze.Size = new System.Drawing.Size(109, 24);
            this.checkBoxDuze.TabIndex = 2;
            this.checkBoxDuze.Text = "Duże litery";
            this.checkBoxDuze.UseVisualStyleBackColor = true;
            // 
            // checkBoxCyfry
            // 
            this.checkBoxCyfry.AutoSize = true;
            this.checkBoxCyfry.Location = new System.Drawing.Point(343, 95);
            this.checkBoxCyfry.Name = "checkBoxCyfry";
            this.checkBoxCyfry.Size = new System.Drawing.Size(70, 24);
            this.checkBoxCyfry.TabIndex = 3;
            this.checkBoxCyfry.Text = "Cyfry";
            this.checkBoxCyfry.UseVisualStyleBackColor = true;
            // 
            // checkBoxZnaki
            // 
            this.checkBoxZnaki.AutoSize = true;
            this.checkBoxZnaki.Location = new System.Drawing.Point(442, 95);
            this.checkBoxZnaki.Name = "checkBoxZnaki";
            this.checkBoxZnaki.Size = new System.Drawing.Size(145, 24);
            this.checkBoxZnaki.TabIndex = 4;
            this.checkBoxZnaki.Text = "Znaki specjalne";
            this.checkBoxZnaki.UseVisualStyleBackColor = true;
            // 
            // buttonGeneruj
            // 
            this.buttonGeneruj.Location = new System.Drawing.Point(57, 139);
            this.buttonGeneruj.Name = "buttonGeneruj";
            this.buttonGeneruj.Size = new System.Drawing.Size(149, 43);
            this.buttonGeneruj.TabIndex = 5;
            this.buttonGeneruj.Text = "Generuj hasło";
            this.buttonGeneruj.UseVisualStyleBackColor = true;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(57, 203);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.ReadOnly = true;
            this.textBoxHaslo.Size = new System.Drawing.Size(100, 26);
            this.textBoxHaslo.TabIndex = 6;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(67, 261);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(0, 20);
            this.labelOcena.TabIndex = 7;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(57, 303);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(203, 50);
            this.buttonZapisz.TabIndex = 8;
            this.buttonZapisz.Text = "Zapisz do pliku";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.buttonGeneruj);
            this.Controls.Add(this.checkBoxZnaki);
            this.Controls.Add(this.checkBoxCyfry);
            this.Controls.Add(this.checkBoxDuze);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxDuze;
        private System.Windows.Forms.CheckBox checkBoxCyfry;
        private System.Windows.Forms.CheckBox checkBoxZnaki;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Button buttonZapisz;
    }
}

