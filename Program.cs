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

        Buecher buecher1 = new Buecher(42, "Chuckle McLaughington", "Die Suche nach dem Letzten Schokoladenkekssplitter", false, false);
        Buecher buecher2 = new Buecher(101, "Gigglesworth Wobblepants", "Die Abenteuer von Sir Kitzel-viel", false, false);
        Buecher buecher3 = new Buecher(7, "Snorty McSnickerdoodle", "Das Große Bananenschalenabenteuer", false, false);
        Buecher buecher4 = new Buecher(404, "Punny O'Puns", "Das Verschwindende Wörterbuch", false, false);
        Buecher buecher5 = new Buecher(999, "Nod McChortleson", "Der Verrückte Zucchini-Zephyr", false, false);


        Software software1 = new Software("Der Ultimative Bananensortierer", "Quanten-Bananenprozessor", "BananaSorter++", false, false);
        Software software2 = new Software("Zeitreise-Simulator für Katzen", "Katzenbetriebenen Supercomputern", "Purradox Jumper", false, false);
        Software software3 = new Software("Unendlicher Cheeseburger-Generator", "Cheeseburger-fähigen Mikrowellen", "CheeseBlast Pro", false, false);
        Software software4 = new Software("Zufallssockenpaar-Algorithmus", "Sock-O-Tron 9000", "SockSync Deluxe", false, false);
        Software software5 = new Software("GPS für Astronauten im Weltraum verloren", "Raketenbetriebene Fahrräder", "GalaxyGuide Navigator", false, false);

        Videos video1 = new Videos("42 Minuten", "Komödie der verrückten Enten", "Das Watschelnde Chaos", false, false);
        Videos video2 = new Videos("17 Stunden und 38 Minuten", "Dramatische Seifenblasenoper", "Die Tragödie der Platzen", false, false);
        Videos video3 = new Videos("5 Sekunden", "Wissenschaftliche Katzenforschung", "Der Große Katzen-Physik-Showdown", false, false);
        Videos video4 = new Videos("3 Tage und 7 Nickerchen", "Fantastische Frühstücksfilme", "Die Saga der magischen Müsli", false, false);
        Videos video5 = new Videos("1 Minute und 23 Sekunden", "Abenteuerliche Gummibärenkriege", "Die epische Schlacht um die Gummibärenburg", false, false);

        Kunde kunde1 = new Kunde("KID1234", "Dieser Laden ist so großartig, dass ich tanzen möchte!", "Lachbert Lachsalot", 37);
        Kunde kunde2 = new Kunde("KID5678", "Ich bin so glücklich, dass ich hier eingekauft habe, dass ich jetzt auf Wolken schwebe!", "Scherzalina Schmunzelschön", 25);
        Kunde kunde3 = new Kunde("KID9876", "Dieser Laden hat meine Erwartungen übertroffen, und das ist schwer, denn ich hatte keine!", "Freudentänzer Frohsinn", 42);
        Kunde kunde4 = new Kunde("KID4321", "Ich fühle mich hier wie ein Lachkönig im Lachland!", "Frohbert Fröhlich", 31);
        Kunde kunde5 = new Kunde("KID2468", "Die Freude, hier einzukaufen, hat mich jünger gemacht! Ich bin jetzt 25 Jahre alt!", "Glücksstrahl Glücklichmann", 55);
    }
}