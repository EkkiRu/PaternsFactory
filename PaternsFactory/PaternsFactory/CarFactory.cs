using PaternsHomework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsFactory
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Bus:
                    return new Bus();
                case CarType.Tractor:
                    return new Tractor();
                case CarType.Truck:
                    return new Truck();
                default:
                    return new Bus();
            }
        }
    }
}
