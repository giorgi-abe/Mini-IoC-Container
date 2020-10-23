using IOT_Container.Abstraction.Models;
using IOT_Container.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_Container.Implementation.Services
{
    class HumanService : IHumanService
    {
        public void PrintHumanSurname(IHuman obj)
        {
            Console.WriteLine(obj.Surname);
        }

        public void PrintHumanFullInfo(IHuman obj)
        {
            Console.WriteLine($"{obj.Name} {obj.Age} {obj.Surname}");
        }
    }
}
