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
        Verliehen = true;
    }

    public override void Ruecknahme()
    {
        Verliehen = false;
    }
}
