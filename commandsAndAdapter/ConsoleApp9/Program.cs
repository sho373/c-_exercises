using System;
using System.Collections.Generic;
using ConsoleApp9.Adapters;
using ConsoleApp9.Receiver;
using ConsoleApp9.Invoker;
using ConsoleApp9.Command;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteClient();
        }

        private static void ExecuteClient()
        {

            Hands myHands = new Hands();
            SkinnerTool skinner = new SkinnerTool();

           
            Orange orange = new Orange(myHands);
            Banana banana = new Banana(myHands);
            Grape grape = new Grape(myHands);
            Apple apple = new Apple(skinner);

            SkinnableToPeelabeAdapter skinneable = new SkinnableToPeelabeAdapter(apple);

            TakeCommand take = new TakeCommand();

            take.getNewFruit(orange);
            take.getNewFruit(banana);
            take.getNewFruit(grape);
            take.getNewFruit(skinneable);

            //peer all the fruit
            take.Start(0);
            take.Start(1);
            take.Start(2);
            take.Start(3);
        }
    }
}
