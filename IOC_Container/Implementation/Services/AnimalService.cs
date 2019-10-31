using IOT_Container.Abstraction.Models;
using IOT_Container.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_Container.Implementation.Services
{
    class AnimalService : IAnimalService
    {
        public void PrintAnimalBreed(IAnimal animal)
        {
            Console.WriteLine(animal.Breed);
        }

        public void PrintAnimalFullInfo(IAnimal animal)
        {
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Breed}");
        }
    }
}
