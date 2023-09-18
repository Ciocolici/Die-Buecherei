using Die_Buecherei.MedienOrdner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei;

internal class Verzeichnis
{
    List<Buecher> BuecherList = new List<Buecher>();
    List<Buecher> SoftwareList = new List<Buecher>();
    List<Buecher> VideosList = new List<Buecher>();
    List<Buecher> KundeList = new List<Buecher>();

    public Verzeichnis(List<Buecher> buecherList, List<Buecher> softwareList, List<Buecher> videosList, List<Buecher> kundeList)
    {
        BuecherList = buecherList;
        SoftwareList = softwareList;
        VideosList = videosList;
        KundeList = kundeList;
    }
}
