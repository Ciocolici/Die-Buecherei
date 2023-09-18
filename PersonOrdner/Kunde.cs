using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei.PersonOrdner;

internal class Kunde : Person
{
    public Kunde(string kundenID, string bewertung, string name, int alter) : base (name, alter)
    {
        KundenID = kundenID;
        Bewertung = bewertung;
    }

    public string KundenID { get; set; }
    public string Bewertung { get; set; }
}
