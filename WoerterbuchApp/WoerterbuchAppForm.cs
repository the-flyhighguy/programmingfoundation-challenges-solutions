namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();
  private Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)
    _woerterbuch.Add("Hund", "Dog");
    _woerterbuch.Add("Katze", "Cat");
    _woerterbuch.Add("Vogel", "Bird");
    _woerterbuch.Add("Schlange", "Snake");
    _woerterbuch.Add("Pferd", "Horse");

    // TODO 3: AktualisiereListBox() aufrufen
    AktualisiereListBox();

  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    //         Gefunden: LblErgebnis anzeigen
    //         Nicht gefunden: "Kein Eintrag für..."
    LblErgebnis.Text = "";

    if (string.IsNullOrWhiteSpace(TxtSuche.Text))
    {
      MessageBox.Show("Bitte Eingabe tätigen.", "Feld darf nicht leer sein", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    if (!_woerterbuch.TryGetValue(TxtSuche.Text.Trim(), out string _uebersetzung))
    {
      MessageBox.Show("Eintrag nicht in Wörterbuch enthalten.", "Nicht vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
      LblErgebnis.Text = $"{_uebersetzung}";
    }

    TxtSuche.Clear();
    TxtSuche.Focus();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 5: Leere Felder prüfen
    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen
    // TODO 7: _woerterbuch[key] = value;
    // TODO 8: AktualisiereListBox()
    if (string.IsNullOrWhiteSpace(TxtKeyNeu.Text) || string.IsNullOrWhiteSpace(TxtValueNeu.Text))
    {
      MessageBox.Show("Bitte alle Felder ausfüllen.", "Fehlende Eingabe/n",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);

      return;
    }

    string key = TxtKeyNeu.Text.Trim();
    string value = TxtValueNeu.Text.Trim();

    if (_woerterbuch.ContainsKey(key))
    {
      DialogResult antwort = MessageBox.Show("Übersetzung bereits in Wörterbuch enthalten. Soll der Vorhandene Wert überschrieben werden?", "Bestätigung für Überschreiben des aktuellen Wertes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (antwort == DialogResult.No)
      {
        return;
      }
    }
    // Möglich, aber kann keine Werte überschreiben ⬇️
    // _woerterbuch.Add(TxtKeyNeu.Text.Trim(), TxtValueNeu.Text.Trim());

    _woerterbuch[key] = value;
    TxtKeyNeu.Clear();
    TxtValueNeu.Clear();
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();
    foreach (KeyValuePair<string, string> dE in _woerterbuch)
    {
      LstEintraege.Items.Add(dE.Key + "->" + dE.Value);
    }
  }
}
