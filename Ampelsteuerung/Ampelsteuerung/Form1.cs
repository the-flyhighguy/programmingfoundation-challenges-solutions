using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampelsteuerung;

/// <summary>
///   Aufgabe 1 – Ampelsteuerung (⭐ Einfach)
///   Zeigt die Ampelfarbe und Bedeutung per switch-case an.
/// </summary>
///

enum TrafficLightColor
{
  Green,
  Yello,
  Red
}


  public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
  }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void CmdAnzeigen_Click(object sender, EventArgs e)
    { 
    // Guard Clause für den Fall, dass kein Radiobutton ausgewählt ist
    if (!(RadGreen.Checked || RadOrange.Checked || RadRot.Checked))
    {
      LblAnweisung.Text = "Bitte zuerst Ampelfarbe auswählen!";
      return;
    }

    // Prüfen, welches Radio-Element ausgewählt ist
    TrafficLightColor light;

    if (RadGreen.Checked)
    {
      light = TrafficLightColor.Green;
    }

    else if (RadOrange.Checked)
    {
      light = TrafficLightColor.Yello;
    }

    else
    {
      light = TrafficLightColor.Red;
    }

    // Events via klassischer switch-Methode wählen
    string anweisung;
    Color ampelFarbe;

    switch (light)
    {
      case TrafficLightColor.Green:
        anweisung = "Fahren!";
        ampelFarbe = Color.Green;
        break;

      case TrafficLightColor.Yello:
        anweisung = "Vorsicht bremsen";
        ampelFarbe = Color.Yellow;
        break;

      case TrafficLightColor.Red:
        anweisung = "Anhalten!";
        ampelFarbe= Color.Red;
        break;

      default:
        anweisung = "Unbekannt";
        ampelFarbe = Color.Black;
        break;
    }

    LblAnweisung.Text = anweisung;
    LblAnweisung.BackColor = ampelFarbe;

    }

  private void label1_Click(object sender, EventArgs e)
  {

  }
}

