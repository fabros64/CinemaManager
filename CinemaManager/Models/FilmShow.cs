using CinemaManager.Managers;
using CinemaManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    class FilmShow : DbModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        //public Movie Movie { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return MovieId +
                " " + Date.ToString();
        }
    }
}
