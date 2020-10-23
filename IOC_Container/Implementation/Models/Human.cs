using IOT_Container.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOT_Container.Implementation.Models
{
    public class Human : IHuman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
    }
}
