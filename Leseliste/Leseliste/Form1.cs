namespace Hausaufgaben.Leseliste;

// ============================================================
// 1.2 Aufgabe 1: Leseliste ★
//Schwierigkeit: Einfach
//Zeit: ca. 45 min
//Übertrage die Einkaufsliste aus Auftrag 1 auf eine persönliche Leseliste.
// ============================================================

public partial class Form1 : Form
{
    // TODO: List<string> für die Titel, Anzeige in einer ListBox
    // private List<string> _buchTitel = new();
    private List<string> _buchTitel = new();
    private List<string> _titelGelesen = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void CmdHinzufuegen_Click(object sender, EventArgs e)
    {
        // TODO: Duplikate verhindern – auch bei anderer Gross-/Kleinschreibung («clean code» = «Clean Code»)
        if (string.IsNullOrWhiteSpace(TxtArtikel.Text))
        {
            MessageBox.Show("Bitte zuerst Buchtitel eingeben.", "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string _buchtitelNew = TxtArtikel.Text.Trim();

        if (_buchTitel.Contains(_buchtitelNew, StringComparer.OrdinalIgnoreCase))
        {
            MessageBox.Show($"{_buchtitelNew} ist bereits in der Leseliste enthalten.", "Eintrag bereits vorhanden.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        else
        {
            _buchTitel.Add(_buchtitelNew);
        }
        AktualisiereListBox();
        TxtArtikel.Clear();
        TxtArtikel.Focus();
    }

    private void CmdEntfernen_Click(object sender, EventArgs e)
    {
        // TODO: _buchTitel.Clear(), ListBox leeren, LblAnzahl = "0"
        _buchTitel.Clear();
        LstArtikel.Items.Clear();
        AktualisiereListBox();
    }

    private void CmdGelesenEntfernen_Click(object sender, EventArgs e)
    {
        
        int indexToDelete = LstArtikel.SelectedIndex;
        if (indexToDelete < 0)
        {
            MessageBox.Show("Bitte zuerst einen Artikel auswählen.", "Hinweis");
            return;
        }
        _titelGelesen.Add(_buchTitel[indexToDelete]);

        _buchTitel.RemoveAt(indexToDelete);
        LstArtikel.Items.RemoveAt(indexToDelete);


        AktualisiereListBox();


    }
    private void AktualisiereListBox()
    {
        // TODO: LstArtikel.Items.Clear();
        //          foreach (string a in _artikel) LstArtikel.Items.Add(a);
        //          LblAnzahl.Text = $"Artikel: {_artikel.Count}";

        LstArtikel.Items.Clear();

        foreach (string a in _buchTitel)
        {
            LstArtikel.Items.Add(a);
        }

        LblZuLesen.Text = $"Noch zu lesen: {_buchTitel.Count}";
        LblGelesen.Text = $"Bereits gelesen: {_titelGelesen.Count}";
    }

    private void CmdSortieren_Click(object sender, EventArgs e)
    {
        SortAlphabetisch();
        AktualisiereListBox();
    }

    private void SortAlphabetisch()
    {
        _buchTitel.Sort(StringComparer.CurrentCultureIgnoreCase);
    }

}
