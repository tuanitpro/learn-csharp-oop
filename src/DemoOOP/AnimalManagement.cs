using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOOP
{
    public class AnimalManagement
    {
        public static void ShowAll(List<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                animal.Run();
                animal.Speak();
            }
        }
    }
}