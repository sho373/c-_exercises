using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp10.Observer;


namespace ConsoleApp10.Subject
{

    public class MainYouTubeChannel : IAdsStrategy
    {
        public IList<ISubscriber> subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }
        public void Unsubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscribers()
        {
            foreach(ISubscriber s in subscribers)
            {
                s.Notify();
            }
        }

        public int HowManySubscribers()
        {
            return subscribers.Count;
        }

        double IAdsStrategy.GetFinalPromotionFee(double BillAmount)
        {
            return BillAmount;
        }

    }
}
