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
        bool repeatProdukt;
        int kundenAuswahl;
        int kundenErsteAuswahl;
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
            if (kundenAuswahl == 1)
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

        while(true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int zaehler = 1;
            do
            {
                Console.WriteLine("Für welches Produkttyp haben Sie Interesse?");
                Console.WriteLine("\n(1)Bücher\n(2)Software\n(3)Videos");
                Console.WriteLine("(4)Ich würde lieber ihre Bücherei verlassen.");
                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                Console.Clear();
            } while (check == false);

            Console.Clear();
            if (kundenAuswahl == 1)
            {
                do
                {
                    zaehler = 1;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                    foreach (var buch in Verzeichnis.BuecherList)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n({zaehler}){buch.Name}, geschrieben von {buch.Autor}\t, mit{buch.Seite} Seiten.");
                        zaehler++;
                    }
                    repeatProdukt = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nFür welches Produkt haben Sie Interesse?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n(6)Ich würde lieber ein anderes Produkttyp auswählen.");

                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out kundenErsteAuswahl);
                        Console.Clear();
                    } while (check == false);

                    if (kundenErsteAuswahl == 1)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit das Buch {buecher1.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if(kundenAuswahl == 1)
                            {
                                buecher1.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                buecher1.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                buecher1.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);

                    }
                    else if (kundenErsteAuswahl == 2)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit das Buch {buecher2.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                buecher2.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                buecher2.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                buecher2.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 3)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit das Buch {buecher3.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                buecher3.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                buecher3.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                buecher3.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 4)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit das Buch {buecher4.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                buecher4.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                buecher4.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                buecher4.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 5)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit das Buch {buecher5.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                buecher5.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                buecher5.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                buecher5.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }    
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 6)
                    {
                        repeatProdukt = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
                    }

                } while (repeatProdukt == true);
            }
            else if (kundenAuswahl == 2)
            {
                do
                {
                    zaehler = 1;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                    foreach (var software in Verzeichnis.SoftwareList)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n({zaehler}){software.Name}, als {software.Nutzung}, für {software.Hardware}.");
                        zaehler++;
                    }
                    repeatProdukt = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nFür welches Produkt haben Sie Interesse?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n(6)Ich würde lieber ein anderes Produkttyp auswählen.");

                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out kundenErsteAuswahl);
                        Console.Clear();
                    } while (check == false);

                    if (kundenErsteAuswahl == 1)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit der Software {software1.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                software1.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                software1.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                software1.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);

                    }
                    else if (kundenErsteAuswahl == 2)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit der Software {software2.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                software2.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                software2.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                software2.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 3)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit der Software {software3.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                software3.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                software3.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                software3.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 4)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit der Software {software4.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                software4.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                software4.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                software4.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 5)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit der Software {software5.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                software5.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                software5.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                software5.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 6)
                    {
                        repeatProdukt = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
                    }
                } while (repeatProdukt == true);
            }
            else if (kundenAuswahl == 3)
            {
                do
                {
                    zaehler = 1;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nHier ist eine Liste von dem, was wir haben");
                    foreach (var video in Verzeichnis.VideosList)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n({zaehler}){video.Name}, Genre {video.Genre}, und Dauer: {video.Dauer}.");
                        zaehler++;
                    }
                    repeatProdukt = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nFür welches Produkt haben Sie Interesse?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n(6)Ich würde lieber ein anderes Produkttyp auswählen.");

                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out kundenErsteAuswahl);
                        Console.Clear();
                    } while (check == false);

                    if (kundenErsteAuswahl == 1)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit dem Video {video1.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                video1.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                video1.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                video1.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);

                    }
                    else if (kundenErsteAuswahl == 2)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit dem Video {video2.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                video2.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                video2.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                video2.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 3)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit dem Video {video3.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                video3.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                video3.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                video3.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 4)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit dem Video {video4.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                video4.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                video4.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                video4.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 5)
                    {
                        bool repeatProdukt2 = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Was möchten Sie mit dem Video {video5.Name} tun?");
                            Console.WriteLine("\n\n(1)Verfügbarkeit überprüfen\n(2)Ausleihen\n(3)Zurückgeben\n(4)Ein anderes Produkt auswählen");
                            do
                            {
                                check = int.TryParse(Console.ReadLine(), out kundenAuswahl);
                                Console.Clear();
                            } while (check == false);

                            if (kundenAuswahl == 1)
                            {
                                video5.Verleihbar();
                            }
                            else if (kundenAuswahl == 2)
                            {
                                video5.Ausleihen();
                            }
                            else if (kundenAuswahl == 3)
                            {
                                video5.Ruecknahme();
                            }
                            else if (kundenAuswahl == 4)
                            {
                                repeatProdukt2 = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nBitte wählen Sie richtig aus.\nDrücken Sie ENTER um fortzufahren.");
                                Console.ReadLine();
                            }
                        } while (repeatProdukt2 == true);
                    }
                    else if (kundenErsteAuswahl == 6)
                    {
                        repeatProdukt = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
                    }
                } while (repeatProdukt == true);
            }
            else if (kundenAuswahl == 4)
            {
                Environment.Exit(0);
            }    
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBitte wählen Sie richtig aus.\n");
            }
        }
    }
}