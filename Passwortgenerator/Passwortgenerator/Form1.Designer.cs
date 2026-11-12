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
            GrpPasswortoptionen.Location = new Point(52, 216);
            GrpPasswortoptionen.Name = "GrpPasswortoptionen";
            GrpPasswortoptionen.Size = new Size(299, 258);
            GrpPasswortoptionen.TabIndex = 0;
            GrpPasswortoptionen.TabStop = false;
            GrpPasswortoptionen.Text = "Passwortoptionen";
            GrpPasswortoptionen.Enter += GrpPasswortoptionen_Enter;
            // 
            // ChkSonderzeichen
            // 
            ChkSonderzeichen.AutoSize = true;
            ChkSonderzeichen.Location = new Point(21, 178);
            ChkSonderzeichen.Name = "ChkSonderzeichen";
            ChkSonderzeichen.Size = new Size(277, 27);
            ChkSonderzeichen.TabIndex = 3;
            ChkSonderzeichen.Text = "Sonderzeichen (!@#$%^&*)»";
            ChkSonderzeichen.UseVisualStyleBackColor = true;
            // 
            // ChkZahlen
            // 
            ChkZahlen.AutoSize = true;
            ChkZahlen.Location = new Point(21, 143);
            ChkZahlen.Name = "ChkZahlen";
            ChkZahlen.Size = new Size(94, 27);
            ChkZahlen.TabIndex = 2;
            ChkZahlen.Text = "Zahlen";
            ChkZahlen.UseVisualStyleBackColor = true;
            // 
            // ChkKleinbuchstaben
            // 
            ChkKleinbuchstaben.AutoSize = true;
            ChkKleinbuchstaben.Location = new Point(21, 108);
            ChkKleinbuchstaben.Name = "ChkKleinbuchstaben";
            ChkKleinbuchstaben.Size = new Size(178, 27);
            ChkKleinbuchstaben.TabIndex = 1;
            ChkKleinbuchstaben.Text = "Kleinbuchstaben";
            ChkKleinbuchstaben.UseVisualStyleBackColor = true;
            // 
            // ChkGrossbuchstaben
            // 
            ChkGrossbuchstaben.AutoSize = true;
            ChkGrossbuchstaben.Location = new Point(21, 73);
            ChkGrossbuchstaben.Name = "ChkGrossbuchstaben";
            ChkGrossbuchstaben.Size = new Size(190, 27);
            ChkGrossbuchstaben.TabIndex = 0;
            ChkGrossbuchstaben.Text = "Grossbuchstaben";
            ChkGrossbuchstaben.UseVisualStyleBackColor = true;
            ChkGrossbuchstaben.CheckedChanged += ChkGrossbuchstaben_CheckedChanged;
            // 
            // TxtPasswortlaenge
            // 
            TxtPasswortlaenge.Location = new Point(52, 143);
            TxtPasswortlaenge.Name = "TxtPasswortlaenge";
            TxtPasswortlaenge.Size = new Size(225, 31);
            TxtPasswortlaenge.TabIndex = 1;
            TxtPasswortlaenge.TextChanged += TxtPasswortlaenge_TextChanged;
            // 
            // LblPasswortlaenge
            // 
            LblPasswortlaenge.AutoSize = true;
            LblPasswortlaenge.Font = new Font("Arial", 10F);
            LblPasswortlaenge.Location = new Point(52, 103);
            LblPasswortlaenge.Name = "LblPasswortlaenge";
            LblPasswortlaenge.Size = new Size(274, 23);
            LblPasswortlaenge.TabIndex = 2;
            LblPasswortlaenge.Text = "Passwortlänge (8-32 Zeichen)";
            LblPasswortlaenge.Click += LblPasswortlaenge_Click;
            // 
            // CmdPasswortGenerieren
            // 
            CmdPasswortGenerieren.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CmdPasswortGenerieren.Location = new Point(52, 498);
            CmdPasswortGenerieren.Name = "CmdPasswortGenerieren";
            CmdPasswortGenerieren.Size = new Size(225, 106);
            CmdPasswortGenerieren.TabIndex = 3;
            CmdPasswortGenerieren.Text = "Passwort generieren!";
            CmdPasswortGenerieren.UseVisualStyleBackColor = true;
            CmdPasswortGenerieren.Click += CmdPasswortGenerieren_Click;
            // 
            // CmdPasswortKopieren
            // 
            CmdPasswortKopieren.Location = new Point(52, 735);
            CmdPasswortKopieren.Name = "CmdPasswortKopieren";
            CmdPasswortKopieren.Size = new Size(112, 34);
            CmdPasswortKopieren.TabIndex = 4;
            CmdPasswortKopieren.Text = "Kopieren";
            CmdPasswortKopieren.UseVisualStyleBackColor = true;
            CmdPasswortKopieren.Click += CmdPasswortKopieren_Click;
            // 
            // LblPasswort
            // 
            LblPasswort.AutoSize = true;
            LblPasswort.Location = new Point(52, 675);
            LblPasswort.Name = "LblPasswort";
            LblPasswort.Size = new Size(0, 25);
            LblPasswort.TabIndex = 5;
            // 
            // LblPasswortLocation
            // 
            LblPasswortLocation.AutoSize = true;
            LblPasswortLocation.Location = new Point(52, 650);
            LblPasswortLocation.Name = "LblPasswortLocation";
            LblPasswortLocation.Size = new Size(86, 25);
            LblPasswortLocation.TabIndex = 6;
            LblPasswortLocation.Text = "Passwort:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 992);
            Controls.Add(LblPasswortLocation);
            Controls.Add(LblPasswort);
            Controls.Add(CmdPasswortKopieren);
            Controls.Add(CmdPasswortGenerieren);
            Controls.Add(LblPasswortlaenge);
            Controls.Add(TxtPasswortlaenge);
            Controls.Add(GrpPasswortoptionen);
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
