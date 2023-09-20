using Die_Buecherei.MedienOrdner;
using Die_Buecherei.PersonOrdner;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Die_Buecherei;

internal class Program
{
    static void Main(string[] args)
    {
        //   Die Bücherei

        // Schreiben Sie eine Anwendung, welche den Verleih von verschiedenen Medien(Bücher, Software, Videos) aus einer Bücherei regelt. Die maximale Verleihdauer sind 30 Tage.

        // Im Folgenden wird die Aufgabe in einzelne Teilaufgaben zerlegt:

        // 1.Erstellen Sie eine Basisklasse für alle ausleihbaren Medien.Dort sollen auch 3 Methoden implementiert werden: eine Methode, welche überprüft, ob ein Medium verleihbar ist(und, falls verliehen, ob die Rückgabefrist überschritten ist), eine Methode die das Ausleihen ermöglicht und eine Methode mit der die Rücknahme geregelt wird.Vergeben sie notwendige Attribute.

        // 2.Erstellen der abgeleiteten Klassen für Bücher, Software und Videos mit den notwendigen Attributen.

        // 3.Erstellen sie eine Basisklasse Person. Vergeben sie notwendige Attribute und eventuell Methoden.

        // 4.Leiten Sie davon eine Klasse Kunde ab. Vergeben sie notwendige Attribute und eventuell Methoden.

        // 5.Erstellen Sie eine Klasse Verzeichnis, in der Sie Collections definieren, die ihre Kunden und ihre verschiedenen Medien enthalten werden.

        // 6.Erstellen Sie(in der Main Methode) verschiedene Medien(vorhanden, verliehen, überzogen) und Kunden, tragen Sie diese in der Klasse Verzeichnis ein.

        //7.Testen Sie mehrere Verleihe, Rückgaben und zeigen Sie überschrittene Rückgabefristen auf.

        Buecher buecher1 = new Buecher(42, "Chuckle McLaughington", "Die Suche nach dem Letzten Schokoladenkekssplitter", true, false);
        Buecher buecher2 = new Buecher(101, "Gigglesworth Wobblepants", "Die Abenteuer von Sir Kitzel-viel", false, false);
        Buecher buecher3 = new Buecher(7, "Snorty McSnickerdoodle", "Das Große Bananenschalenabenteuer", true, true);
        Buecher buecher4 = new Buecher(404, "Punny O'Puns", "Das Verschwindende Wörterbuch", false, false);
        Buecher buecher5 = new Buecher(999, "Nod McChortleson", "Der Verrückte Zucchini-Zephyr", false, false);
        Verzeichnis.BuecherList.Add(buecher1);
        Verzeichnis.BuecherList.Add(buecher2);
        Verzeichnis.BuecherList.Add(buecher3);
        Verzeichnis.BuecherList.Add(buecher4);
        Verzeichnis.BuecherList.Add(buecher5);


        Software software1 = new Software("Der Ultimative Bananensortierer", "Quanten-Bananenprozessor", "BananaSorter++", false, false);
        Software software2 = new Software("Zeitreise-Simulator für Katzen", "Katzenbetriebenen Supercomputern", "Purradox Jumper", true, false);
        Software software3 = new Software("Unendlicher Cheeseburger-Generator", "Cheeseburger-fähigen Mikrowellen", "CheeseBlast Pro", false, false);
        Software software4 = new Software("Zufallssockenpaar-Algorithmus", "Sock-O-Tron 9000", "SockSync Deluxe", false, false);
        Software software5 = new Software("GPS für Astronauten im Weltraum verloren", "Raketenbetriebene Fahrräder", "GalaxyGuide Navigator", true, true);
        Verzeichnis.SoftwareList.Add(software1);
        Verzeichnis.SoftwareList.Add(software2);
        Verzeichnis.SoftwareList.Add(software3);
        Verzeichnis.SoftwareList.Add(software4);
        Verzeichnis.SoftwareList.Add(software5);

        Videos video1 = new Videos("42 Minuten", "Komödie der verrückten Enten", "Das Watschelnde Chaos", true, false);
        Videos video2 = new Videos("17 Stunden und 38 Minuten", "Dramatische Seifenblasenoper", "Die Tragödie der Platzen", false, false);
        Videos video3 = new Videos("5 Sekunden", "Wissenschaftliche Katzenforschung", "Der Große Katzen-Physik-Showdown", true, true);
        Videos video4 = new Videos("3 Tage und 7 Nickerchen", "Fantastische Frühstücksfilme", "Die Saga der magischen Müsli", false, false);
        Videos video5 = new Videos("1 Minute und 23 Sekunden", "Abenteuerliche Gummibärenkriege", "Die epische Schlacht um die Gummibärenburg", false, false);
        Verzeichnis.VideosList.Add(video1);
        Verzeichnis.VideosList.Add(video2);
        Verzeichnis.VideosList.Add(video3);
        Verzeichnis.VideosList.Add(video4);
        Verzeichnis.VideosList.Add(video5);

        Kunde kunde1 = new Kunde("KID1234", "5+", "Lachbert Lachsalot", 37);
        Kunde kunde2 = new Kunde("KID5678", "3-", "Scherzalina Schmunzelschön", 25);
        Kunde kunde3 = new Kunde("KID9876", "4", "Freudentänzer Frohsinn", 42);
        Kunde kunde4 = new Kunde("KID4321", "1-", "Frohbert Fröhlich", 31);
        Kunde kunde5 = new Kunde("KID2468", "2+", "Glücksstrahl Glücklichmann", 55);
        Verzeichnis.KundeList.Add(kunde1);
        Verzeichnis.KundeList.Add(kunde2);
        Verzeichnis.KundeList.Add(kunde3);
        Verzeichnis.KundeList.Add(kunde4);
        Verzeichnis.KundeList.Add(kunde5);

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\r\n _____    _           ______   _   _         _                           _ \r\n(____ \\  (_)         (____  \\ (_) (_)       | |                         (_)\r\n _   \\ \\  _   ____    ____)  ) _   _   ____ | | _    ____   ____   ____  _ \r\n| |   | || | / _  )  |  __  ( | | | | / ___)| || \\  / _  ) / ___) / _  )| |\r\n| |__/ / | |( (/ /   | |__)  )| |_| |( (___ | | | |( (/ / | |    ( (/ / | |\r\n|_____/  |_| \\____)  |______/  \\____| \\____)|_| |_| \\____)|_|     \\____)|_|\r\n                                                                           \r\n");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n\nHerzlich willkommen in unserer Bücherei!");
        Console.WriteLine("\nWählen Sie bitte ihre KundenID aus:\n");

        bool check;
        bool repeat;
        int kundenAuswahl;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            repeat = false;
            do
            {
                int zaehler = 1;
                foreach (var kunde in Verzeichnis.KundeList)
                {
                    Console.WriteLine($"({zaehler}){kunde.KundenID}");
                    zaehler++;
                }    
                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                Console.Clear();
            } while (check == false);

            Console.Clear();
            if (kundenAuswahl == 1 )
            {
                kunde1.ZeigInfo();
                kunde1.ZeigBewertung();
            }
            else if (kundenAuswahl == 2)
            {
                kunde2.ZeigInfo();
                kunde2.ZeigBewertung();
            }
            else if (kundenAuswahl == 3)
            {
                kunde3.ZeigInfo();
                kunde3.ZeigBewertung();
            }
            else if (kundenAuswahl == 4)
            {
                kunde4.ZeigInfo();
                kunde4.ZeigBewertung();
            }
            else if (kundenAuswahl == 5)
            {
                kunde5.ZeigInfo();
                kunde5.ZeigBewertung();
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
            }
        } while (repeat == true);

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"\nDrücken Sie ENTER um fortzufahren.");
        Console.ReadLine();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Für welches Produkttyp haben Sie Interesse?");

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            repeat = false;
            int zaehler = 1;
            do
            {
                Console.WriteLine("(1)Buecher\n(2)Software\n(3)Videos");
                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                Console.Clear();
            } while (check == false);

            Console.Clear();
            if (kundenAuswahl == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                foreach (var buch in Verzeichnis.BuecherList)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n({zaehler})Name:{buch.Name}\tAutor:{buch.Autor}\tSeiten:{buch.Seite}");
                    zaehler++;
                }
            }
            else if (kundenAuswahl == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                foreach (var software in Verzeichnis.SoftwareList)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n({zaehler})Name:{software.Name}\tNutzung:{software.Nutzung}\tHardware:{software.Hardware}");
                    zaehler++;
                }
            }
            else if (kundenAuswahl == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                foreach (var video in Verzeichnis.VideosList)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n({zaehler})Name:{video.Name}\tGenre:{video.Genre}\tDauer:{video.Dauer}");
                    zaehler++;
                }
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
            }
        } while (repeat == true);
    }
}