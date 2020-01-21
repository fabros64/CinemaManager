using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManager.Models;

namespace CinemaManager.Interfaces
{
    public interface IPayment
    {
        PaymentModel MakePayment(float price,float cash);
    }
}
