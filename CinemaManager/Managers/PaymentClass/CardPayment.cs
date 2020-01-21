using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Interfaces;
using CinemaManager.Models;

namespace CinemaManager.Managers.PaymentClass
{
    public class CardPayment : IPayment
    {
        public PaymentModel MakePayment(float price, float cash)
        {
            PaymentModel pm = new PaymentModel {Result = true, Price = price};

            var result = MessageBox.Show("Przyjmij karte", "Zapłata kartą", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == result)
            {
                pm.Result = true;
            }
            else
            {
                pm.Result = false;
            }

            return pm;
        }
    }
}
