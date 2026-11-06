namespace Multiplikationstabelle
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtZahl = new System.Windows.Forms.TextBox();
            this.CmdTabelle = new System.Windows.Forms.Button();
            this.LblZahl = new System.Windows.Forms.Label();
            this.TxtTabelle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtZahl
            // 
            this.TxtZahl.Location = new System.Drawing.Point(34, 71);
            this.TxtZahl.Name = "TxtZahl";
            this.TxtZahl.Size = new System.Drawing.Size(133, 38);
            this.TxtZahl.TabIndex = 0;
            // 
            // CmdTabelle
            // 
            this.CmdTabelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmdTabelle.Location = new System.Drawing.Point(34, 138);
            this.CmdTabelle.Name = "CmdTabelle";
            this.CmdTabelle.Size = new System.Drawing.Size(249, 59);
            this.CmdTabelle.TabIndex = 1;
            this.CmdTabelle.Text = "Tabelle anzeigen";
            this.CmdTabelle.UseVisualStyleBackColor = true;
            this.CmdTabelle.Click += new System.EventHandler(this.CmdTabelle_Click);
            // 
            // LblZahl
            // 
            this.LblZahl.AutoSize = true;
            this.LblZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LblZahl.Location = new System.Drawing.Point(29, 15);
            this.LblZahl.Name = "LblZahl";
            this.LblZahl.Size = new System.Drawing.Size(240, 26);
            this.LblZahl.TabIndex = 2;
            this.LblZahl.Text = "Zahl zwischen 1 und 10";
            this.LblZahl.Click += new System.EventHandler(this.LblZahl_Click);
            // 
            // TxtTabelle
            // 
            this.TxtTabelle.Location = new System.Drawing.Point(34, 212);
            this.TxtTabelle.Multiline = true;
            this.TxtTabelle.Name = "TxtTabelle";
            this.TxtTabelle.Size = new System.Drawing.Size(554, 849);
            this.TxtTabelle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 1260);
            this.Controls.Add(this.TxtTabelle);
            this.Controls.Add(this.LblZahl);
            this.Controls.Add(this.CmdTabelle);
            this.Controls.Add(this.TxtZahl);
            this.Name = "Form1";
            this.Text = "Multiplikationstabelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtZahl;
        private System.Windows.Forms.Button CmdTabelle;
        private System.Windows.Forms.Label LblZahl;
        private System.Windows.Forms.TextBox TxtTabelle;
    }
}

