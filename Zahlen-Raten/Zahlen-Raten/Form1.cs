using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlen_Raten

///   Aufgabe 2 – Zahlen-Ratespiel (⭐⭐ Mittel)
///   WinForms-Ratespiel mit Random, Hinweisen und Versuchszähler.

{
    public partial class ZahlenRatespielForm : Form
    {
        private int geheimzahl;
        private int versuche;
        // Zufallsgenerator für die Geheimzahl; wird einmal erstellt und für alle Spiele wiederverwendet.
        private readonly Random random = new();
  

        public ZahlenRatespielForm()
        {
            InitializeComponent();
            NeuesSpiel();
        }

        private void CmdNeuesSpiel_Click(object sender, EventArgs e)
        {
            // TODO 2: Variablen für Versuchszähler und geraten-Flag

            NeuesSpiel();
        }

        private void NeuesSpiel()
        {
            geheimzahl = random.Next(1, 101);
            versuche = 0;
            TxtGeraten.Clear();
            ActiveControl = TxtGeraten;
            LblAnweisung.Text = "Neues Spiel! Rate eine Zahl zwischen 1 und 100.";
            // Setzt Felder nach einem Gewinn wieder auf 'aktiv'
            TxtGeraten.Enabled = true;
            CmdRaten.Enabled = true;
        }
        private void CmdRaten_Click(object sender, EventArgs e)
        {
            string zahlGeraten = TxtGeraten.Text;
            
            if (!int.TryParse(zahlGeraten, out int tipp) || tipp < 1 || tipp > 100)
            {
                MessageBox.Show("Bitte ganze Zahl eingeben.",
                    "Ungültige Eingabe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inkrementiert Versuchszähler
            versuche++;

            // Hier findet Prüfung statt
            if (tipp < geheimzahl)
            {
                LblRückmeldung.Text = $"Deine geratene Zahl ({zahlGeraten}) ist zu klein.{Environment.NewLine}Versuche bisher: {versuche}";
            }

            else if (tipp > geheimzahl)
            {
                LblRückmeldung.Text = $"Deine geratene Zahl ({zahlGeraten}) ist zu gross.{Environment.NewLine}Versuche bisher: {versuche}";
            }

            else
            {   //Erfolgsmeldung. MessageBoxButton und MessageBoxIcon optional
                MessageBox.Show($"Glückwunsch {tipp} ist korrekt. Du hast {versuche} Versuche benötigt",
                    "Gewonnen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Macht Eingaben und Klicken auf Raten-Button unmöglich
                TxtGeraten.Enabled = false;
                CmdRaten.Enabled = false;
            }
            // Markiert den Text in der Textbox der Benutzereingabe (für useabillity)
            TxtGeraten.SelectAll();
            // Beim Programmstart und nach einem Klick auf «Neues Spiel» landet der Cursor direkt in TxtGeraten
            ActiveControl = TxtGeraten;
            
      
        }
    }
}
