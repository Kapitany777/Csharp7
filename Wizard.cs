using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    public class Wizard : Person
    {
        public int ManaPoints { get; set; }

        public Wizard(string name) : base(name)
        {
            this.ManaPoints = 150;
        }
    }
}
