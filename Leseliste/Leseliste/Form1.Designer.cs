namespace Hausaufgaben.Leseliste;

partial class Form1
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

    private void InitializeComponent()
    {
        LblBuchTitel = new Label();
        TxtArtikel = new TextBox();
        CmdHinzufuegen = new Button();
        CmdAlleEntfernen = new Button();
        CmdGelesenEntfernen = new Button();
        LstArtikel = new ListBox();
        LblZuLesen = new Label();
        CmdSortieren = new Button();
        LblGelesen = new Label();
        SuspendLayout();
        // 
        // LblBuchTitel
        // 
        LblBuchTitel.AutoSize = true;
        LblBuchTitel.Location = new Point(17, 33);
        LblBuchTitel.Margin = new Padding(4, 0, 4, 0);
        LblBuchTitel.Name = "LblBuchTitel";
        LblBuchTitel.Size = new Size(83, 25);
        LblBuchTitel.TabIndex = 0;
        LblBuchTitel.Text = "Buchtitel:";
        // 
        // TxtArtikel
        // 
        TxtArtikel.Location = new Point(100, 28);
        TxtArtikel.Margin = new Padding(4, 5, 4, 5);
        TxtArtikel.Name = "TxtArtikel";
        TxtArtikel.Size = new Size(255, 31);
        TxtArtikel.TabIndex = 1;
        // 
        // CmdHinzufuegen
        // 
        CmdHinzufuegen.Location = new Point(371, 27);
        CmdHinzufuegen.Margin = new Padding(4, 5, 4, 5);
        CmdHinzufuegen.Name = "CmdHinzufuegen";
        CmdHinzufuegen.Size = new Size(143, 42);
        CmdHinzufuegen.TabIndex = 2;
        CmdHinzufuegen.Text = "Hinzufügen";
        CmdHinzufuegen.Click += CmdHinzufuegen_Click;
        // 
        // CmdAlleEntfernen
        // 
        CmdAlleEntfernen.Location = new Point(371, 90);
        CmdAlleEntfernen.Margin = new Padding(4, 5, 4, 5);
        CmdAlleEntfernen.Name = "CmdAlleEntfernen";
        CmdAlleEntfernen.Size = new Size(143, 42);
        CmdAlleEntfernen.TabIndex = 3;
        CmdAlleEntfernen.Text = "Alle löschen";
        CmdAlleEntfernen.Click += CmdEntfernen_Click;
        // 
        // CmdGelesenEntfernen
        // 
        CmdGelesenEntfernen.Location = new Point(17, 90);
        CmdGelesenEntfernen.Margin = new Padding(4, 5, 4, 5);
        CmdGelesenEntfernen.Name = "CmdGelesenEntfernen";
        CmdGelesenEntfernen.Size = new Size(203, 42);
        CmdGelesenEntfernen.TabIndex = 4;
        CmdGelesenEntfernen.Text = "Als gelesen entfernen";
        CmdGelesenEntfernen.Click += CmdGelesenEntfernen_Click;
        // 
        // LstArtikel
        // 
        LstArtikel.Location = new Point(17, 142);
        LstArtikel.Margin = new Padding(4, 5, 4, 5);
        LstArtikel.Name = "LstArtikel";
        LstArtikel.Size = new Size(498, 254);
        LstArtikel.TabIndex = 5;
        // 
        // LblZuLesen
        // 
        LblZuLesen.AutoSize = true;
        LblZuLesen.Location = new Point(17, 430);
        LblZuLesen.Margin = new Padding(4, 0, 4, 0);
        LblZuLesen.Name = "LblZuLesen";
        LblZuLesen.Size = new Size(0, 25);
        LblZuLesen.TabIndex = 6;
        // 
        // CmdSortieren
        // 
        CmdSortieren.Location = new Point(362, 421);
        CmdSortieren.Name = "CmdSortieren";
        CmdSortieren.Size = new Size(130, 34);
        CmdSortieren.TabIndex = 7;
        CmdSortieren.Text = "Alphabetisch";
        CmdSortieren.UseVisualStyleBackColor = true;
        CmdSortieren.Click += CmdSortieren_Click;
        // 
        // LblGelesen
        // 
        LblGelesen.AutoSize = true;
        LblGelesen.Location = new Point(17, 455);
        LblGelesen.Margin = new Padding(4, 0, 4, 0);
        LblGelesen.Name = "LblGelesen";
        LblGelesen.Size = new Size(0, 25);
        LblGelesen.TabIndex = 8;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(564, 604);
        Controls.Add(LblGelesen);
        Controls.Add(CmdSortieren);
        Controls.Add(LblBuchTitel);
        Controls.Add(TxtArtikel);
        Controls.Add(CmdHinzufuegen);
        Controls.Add(CmdAlleEntfernen);
        Controls.Add(CmdGelesenEntfernen);
        Controls.Add(LstArtikel);
        Controls.Add(LblZuLesen);
        Margin = new Padding(4, 5, 4, 5);
        Name = "Form1";
        Text = "Einkaufsliste – Auftrag 1";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label LblBuchTitel;
  private TextBox TxtArtikel;
  private Button CmdHinzufuegen;
  private Button CmdAlleEntfernen;
  private Button CmdGelesenEntfernen;
  private ListBox LstArtikel;
  private Label LblZuLesen;
    private Button CmdSortieren;
    private Label LblGelesen;
}
