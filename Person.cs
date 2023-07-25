using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    public class Person
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException("Name property cannot be null.");
        }

        public Person(string name) => this.Name = name;

        public override string ToString() => $"The name of this person is {Name}.";
    }
}
