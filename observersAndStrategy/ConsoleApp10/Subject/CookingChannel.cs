using System;
using System.Collections.Generic;
using System.Text;

using ConsoleApp10.Observer;

namespace ConsoleApp10.Subject
{
    public class CookingChannel : MainYouTubeChannel, IAdsStrategy
    {
        double IAdsStrategy.GetFinalPromotionFee(double BillAmount)
        {
            return BillAmount * 0.1;
        }

    }
}
