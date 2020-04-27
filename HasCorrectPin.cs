using System;

namespace StatePatternDemo
{
    internal class HasCorrectPin : IATMState
    {
        #region fields
        private ATMMachine _atmMachine;
        #endregion

        #region ctor
        public HasCorrectPin(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }
        #endregion

        #region funcs
        public void EjectCard()
        {
            Console.WriteLine("Card ejected");
            _atmMachine.SetATMState(_atmMachine.NoCardState);
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't insert more than onew card");
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("Already Entered Pin");
        }

        public void RequestCash(int cashWithDraw)
        {
            if(cashWithDraw > _atmMachine.CashInMachine)
            {
                Console.WriteLine("Don't have that cash");
                Console.WriteLine("Card Ejected");
                _atmMachine.SetATMState(_atmMachine.NoCardState);
            }
            else
            {
                Console.WriteLine($"{cashWithDraw} is provided by machine");
                _atmMachine.SetCashInMachine(_atmMachine.CashInMachine - cashWithDraw);
                Console.WriteLine("Card Ejected");
                _atmMachine.SetATMState(_atmMachine.NoCardState);

                if(_atmMachine.CashInMachine<= 0)
                {
                    _atmMachine.SetATMState(_atmMachine.NoCashState);
                }
            }
        }
        #endregion
    }
}