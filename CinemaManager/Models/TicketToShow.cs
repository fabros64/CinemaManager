using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
   public class TicketToShow
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public RoomPlace RoomPlace { get; set; }

        public override string ToString()
        {
            return MovieName + "||  miejsce: " + RoomPlace + "||  cena: "
                + Price;
        }
    }
}
