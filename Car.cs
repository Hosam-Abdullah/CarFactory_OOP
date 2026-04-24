using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    internal class Car
    {
        private IEngine engine;
        private int speed = 0;

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            engine.Start();
        }

        public void Stop()
        {
            if (speed == 0)
            {
                engine.Stop();
            }
        }

        public void Accelerate()
        {
            if (speed < 200)
            {
                speed += 20;
                engine.SetSpeed(speed);
            }
        }

        public void Brake()
        {
            if (speed > 0)
            {
                speed -= 20;
                engine.SetSpeed(speed);
            }
        }
    }
}
