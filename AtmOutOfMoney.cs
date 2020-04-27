using System;

namespace StatePatternDemo
{
    internal class AtmOutOfMoney : IATMState
    {
        #region fields
        private ATMMachine _atmMachine;
        #endregion

        #region ctor
        public AtmOutOfMoney(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }
        #endregion

        #region funcs
        public void EjectCard()
        {
            Console.WriteLine("We don't have money. You didn't enter a card.");
        }

        public void InsertCard()
        {
            Console.WriteLine("We don't have money");
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("We don't have money.");
        }

        public void RequestCash(int cashWithDraw)
        {
            Console.WriteLine("We don't have money.");
        }
        #endregion

    }
}