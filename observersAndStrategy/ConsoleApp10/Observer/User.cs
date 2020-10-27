using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Observer
{
    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User has been updated new video.");
        }
    }
}
