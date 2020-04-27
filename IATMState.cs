using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo
{
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pin);
        void RequestCash(int cashWithDraw);
    }
}
