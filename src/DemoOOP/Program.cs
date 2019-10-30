using System;
using System.Collections.Generic;

namespace DemoOOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("My Pets Shop!");

            var animals = new List<IAnimal>();

            IAnimal animal = new Cat { Name = "Tom" };
            animals.Add(animal);

            animal = new Dog { Name = "Chichihuahua" };
            animals.Add(animal);

            animal = new Mouse { Name = "Micky" };
            animals.Add(animal);

            AnimalManagement.ShowAll(animals);

            Console.ReadKey();
        }
    }
}