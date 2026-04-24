using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    internal interface IEngine
    {
        public void Start();
        public void Stop();
        void SetSpeed(int speed);


    }
}
