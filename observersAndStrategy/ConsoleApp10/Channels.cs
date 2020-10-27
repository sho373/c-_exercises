using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp10.Subject;
using ConsoleApp10.Observer;

namespace ConsoleApp10
{
    public class Channels
    {

        public IAdsStrategy CurrentStrategy;
        public double BillAmount { get; set; }
        public int SubscriberNum { get; set; }
        public Channels(IAdsStrategy NewStrategy)
        {
            CurrentStrategy = NewStrategy; 
        }

        public double GetFinalBill()
        {
            return CurrentStrategy.GetFinalPromotionFee(this.BillAmount * this.SubscriberNum * 0.1 + this.BillAmount);
        }
    }
}
