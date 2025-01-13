using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceExample
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Animal: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Animal otherAnimal)
            {
                return Name.Equals(otherAnimal.Name, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.ToLower().GetHashCode() : 0;
        }

    }
}
