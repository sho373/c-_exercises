using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public interface IAdsStrategy
    {
        double GetFinalPromotionFee(double BillAmount);
    }
}
