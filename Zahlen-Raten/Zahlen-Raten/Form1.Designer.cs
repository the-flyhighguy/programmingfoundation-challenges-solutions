namespace Zahlen_Raten
{
    partial class ZahlenRatespielForm
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
            this.CmdNeuesSpiel = new System.Windows.Forms.Button();
            this.TxtGeraten = new System.Windows.Forms.TextBox();
            this.LblRückmeldung = new System.Windows.Forms.Label();
            this.LblAnweisung = new System.Windows.Forms.Label();
            this.CmdRaten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdNeuesSpiel
            // 
            this.CmdNeuesSpiel.Location = new System.Drawing.Point(41, 49);
            this.CmdNeuesSpiel.Name = "CmdNeuesSpiel";
            this.CmdNeuesSpiel.Size = new System.Drawing.Size(333, 146);
            this.CmdNeuesSpiel.TabIndex = 0;
            this.CmdNeuesSpiel.Text = "Neues Spiel";
            this.CmdNeuesSpiel.UseVisualStyleBackColor = true;
            this.CmdNeuesSpiel.Click += new System.EventHandler(this.CmdNeuesSpiel_Click);
            // 
            // TxtGeraten
            // 
            this.TxtGeraten.AcceptsReturn = true;
            this.TxtGeraten.Location = new System.Drawing.Point(52, 262);
            this.TxtGeraten.Name = "TxtGeraten";
            this.TxtGeraten.Size = new System.Drawing.Size(109, 38);
            this.TxtGeraten.TabIndex = 1;
            // 
            // LblRückmeldung
            // 
            this.LblRückmeldung.AutoSize = true;
            this.LblRückmeldung.Location = new System.Drawing.Point(52, 411);
            this.LblRückmeldung.Name = "LblRückmeldung";
            this.LblRückmeldung.Size = new System.Drawing.Size(0, 31);
            this.LblRückmeldung.TabIndex = 2;
            // 
            // LblAnweisung
            // 
            this.LblAnweisung.AutoSize = true;
            this.LblAnweisung.Location = new System.Drawing.Point(46, 198);
            this.LblAnweisung.Name = "LblAnweisung";
            this.LblAnweisung.Size = new System.Drawing.Size(0, 31);
            this.LblAnweisung.TabIndex = 3;
            // 
            // CmdRaten
            // 
            this.CmdRaten.Location = new System.Drawing.Point(191, 262);
            this.CmdRaten.Name = "CmdRaten";
            this.CmdRaten.Size = new System.Drawing.Size(183, 84);
            this.CmdRaten.TabIndex = 4;
            this.CmdRaten.Text = "Tipp abgeben";
            this.CmdRaten.UseVisualStyleBackColor = true;
            this.CmdRaten.Click += new System.EventHandler(this.CmdRaten_Click);
            // 
            // ZahlenRatespielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 842);
            this.Controls.Add(this.CmdRaten);
            this.Controls.Add(this.LblAnweisung);
            this.Controls.Add(this.LblRückmeldung);
            this.Controls.Add(this.TxtGeraten);
            this.Controls.Add(this.CmdNeuesSpiel);
            this.Name = "ZahlenRatespielForm";
            this.Text = "Zahlen Ratespiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdNeuesSpiel;
        private System.Windows.Forms.TextBox TxtGeraten;
        private System.Windows.Forms.Label LblRückmeldung;
        private System.Windows.Forms.Label LblAnweisung;
        private System.Windows.Forms.Button CmdRaten;
    }
}

