using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsHomework
{
    public class Bus : ICar
    {
        public int Weight { get; set; }
        public int LiftingCapacity { get; set; }

        public void Break()
        {
            Console.WriteLine("Упс сломался");
        }

        public void Go()
        {
            Console.WriteLine("Чучух ту ту");
        }
    }
}
