using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    class Tip
    {
        public string name;
        public string example;
        public string desc;
        public Tip(string Name, string Example, string Desc)
        {
            name = Name;
            example = Example;
            desc = Desc;
        }
    }
}
