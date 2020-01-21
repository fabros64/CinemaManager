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
    public class CashPayment : IPayment
    {
        public PaymentModel MakePayment(float price, float cash)
        {

            PaymentModel pm = new PaymentModel { Price = price };


            if (price > cash)
            {
                MessageBox.Show(string.Format("Brakuje {0} zł",price - cash), "Zapłata gotówką", MessageBoxButtons.OK);
                pm.Result = false;
            }
            else {

                var result = MessageBox.Show("Przyjmij gotówke", "Zapłata gotówką", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == result)
                {
                    pm.Result = true;
                }
                else
                {
                    pm.Result = false;
                }
            }
            return pm;
        }
    }
}
