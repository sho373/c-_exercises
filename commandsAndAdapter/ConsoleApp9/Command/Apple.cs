using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp9.Receiver;

namespace ConsoleApp9.Command
{
    public class Apple : ISkinnable
    {
        SkinnerTool skinnertool;
        
        public Apple(SkinnerTool skinnertool)
        {
            this.skinnertool = skinnertool;
        }
        public void Skin()
        {
            skinnertool.Ready();
            Console.WriteLine("Skin an apple.");
        }
    }
}
