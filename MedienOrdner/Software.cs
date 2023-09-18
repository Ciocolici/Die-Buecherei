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
        Verliehen = true;
    }

    public override void Ruecknahme()
    {
        Verliehen = false;
    }
}
