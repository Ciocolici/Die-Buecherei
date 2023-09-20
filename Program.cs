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


        Software software1 = new Software("Der Ultimative Bananensortierer", "Quanten-Bananenprozessor", "BananaSorter++", false, false);
        Software software2 = new Software("Zeitreise-Simulator für Katzen", "Katzenbetriebenen Supercomputern", "Purradox Jumper", true, false);
        Software software3 = new Software("Unendlicher Cheeseburger-Generator", "Cheeseburger-fähigen Mikrowellen", "CheeseBlast Pro", false, false);
        Software software4 = new Software("Zufallssockenpaar-Algorithmus", "Sock-O-Tron 9000", "SockSync Deluxe", false, false);
        Software software5 = new Software("GPS für Astronauten im Weltraum verloren", "Raketenbetriebene Fahrräder", "GalaxyGuide Navigator", true, true);

        Videos video1 = new Videos("42 Minuten", "Komödie der verrückten Enten", "Das Watschelnde Chaos", true, false);
        Videos video2 = new Videos("17 Stunden und 38 Minuten", "Dramatische Seifenblasenoper", "Die Tragödie der Platzen", false, false);
        Videos video3 = new Videos("5 Sekunden", "Wissenschaftliche Katzenforschung", "Der Große Katzen-Physik-Showdown", true, true);
        Videos video4 = new Videos("3 Tage und 7 Nickerchen", "Fantastische Frühstücksfilme", "Die Saga der magischen Müsli", false, false);
        Videos video5 = new Videos("1 Minute und 23 Sekunden", "Abenteuerliche Gummibärenkriege", "Die epische Schlacht um die Gummibärenburg", false, false);

        Kunde kunde1 = new Kunde("KID1234", "5+", "Lachbert Lachsalot", 37);
        Kunde kunde2 = new Kunde("KID5678", "3-", "Scherzalina Schmunzelschön", 25);
        Kunde kunde3 = new Kunde("KID9876", "4", "Freudentänzer Frohsinn", 42);
        Kunde kunde4 = new Kunde("KID4321", "1-", "Frohbert Fröhlich", 31);
        Kunde kunde5 = new Kunde("KID2468", "2+", "Glücksstrahl Glücklichmann", 55);

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\r\n _____    _           ______   _   _         _                           _ \r\n(____ \\  (_)         (____  \\ (_) (_)       | |                         (_)\r\n _   \\ \\  _   ____    ____)  ) _   _   ____ | | _    ____   ____   ____  _ \r\n| |   | || | / _  )  |  __  ( | | | | / ___)| || \\  / _  ) / ___) / _  )| |\r\n| |__/ / | |( (/ /   | |__)  )| |_| |( (___ | | | |( (/ / | |    ( (/ / | |\r\n|_____/  |_| \\____)  |______/  \\____| \\____)|_| |_| \\____)|_|     \\____)|_|\r\n                                                                           \r\n");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n\nHerzlich willkommen in unserer Bücherei!");
        Console.WriteLine("\nWählen Sie bitte ihre KundenID aus:\n");

        bool check;
        bool repeat;
        int kundenIDAuswahl;
        do
        {
            repeat = false;
            do
            {
                Console.WriteLine("(1)KID1234\n(2)KID5678\n(3)KID9876\n(4)KID4321\n(5)KID2468");
                check = int.TryParse(Console.ReadLine(), out kundenIDAuswahl);
                Console.Clear();
            } while (check == false);

            Console.Clear();
            if (kundenIDAuswahl == 1 )
            {
                kunde1.ZeigInfo();
                kunde1.ZeigBewertung();
            }
            else if (kundenIDAuswahl == 2)
            {
                kunde2.ZeigInfo();
                kunde2.ZeigBewertung();
            }
            else if (kundenIDAuswahl == 3)
            {
                kunde3.ZeigInfo();
                kunde3.ZeigBewertung();
            }
            else if (kundenIDAuswahl == 4)
            {
                kunde4.ZeigInfo();
                kunde4.ZeigBewertung();
            }
            else if (kundenIDAuswahl == 5)
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



    }
}