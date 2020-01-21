using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Databases
{
    class TicketsDb : FileDatabaseManagement<Ticket>
    {
        public List<Ticket> Tickets
        {
            get
            {
                return DBObjects;
            }
        }

        List<FilmShow> FilmShows { get; set; }

        public TicketsDb(string fileName, List<FilmShow> filmShows) : base(fileName)
        {
            FilmShows = filmShows;
        }

        protected override Ticket ReadSingleTxtLineToDbObj(string[] lineMembers)
        {
            string[] roomPlaceMembers = lineMembers[3].Split('*');
            CinemaHall myHall;
            Enum.TryParse(roomPlaceMembers[0], out myHall);
            return new Ticket
            {
                Id = int.Parse(lineMembers[0].Trim(new char[] { '.' })),
                FilmShowId = int.Parse(lineMembers[1]),
                Price = double.Parse(lineMembers[2]),
                RoomPlace = new RoomPlace(myHall, int.Parse(roomPlaceMembers[1]), int.Parse(roomPlaceMembers[2]))                  
            };
        }
    }
}
