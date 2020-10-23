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
            IOCContainer.AddAsSingleton<IHumanService>(() => new HumanService());

            IHuman human = new Human()
            {
                Name = "giorgi",
                Age = 16,
                Surname = "abesadze"
            };
            IOCContainer.Get<IHumanService>().PrintHumanFullInfo(human);
            Console.ReadKey();
        }
    }
}
