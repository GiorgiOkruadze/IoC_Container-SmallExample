using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Container.Abstraction.Models
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Breed { get; set; }
        int Age { get; set; }
    }
}
