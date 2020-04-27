using System;

namespace StatePatternDemo
{
    internal class HasCard : IATMState
    {
        #region fields
        private ATMMachine _atmMachine;
        #endregion

        #region ctor
        public HasCard(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }
        #endregion

        #region funcs
        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            _atmMachine.SetATMState(_atmMachine.NoCardState);
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter more than 1 card");
        }

        public void InsertPin(int pin)
        {
            if(pin == 1234)
            {
                Console.WriteLine("Correct Pin");
                _atmMachine.CorrectPinEntered = true;
                _atmMachine.SetATMState(_atmMachine.HasPinState);
            }else
            {
                Console.WriteLine("Wrong Pin");
                _atmMachine.CorrectPinEntered = false;
                _atmMachine.SetATMState(_atmMachine.NoCardState);
            }
        }

        public void RequestCash(int cashWithDraw)
        {
            Console.WriteLine("Enter Pin First");
        }
        #endregion
    }
}