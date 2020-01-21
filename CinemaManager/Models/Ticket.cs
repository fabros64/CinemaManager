using CinemaManager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    class Ticket : DbModel
    {
        public int Id { get; set; }
        public int FilmShowId { get; set; }
        public double Price { get; set; }
        public RoomPlace RoomPlace { get; set; }

        public override string ToString()
        {
            return FilmShowId + " " + Price +
                " " + RoomPlace;
        }
    }   
}
