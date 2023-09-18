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
        Verliehen = true;
    }

    public override void Ruecknahme()
    {
        Verliehen = false;
    }
}
