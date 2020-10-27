using System;
using ConsoleApp9.Receiver;

namespace ConsoleApp9.Command
{
   public class Orange : IPeelable
    {
        Hands hands;
        public Orange(Hands hands)
        {
            this.hands =hands;
        }
        public void Peel()
        {
            hands.Wash();
            Console.WriteLine("Peel an orange.");
        }
    }
}