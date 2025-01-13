using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalInheritanceExample
{
    public class Dog : Animal
    {
        public bool IsTrained { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
        public override string ToString()
        {
            return $"Dog: {Name}, IsTrained: {IsTrained}";
        }
    }
}
