using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Container.Abstraction.Models
{
    public interface IHuman
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
    }
}
