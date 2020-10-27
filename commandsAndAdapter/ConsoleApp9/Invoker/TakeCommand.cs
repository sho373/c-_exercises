using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Invoker
{
    public class TakeCommand
    {
        private IList<IPeelable> turnOnCommands = new List<IPeelable>();

        public void getNewFruit(IPeelable fruit)
        {
            turnOnCommands.Add(fruit);
        }

        public void Start(int Number)
        {
            turnOnCommands[Number].Peel();
        }

    }

    
}
