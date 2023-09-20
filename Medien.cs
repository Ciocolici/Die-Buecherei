using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei;

abstract class Medien
{
    protected Medien(string name, bool verliehen, bool rueckgabefristUeberschritten)
    {
        Name = name;
        Verliehen = verliehen;
        RueckgabefristUeberschritten = rueckgabefristUeberschritten;
    }

    public string Name { get; protected set; }
    public bool Verliehen { get; protected set; }
    public bool RueckgabefristUeberschritten { get; protected set; }


    private void Verleihbar()
    {
        if (Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Das Produkt ist verliehen.");

            if (RueckgabefristUeberschritten)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Die Rückgabefrist wurde überschritten.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Die Rückgabefrist wurde nicht überschritten.");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Das Produkt ist verleihbar.");
        }
    }

    public virtual void Ausleihen()
    {
        if (!Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Erledigt. Sie haben das Produkt asugeliehen.");
            Verliehen = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Unmöglich. Leider ist das produkt schon verliehen.");
        }
    }

    public virtual void Ruecknahme()
    {
        if (Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Erledigt. Das Produkt wurde zurückgegeben.");
            Verliehen = false;
        }   
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Unmöglich. Das produkt ist nicht verliehen.");
        }
    }
}
