using PaternsHomework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsFactory
{
    public interface ICarFactory
    {
        ICar CreateCar(CarType carType);
    }
}
