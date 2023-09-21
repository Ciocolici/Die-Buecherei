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


    public void Verleihbar()
    {
        if (Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nDas Produkt ist verliehen.");

            if (RueckgabefristUeberschritten)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nDie Rückgabefrist wurde überschritten.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nDie Rückgabefrist wurde nicht überschritten.");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDas Produkt ist verleihbar.");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nDrücken Sie ENTER um fortzufahren.");
        Console.ReadLine();
    }

    public virtual void Ausleihen()
    {
        if (!Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nErledigt. Sie haben das Produkt asugeliehen.");
            Verliehen = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nUnmöglich. Leider ist das produkt schon verliehen.");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nDrücken Sie ENTER um fortzufahren.");
        Console.ReadLine();
    }

    public virtual void Ruecknahme()
    {
        if (Verliehen)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nErledigt. Das Produkt wurde zurückgegeben.");
            Verliehen = false;
            RueckgabefristUeberschritten = false;
        }   
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nUnmöglich. Das produkt ist nicht verliehen.");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nDrücken Sie ENTER um fortzufahren.");
        Console.ReadLine();
    }
}
