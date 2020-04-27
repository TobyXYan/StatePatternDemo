using System;

namespace StatePatternDemo
{
    internal class NoCard : IATMState
    {
        #region fields
        private ATMMachine _atmMachineState;
        #endregion

        #region ctor
        public NoCard( ATMMachine atmMachineState)
        {
            _atmMachineState = atmMachineState;
        }
        #endregion

        #region funcs
        public void EjectCard()
        {
            Console.WriteLine("Please Enter a card first");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter a pin");
            _atmMachineState.SetATMState(_atmMachineState.YesCardState);
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("Please Enter a card first");
        }

        public void RequestCash(int cashWithDraw)
        {
            Console.WriteLine("Please Enter a card first");
        }
        #endregion
    }
}