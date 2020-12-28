using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsHomework
{
    public abstract class ICar
    {
        public int Weight { get; set; }
        public int LiftingCapacity { get; set; }
        public abstract void Go();
        public abstract void Break();
    }
}
