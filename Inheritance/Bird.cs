using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public string OwnerName { get; set; }
        public bool CanFly { get; set; }
        public string BirdType { get; set; }
        public double AmountOfFood { get; set; }
    }
}
