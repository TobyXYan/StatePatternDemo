using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo
{
    public class ATMMachine
    {
        #region fields
        private IATMState _hasCard;
        private IATMState _noCard;
        private IATMState _hasCorrectPin;
        private IATMState _atmOutOfMoney;
        private IATMState _atmState;

        public int  CashInMachine     = 2000;
        public bool CorrectPinEntered = false;
        #endregion

        #region props
        public IATMState YesCardState { get => _hasCard; }
        public IATMState NoCardState { get => _noCard; }
        public IATMState HasPinState { get => _hasCorrectPin; }
        public IATMState NoCashState { get => _atmOutOfMoney; }
        #endregion

        #region ctor
        public ATMMachine()
        {
            _hasCard       = new HasCard(this);
            _noCard        = new NoCard(this);
            _hasCorrectPin = new HasCorrectPin(this);
            _atmOutOfMoney = new AtmOutOfMoney(this);
            _atmState      = _noCard;

            if (CashInMachine < 0)
                _atmState = _atmOutOfMoney;
        }
        #endregion

        #region funcs
        public void SetATMState(IATMState atmState)
        {
            _atmState = atmState;
        }

        public void SetCashInMachine(int cashInMachine)
        {
            CashInMachine = cashInMachine;
        }

        public void InsertCard()
        {
            _atmState.InsertCard();
        }

        public void EjectCard()
        {
            _atmState.EjectCard();
        }

        public void RequestCash(int cashWidthDraw)
        {
            _atmState.RequestCash(cashWidthDraw);
        }

        public void InsertPin(int pin)
        {
            _atmState.InsertPin(pin);
        }
        #endregion
    }
}
