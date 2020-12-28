using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsHomework
{
    public interface ICar
    {
        int Weight { get; set; }
        int LiftingCapacity { get; set; }
        void Go();
        void Break();
    }
}
