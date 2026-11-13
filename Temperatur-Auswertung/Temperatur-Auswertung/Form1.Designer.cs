namespace Temperatur_Auswertung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtMontag = new TextBox();
            TxtFreitag = new TextBox();
            TxtDienstag = new TextBox();
            TxtDonnerstag = new TextBox();
            TxtMittwoch = new TextBox();
            TxtSamstag = new TextBox();
            TxtSonntag = new TextBox();
            LblMontag = new Label();
            LblDienstag = new Label();
            LblMittwoch = new Label();
            LblDonnerstag = new Label();
            LblFreitag = new Label();
            LblSamstag = new Label();
            LblSonntag = new Label();
            CmdAuswertung = new Button();
            LblTempDurchschnitt = new Label();
            LblTempMax = new Label();
            LblTempMin = new Label();
            SuspendLayout();
            // 
            // TxtMontag
            // 
            TxtMontag.Location = new Point(254, 145);
            TxtMontag.Name = "TxtMontag";
            TxtMontag.Size = new Size(65, 31);
            TxtMontag.TabIndex = 0;
            // 
            // TxtFreitag
            // 
            TxtFreitag.Location = new Point(254, 349);
            TxtFreitag.Name = "TxtFreitag";
            TxtFreitag.Size = new Size(65, 31);
            TxtFreitag.TabIndex = 1;
            // 
            // TxtDienstag
            // 
            TxtDienstag.Location = new Point(254, 196);
            TxtDienstag.Name = "TxtDienstag";
            TxtDienstag.Size = new Size(65, 31);
            TxtDienstag.TabIndex = 2;
            // 
            // TxtDonnerstag
            // 
            TxtDonnerstag.Location = new Point(254, 298);
            TxtDonnerstag.Name = "TxtDonnerstag";
            TxtDonnerstag.Size = new Size(65, 31);
            TxtDonnerstag.TabIndex = 3;
            // 
            // TxtMittwoch
            // 
            TxtMittwoch.Location = new Point(254, 247);
            TxtMittwoch.Name = "TxtMittwoch";
            TxtMittwoch.Size = new Size(65, 31);
            TxtMittwoch.TabIndex = 4;
            // 
            // TxtSamstag
            // 
            TxtSamstag.Location = new Point(254, 400);
            TxtSamstag.Name = "TxtSamstag";
            TxtSamstag.Size = new Size(65, 31);
            TxtSamstag.TabIndex = 5;
            // 
            // TxtSonntag
            // 
            TxtSonntag.Location = new Point(254, 451);
            TxtSonntag.Name = "TxtSonntag";
            TxtSonntag.Size = new Size(65, 31);
            TxtSonntag.TabIndex = 6;
            // 
            // LblMontag
            // 
            LblMontag.AutoSize = true;
            LblMontag.Location = new Point(151, 148);
            LblMontag.Name = "LblMontag";
            LblMontag.Size = new Size(75, 25);
            LblMontag.TabIndex = 7;
            LblMontag.Text = "Montag";
            // 
            // LblDienstag
            // 
            LblDienstag.AutoSize = true;
            LblDienstag.Location = new Point(151, 199);
            LblDienstag.Name = "LblDienstag";
            LblDienstag.Size = new Size(82, 25);
            LblDienstag.TabIndex = 8;
            LblDienstag.Text = "Dienstag";
            // 
            // LblMittwoch
            // 
            LblMittwoch.AutoSize = true;
            LblMittwoch.Location = new Point(151, 250);
            LblMittwoch.Name = "LblMittwoch";
            LblMittwoch.Size = new Size(86, 25);
            LblMittwoch.TabIndex = 9;
            LblMittwoch.Text = "Mittwoch";
            // 
            // LblDonnerstag
            // 
            LblDonnerstag.AutoSize = true;
            LblDonnerstag.Location = new Point(151, 301);
            LblDonnerstag.Name = "LblDonnerstag";
            LblDonnerstag.Size = new Size(105, 25);
            LblDonnerstag.TabIndex = 10;
            LblDonnerstag.Text = "Donnerstag";
            // 
            // LblFreitag
            // 
            LblFreitag.AutoSize = true;
            LblFreitag.Location = new Point(151, 352);
            LblFreitag.Name = "LblFreitag";
            LblFreitag.Size = new Size(66, 25);
            LblFreitag.TabIndex = 11;
            LblFreitag.Text = "Freitag";
            // 
            // LblSamstag
            // 
            LblSamstag.AutoSize = true;
            LblSamstag.Location = new Point(151, 403);
            LblSamstag.Name = "LblSamstag";
            LblSamstag.Size = new Size(81, 25);
            LblSamstag.TabIndex = 12;
            LblSamstag.Text = "Samstag";
            // 
            // LblSonntag
            // 
            LblSonntag.AutoSize = true;
            LblSonntag.Location = new Point(151, 454);
            LblSonntag.Name = "LblSonntag";
            LblSonntag.Size = new Size(79, 25);
            LblSonntag.TabIndex = 13;
            LblSonntag.Text = "Sonntag";
            // 
            // CmdAuswertung
            // 
            CmdAuswertung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CmdAuswertung.Location = new Point(151, 525);
            CmdAuswertung.Name = "CmdAuswertung";
            CmdAuswertung.Size = new Size(152, 49);
            CmdAuswertung.TabIndex = 14;
            CmdAuswertung.Text = "Auswerten";
            CmdAuswertung.UseVisualStyleBackColor = true;
            CmdAuswertung.Click += button1_Click;
            // 
            // LblTempDurchschnitt
            // 
            LblTempDurchschnitt.AutoSize = true;
            LblTempDurchschnitt.Location = new Point(408, 247);
            LblTempDurchschnitt.Name = "LblTempDurchschnitt";
            LblTempDurchschnitt.Size = new Size(0, 25);
            LblTempDurchschnitt.TabIndex = 15;
            // 
            // LblTempMax
            // 
            LblTempMax.AutoSize = true;
            LblTempMax.Location = new Point(408, 298);
            LblTempMax.Name = "LblTempMax";
            LblTempMax.Size = new Size(0, 25);
            LblTempMax.TabIndex = 16;
            // 
            // LblTempMin
            // 
            LblTempMin.AutoSize = true;
            LblTempMin.Location = new Point(408, 349);
            LblTempMin.Name = "LblTempMin";
            LblTempMin.Size = new Size(0, 25);
            LblTempMin.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 758);
            Controls.Add(LblTempMin);
            Controls.Add(LblTempMax);
            Controls.Add(LblTempDurchschnitt);
            Controls.Add(CmdAuswertung);
            Controls.Add(LblSonntag);
            Controls.Add(LblSamstag);
            Controls.Add(LblFreitag);
            Controls.Add(LblDonnerstag);
            Controls.Add(LblMittwoch);
            Controls.Add(LblDienstag);
            Controls.Add(LblMontag);
            Controls.Add(TxtSonntag);
            Controls.Add(TxtSamstag);
            Controls.Add(TxtMittwoch);
            Controls.Add(TxtDonnerstag);
            Controls.Add(TxtDienstag);
            Controls.Add(TxtFreitag);
            Controls.Add(TxtMontag);
            Name = "Form1";
            Text = "Temperatur Auswertung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMontag;
        private TextBox TxtFreitag;
        private TextBox TxtDienstag;
        private TextBox TxtDonnerstag;
        private TextBox TxtMittwoch;
        private TextBox TxtSamstag;
        private TextBox TxtSonntag;
        private Label LblMontag;
        private Label LblDienstag;
        private Label LblMittwoch;
        private Label LblDonnerstag;
        private Label LblFreitag;
        private Label LblSamstag;
        private Label LblSonntag;
        private Button CmdAuswertung;
        private Label LblTempDurchschnitt;
        private Label LblTempMax;
        private Label LblTempMin;
    }
}
