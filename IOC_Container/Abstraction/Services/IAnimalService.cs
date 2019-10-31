using IOT_Container.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Container.Abstraction.Services
{
    public interface IAnimalService
    {
        void PrintAnimalFullInfo(IAnimal animal);
        void PrintAnimalBreed(IAnimal animal);
    }
}
