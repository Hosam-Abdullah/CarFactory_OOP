using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    internal static class CreatCar
    {
        public static Car CreateCar(EngineType type)
        {
            var car = new Car();
            InstallEngine(car, type);
            return car;
        }

        public static void InstallEngine(Car car, EngineType type)
        {
            

            var newEngine = CreateEngine(type);

            car.SetEngine(newEngine);
        }
        private static IEngine CreateEngine(EngineType type)
        {
            switch (type)
            {
                case EngineType.Gas:
                    return new GasEngine();

                case EngineType.Electric:
                    return new ElectricEngine();

                case EngineType.Hybrid:
                    return new HybridEngine();

                default:
                    throw new Exception("Invalid engine type");
            }
        }
    }
}
