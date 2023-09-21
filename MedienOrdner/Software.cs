using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei.MedienOrdner;

internal class Software : Medien
{
    public Software(string nutzung, string hardware, string name, bool verliehen, bool rueckgabefristUeberschritten) : base(name, verliehen, rueckgabefristUeberschritten)
    {
        Nutzung = nutzung;
        Hardware = hardware;
    }

    public string Nutzung { get; set; }
    public string Hardware { get; set; }

    public override void Ausleihen()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nGute Wahl. Ich habe gehört, dass das {Name} besonders gut für {Hardware} ist. Bitte geben Sie mir einen kurzen Moment.\n\n");
        Thread.Sleep(2000);
        base.Ausleihen();
    }

    public override void Ruecknahme()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nIch hoffe, dass {Name} Ihnen nützlich war. Bitte geben Sie mir einen kurzen Moment.\n\n");
        Thread.Sleep(2000);
        base.Ruecknahme();
    }
}
