using System;

namespace StatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var atmMachine = new ATMMachine();
            atmMachine.InsertCard();
            atmMachine.EjectCard();
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(2000);
            atmMachine.InsertCard();
            Console.ReadLine();
        }
    }
}
