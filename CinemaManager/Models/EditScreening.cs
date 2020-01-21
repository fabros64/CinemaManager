using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    class EditScreening
    {
        public string FilmName { get; set; }
        public DateTime FilmDate { get; set; }
        public int FilmScreeningId { get; set; }

        public override string ToString()
        {
            return FilmName + "   " + FilmDate;
        }
    }
}
