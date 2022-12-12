using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    internal class Reptile : Animal
    {
        public string OwnerName { get; set; }
        public string ReptileType { get; set; }
        public bool CanBite { get; set; }
        public double HowLong { get; set; }
        
    }
}
