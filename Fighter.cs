using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    public class Fighter : Person
    {
        public int HitPoints { get; set; }

        public Fighter(string name) : base(name)
        {
            this.HitPoints = 100;
        }
    }
}
