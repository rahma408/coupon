using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponwithPercentage : Coupon
    {
        public double discPercentage = 0;

        public CouponwithPercentage(double discPcentage)
        {
            this.discPercentage = discPercentage;
        }

        public override double calculate(double originPrice)
        {
            return (100 - discPercentage) * originPrice / 100;
        }
    }
}
