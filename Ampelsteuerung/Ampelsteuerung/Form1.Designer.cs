namespace Ampelsteuerung
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
            this.GrpAmpel = new System.Windows.Forms.GroupBox();
            this.RadGreen = new System.Windows.Forms.RadioButton();
            this.RadOrange = new System.Windows.Forms.RadioButton();
            this.RadRot = new System.Windows.Forms.RadioButton();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.LblAnweisung = new System.Windows.Forms.Label();
            this.GrpAmpel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpAmpel
            // 
            this.GrpAmpel.Controls.Add(this.RadRot);
            this.GrpAmpel.Controls.Add(this.RadOrange);
            this.GrpAmpel.Controls.Add(this.RadGreen);
            this.GrpAmpel.Location = new System.Drawing.Point(12, 94);
            this.GrpAmpel.Name = "GrpAmpel";
            this.GrpAmpel.Size = new System.Drawing.Size(195, 151);
            this.GrpAmpel.TabIndex = 0;
            this.GrpAmpel.TabStop = false;
            this.GrpAmpel.Text = "Ampel";
            // 
            // RadGreen
            // 
            this.RadGreen.AutoSize = true;
            this.RadGreen.Location = new System.Drawing.Point(6, 41);
            this.RadGreen.Name = "RadGreen";
            this.RadGreen.Size = new System.Drawing.Size(70, 24);
            this.RadGreen.TabIndex = 0;
            this.RadGreen.Text = "Grün";
            this.RadGreen.UseVisualStyleBackColor = true;
            // 
            // RadOrange
            // 
            this.RadOrange.AutoSize = true;
            this.RadOrange.Location = new System.Drawing.Point(6, 71);
            this.RadOrange.Name = "RadOrange";
            this.RadOrange.Size = new System.Drawing.Size(87, 24);
            this.RadOrange.TabIndex = 1;
            this.RadOrange.TabStop = true;
            this.RadOrange.Text = "Orange";
            this.RadOrange.UseVisualStyleBackColor = true;
            // 
            // RadRot
            // 
            this.RadRot.AutoSize = true;
            this.RadRot.Location = new System.Drawing.Point(6, 102);
            this.RadRot.Name = "RadRot";
            this.RadRot.Size = new System.Drawing.Size(60, 24);
            this.RadRot.TabIndex = 2;
            this.RadRot.TabStop = true;
            this.RadRot.Text = "Rot";
            this.RadRot.UseVisualStyleBackColor = true;
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(18, 272);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(113, 48);
            this.CmdAnzeigen.TabIndex = 0;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // LblAnweisung
            // 
            this.LblAnweisung.AutoSize = true;
            this.LblAnweisung.Location = new System.Drawing.Point(238, 324);
            this.LblAnweisung.Name = "LblAnweisung";
            this.LblAnweisung.Size = new System.Drawing.Size(0, 20);
            this.LblAnweisung.TabIndex = 2;
            this.LblAnweisung.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnweisung);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.GrpAmpel);
            this.Name = "Form1";
            this.Text = "Ampelsteuerung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpAmpel.ResumeLayout(false);
            this.GrpAmpel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.GroupBox GrpAmpel;
    private System.Windows.Forms.RadioButton RadGreen;
    private System.Windows.Forms.RadioButton RadRot;
    private System.Windows.Forms.RadioButton RadOrange;
    private System.Windows.Forms.Button CmdAnzeigen;
    private System.Windows.Forms.Label LblAnweisung;
  }
}

