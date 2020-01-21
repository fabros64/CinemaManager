using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    public class RoomPlace
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public CinemaHall WhichHall { get; set; }

        public RoomPlace(CinemaHall whichHall, int row, int column)
        {
            this.WhichHall = whichHall;
            this.Row = row;
            this.Column = column;
        }

        public override string ToString()
        {
            return WhichHall + "*" + Row + "*" + Column;
        }
    }

    public enum CinemaHall
    {
        Small,
        Medium,
        Big
    }
}
