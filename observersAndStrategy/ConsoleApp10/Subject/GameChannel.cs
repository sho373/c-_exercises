using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp10.Subject;


namespace ConsoleApp10.Observer
{
    public class GameChannel : MainYouTubeChannel, IAdsStrategy
    {
        double IAdsStrategy.GetFinalPromotionFee(double BillAmount)
        {
            return BillAmount * 0.5;
        }
    }
}
