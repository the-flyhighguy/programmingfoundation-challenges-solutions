namespace Passwortgenerator
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
            GrpPasswortoptionen = new GroupBox();
            ChkSonderzeichen = new CheckBox();
            ChkZahlen = new CheckBox();
            ChkKleinbuchstaben = new CheckBox();
            ChkGrossbuchstaben = new CheckBox();
            TxtPasswortlaenge = new TextBox();
            LblPasswortlaenge = new Label();
            CmdPasswortGenerieren = new Button();
            CmdPasswortKopieren = new Button();
            LblPasswort = new Label();
            LblPasswortLocation = new Label();
            GrpPasswortoptionen.SuspendLayout();
            SuspendLayout();
            // 
            // GrpPasswortoptionen
            // 
            GrpPasswortoptionen.Controls.Add(ChkSonderzeichen);
            GrpPasswortoptionen.Controls.Add(ChkZahlen);
            GrpPasswortoptionen.Controls.Add(ChkKleinbuchstaben);
            GrpPasswortoptionen.Controls.Add(ChkGrossbuchstaben);
            GrpPasswortoptionen.Font = new Font("Arial", 10F);
            GrpPasswortoptionen.Location = new Point(88, 354);
            GrpPasswortoptionen.Margin = new Padding(5, 5, 5, 5);
            GrpPasswortoptionen.Name = "GrpPasswortoptionen";
            GrpPasswortoptionen.Padding = new Padding(5, 5, 5, 5);
            GrpPasswortoptionen.Size = new Size(508, 423);
            GrpPasswortoptionen.TabIndex = 0;
            GrpPasswortoptionen.TabStop = false;
            GrpPasswortoptionen.Text = "Passwortoptionen";
            GrpPasswortoptionen.Enter += GrpPasswortoptionen_Enter;
            // 
            // ChkSonderzeichen
            // 
            ChkSonderzeichen.AutoSize = true;
            ChkSonderzeichen.Location = new Point(36, 292);
            ChkSonderzeichen.Margin = new Padding(5, 5, 5, 5);
            ChkSonderzeichen.Name = "ChkSonderzeichen";
            ChkSonderzeichen.Size = new Size(470, 43);
            ChkSonderzeichen.TabIndex = 3;
            ChkSonderzeichen.Text = "Sonderzeichen (!@#$%^&*)»";
            ChkSonderzeichen.UseVisualStyleBackColor = true;
            // 
            // ChkZahlen
            // 
            ChkZahlen.AutoSize = true;
            ChkZahlen.Location = new Point(36, 235);
            ChkZahlen.Margin = new Padding(5, 5, 5, 5);
            ChkZahlen.Name = "ChkZahlen";
            ChkZahlen.Size = new Size(157, 43);
            ChkZahlen.TabIndex = 2;
            ChkZahlen.Text = "Zahlen";
            ChkZahlen.UseVisualStyleBackColor = true;
            // 
            // ChkKleinbuchstaben
            // 
            ChkKleinbuchstaben.AutoSize = true;
            ChkKleinbuchstaben.Location = new Point(36, 177);
            ChkKleinbuchstaben.Margin = new Padding(5, 5, 5, 5);
            ChkKleinbuchstaben.Name = "ChkKleinbuchstaben";
            ChkKleinbuchstaben.Size = new Size(301, 43);
            ChkKleinbuchstaben.TabIndex = 1;
            ChkKleinbuchstaben.Text = "Kleinbuchstaben";
            ChkKleinbuchstaben.UseVisualStyleBackColor = true;
            // 
            // ChkGrossbuchstaben
            // 
            ChkGrossbuchstaben.AutoSize = true;
            ChkGrossbuchstaben.Location = new Point(36, 120);
            ChkGrossbuchstaben.Margin = new Padding(5, 5, 5, 5);
            ChkGrossbuchstaben.Name = "ChkGrossbuchstaben";
            ChkGrossbuchstaben.Size = new Size(316, 43);
            ChkGrossbuchstaben.TabIndex = 0;
            ChkGrossbuchstaben.Text = "Grossbuchstaben";
            ChkGrossbuchstaben.UseVisualStyleBackColor = true;
            ChkGrossbuchstaben.CheckedChanged += ChkGrossbuchstaben_CheckedChanged;
            // 
            // TxtPasswortlaenge
            // 
            TxtPasswortlaenge.Location = new Point(88, 235);
            TxtPasswortlaenge.Margin = new Padding(5, 5, 5, 5);
            TxtPasswortlaenge.Name = "TxtPasswortlaenge";
            TxtPasswortlaenge.Size = new Size(380, 47);
            TxtPasswortlaenge.TabIndex = 1;
            TxtPasswortlaenge.TextChanged += TxtPasswortlaenge_TextChanged;
            // 
            // LblPasswortlaenge
            // 
            LblPasswortlaenge.AutoSize = true;
            LblPasswortlaenge.Font = new Font("Arial", 10F);
            LblPasswortlaenge.Location = new Point(88, 169);
            LblPasswortlaenge.Margin = new Padding(5, 0, 5, 0);
            LblPasswortlaenge.Name = "LblPasswortlaenge";
            LblPasswortlaenge.Size = new Size(461, 39);
            LblPasswortlaenge.TabIndex = 2;
            LblPasswortlaenge.Text = "Passwortlänge (8-32 Zeichen)";
            LblPasswortlaenge.Click += LblPasswortlaenge_Click;
            // 
            // CmdPasswortGenerieren
            // 
            CmdPasswortGenerieren.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CmdPasswortGenerieren.Location = new Point(88, 817);
            CmdPasswortGenerieren.Margin = new Padding(5, 5, 5, 5);
            CmdPasswortGenerieren.Name = "CmdPasswortGenerieren";
            CmdPasswortGenerieren.Size = new Size(382, 174);
            CmdPasswortGenerieren.TabIndex = 3;
            CmdPasswortGenerieren.Text = "Passwort generieren!";
            CmdPasswortGenerieren.UseVisualStyleBackColor = true;
            CmdPasswortGenerieren.Click += CmdPasswortGenerieren_Click;
            // 
            // CmdPasswortKopieren
            // 
            CmdPasswortKopieren.Location = new Point(88, 1205);
            CmdPasswortKopieren.Margin = new Padding(5, 5, 5, 5);
            CmdPasswortKopieren.Name = "CmdPasswortKopieren";
            CmdPasswortKopieren.Size = new Size(190, 56);
            CmdPasswortKopieren.TabIndex = 4;
            CmdPasswortKopieren.Text = "Kopieren";
            CmdPasswortKopieren.UseVisualStyleBackColor = true;
            // 
            // LblPasswort
            // 
            LblPasswort.AutoSize = true;
            LblPasswort.Location = new Point(88, 1107);
            LblPasswort.Margin = new Padding(5, 0, 5, 0);
            LblPasswort.Name = "LblPasswort";
            LblPasswort.Size = new Size(0, 41);
            LblPasswort.TabIndex = 5;
            // 
            // LblPasswortLocation
            // 
            LblPasswortLocation.AutoSize = true;
            LblPasswortLocation.Location = new Point(88, 1066);
            LblPasswortLocation.Margin = new Padding(5, 0, 5, 0);
            LblPasswortLocation.Name = "LblPasswortLocation";
            LblPasswortLocation.Size = new Size(142, 41);
            LblPasswortLocation.TabIndex = 6;
            LblPasswortLocation.Text = "Passwort:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 1627);
            Controls.Add(LblPasswortLocation);
            Controls.Add(LblPasswort);
            Controls.Add(CmdPasswortKopieren);
            Controls.Add(CmdPasswortGenerieren);
            Controls.Add(LblPasswortlaenge);
            Controls.Add(TxtPasswortlaenge);
            Controls.Add(GrpPasswortoptionen);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            GrpPasswortoptionen.ResumeLayout(false);
            GrpPasswortoptionen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrpPasswortoptionen;
        private CheckBox ChkSonderzeichen;
        private CheckBox ChkZahlen;
        private CheckBox ChkKleinbuchstaben;
        private CheckBox ChkGrossbuchstaben;
        private TextBox TxtPasswortlaenge;
        private Label LblPasswortlaenge;
        private Button CmdPasswortGenerieren;
        private Button CmdPasswortKopieren;
        private Label LblPasswort;
        private Label LblPasswortLocation;
    }
}
