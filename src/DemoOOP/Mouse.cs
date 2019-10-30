using System;

namespace DemoOOP
{
    public class Mouse : Animal, IAnimal
    {
        public void Run()
        {
            Console.WriteLine($"Mouse name {Name} is running...");
        }

        public void Speak()
        {
            Console.WriteLine($"Mouse name {Name} speaking chit chit.........");
        }
    }
}