using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp9.Receiver;

namespace ConsoleApp9.Command
{
    public class Banana : IPeelable
    {
        Hands hands;
        public Banana(Hands hands)
        {
            this.hands = hands;
        }
        public void Peel()
        {
            hands.Wash();
            Console.WriteLine("Peel a banana.");
        }
    }
}
