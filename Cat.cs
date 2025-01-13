using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalInheritanceExample
{
    public class Cat : Animal
    {
        public string CatType { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return $"Cat: {Name}, Cat Type: {CatType}";
        }
    }
}
