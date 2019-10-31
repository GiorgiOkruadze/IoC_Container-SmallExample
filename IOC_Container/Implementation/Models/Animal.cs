using IOT_Container.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_Container.Implementation.Models
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
    }
}
