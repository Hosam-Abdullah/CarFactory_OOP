using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    internal class HybridEngine : IEngine
    {
        private  GasEngine gasEngine = new GasEngine();
        private  ElectricEngine electricEngine = new ElectricEngine();

        private IEngine Engine_now;
        private int currentSpeed = 0;

        public void Start()
        {
            Engine_now = electricEngine;
            Engine_now.Start();
        }

        public void Stop()
        {
            Engine_now?.Stop();
        }

        public void SetSpeed(int speed)
        {
            if (speed >= 50 && currentSpeed < 50)
            {
                SwitchToGas();
            }
            else if (speed < 50 && currentSpeed >= 50)
            {
                SwitchToElectric();
            }

            currentSpeed = speed;

            Engine_now.SetSpeed(speed);
            while (currentSpeed < speed)
            {
                Increase();
            }

            while (currentSpeed > speed)
            {
                Decrease();
            }
        }

        private void Decrease()
        {
            currentSpeed--;
        }

        private void Increase()
        {
            currentSpeed++;
        }

        private void SwitchToGas()
        {
            electricEngine.Stop();
            gasEngine.Start();
            Engine_now = gasEngine;
        }

        private void SwitchToElectric()
        {
            gasEngine.Stop();
            electricEngine.Start();
            Engine_now = electricEngine;
        }
    }
}
