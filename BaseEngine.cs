using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    public abstract class BaseEngine : IEngine
    {
        protected int currentSpeed = 0;

        public abstract void Start();
        public abstract void Stop();

        public virtual void SetSpeed(int targetSpeed)
        {
            while (currentSpeed < targetSpeed)
            {
                Increase();
            }

            while (currentSpeed > targetSpeed)
            {
                Decrease();
            }
        }

        protected virtual void Increase()
        {
            currentSpeed++;
        }

        protected virtual void Decrease()
        {
            currentSpeed--;
        }
    }
}
