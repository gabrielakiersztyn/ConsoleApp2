namespace HelloWorld
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
            this.btnClickthis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickthis
            // 
            this.btnClickthis.Location = new System.Drawing.Point(88, 12);
            this.btnClickthis.Name = "btnClickthis";
            this.btnClickthis.Size = new System.Drawing.Size(125, 63);
            this.btnClickthis.TabIndex = 0;
            this.btnClickthis.Text = "Click this";
            this.btnClickthis.UseVisualStyleBackColor = true;
            this.btnClickthis.Click += new System.EventHandler(this.btnClickthis_Click_1);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(88, 78);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(51, 20);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickthis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickthis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

