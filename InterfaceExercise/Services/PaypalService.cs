﻿using Services.Interfaces;

namespace Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }

        public double Interest(double amount, int months)
        {
            double rate = amount * 0.01 * months;
            return amount + rate;
        }
    }
}
