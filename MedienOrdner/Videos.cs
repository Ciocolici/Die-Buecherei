using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei.MedienOrdner;

internal class Videos : Medien
{
    public Videos(string dauer, string genre, string name, bool verliehen, bool rueckgabefristUeberschritten) : base(name, verliehen, rueckgabefristUeberschritten)
    {
        Dauer = dauer;
        Genre = genre;
    }

    public string Dauer { get; set; }
    public string Genre { get; set; }

    public override void Ausleihen()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Es ist schon eine Weile her, seit ich einen {Genre}-Film gesehen habe. Ich habe gehört, dass {Name} besonders gut ist. Lassen Sie mich nach seiner Verfügbarkeit suchen!\n\n");
        Thread.Sleep(2000);
        base.Ausleihen();
    }

    public override void Ruecknahme()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Hast du es genossen? Oder war {Dauer} zu lang? Geben Sie mir bitte einen Moment.\n\n");
        Thread.Sleep(2000);
        base.Ruecknahme();
    }
}
