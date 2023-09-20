using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei.MedienOrdner;

internal class Buecher : Medien
{
    public Buecher(int seite, string autor, string name, bool verliehen, bool rueckgabefristUeberschritten) : base (name, verliehen, rueckgabefristUeberschritten)
    {
        Seite = seite;
        Autor = autor;
    }

    public int Seite { get; set; }
    public string Autor { get; set; }

    public override void Ausleihen()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Autor} ist nie eine schlechte Wahl.\nLassen Sie mich überprüfen, ob es verfügbar ist.\n\n");
        Thread.Sleep(2000);
        base.Ausleihen();
    }

    public override void Ruecknahme()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Ich hoffe, dass Ihnen das Buch gefallen hat, ansonsten wird {Autor} bestimmt traurig sein. Bitte geben Sie mir einen kurzen Moment.\n\n");
        Thread.Sleep(2000);
        base.Ruecknahme();
    }
}
