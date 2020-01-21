using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManager.Interfaces;
using CinemaManager.Managers.PaymentClass;
using CinemaManager.Models;

namespace CinemaManager.Managers
{
    public class PaymentFactory
    {

        public virtual IPayment CreatePaymentMethod(PaymentsMethod method)
        {
            IPayment payment = null;

            switch (method)
            {
                case PaymentsMethod.Card:
                    payment = new CardPayment();
                    break;
                case PaymentsMethod.Cash:
                    payment = new CashPayment();
                    break;
            }

            return payment;
        }

    }
}
