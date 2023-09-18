using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Buecherei;

abstract class Person
{
    protected Person(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }

    public string Name { get; protected set; }
    public int Alter { get; protected set; }
}
