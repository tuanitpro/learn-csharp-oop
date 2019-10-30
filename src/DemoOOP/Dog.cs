using System;

namespace DemoOOP
{
    public class Dog : Animal, IAnimal
    {
        public void Run()
        {
            Console.WriteLine($"Dog name {Name} is running...");
        }

        public void Speak()
        {
            Console.WriteLine($"Dog name {Name} speaking Gau gau.........");
        }
    }
}