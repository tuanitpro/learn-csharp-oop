using System;

namespace DemoOOP
{
    public class Cat : Animal, IAnimal
    {
        public void Run()
        {
            Console.WriteLine($"Cat name {Name} is running...");
        }

        public void Speak()
        {
            Console.WriteLine($"Cat name {Name} speaking Meo.........");
        }
    }
}