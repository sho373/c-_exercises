using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Observer
{
    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderators needs to review new video");
        }
    }
}
