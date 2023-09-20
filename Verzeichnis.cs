using Die_Buecherei.MedienOrdner;
using Die_Buecherei.PersonOrdner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei;

internal class Verzeichnis
{
    public static List<Buecher> BuecherList { get; set; } = new List<Buecher>();
    public static List<Software> SoftwareList { get; set; } = new List<Software>();
    public static List<Videos> VideosList { get; set; } = new List<Videos>();
    public static List<Kunde> KundeList { get; set; } = new List<Kunde>();
}
