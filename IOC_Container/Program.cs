using IOT_Container;
using IOT_Container.Abstraction.Models;
using IOT_Container.Abstraction.Services;
using IOT_Container.Implementation.Models;
using IOT_Container.Implementation.Services;
using System;

namespace IOC_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            IOCContainer.AddAsSingleton<IAnimalService>(() => new AnimalService());

            IAnimal dog = new Animal()
            {
                Name = "Choko",
                Age = 5,
                Breed = "Kokapoo"
            };
            IOCContainer.Get<IAnimalService>().PrintAnimalFullInfo(dog);
            Console.ReadKey();
        }
    }
}
