using IOT_Container.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Container.Abstraction.Services
{
    public interface IHumanService
    {
        void PrintHumanSurname(IHuman obj);
        void PrintHumanFullInfo(IHuman obj);
    }
}
