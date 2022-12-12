using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Canine : Animal
    {
        public string OwnerName { get; set; }
        public string DogType { get; set; }
        public int NumTimesToWalk { get; set; }
        public string FavToy { get; set; }
    }
}
