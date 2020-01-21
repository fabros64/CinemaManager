using CinemaManager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Model
{
    class Movie : DbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

        public override string ToString()
        {
            return Name.Replace(' ', '_') + " " + Price + " " + Description.Replace(' ', '_')
                + " " + Rate;            
        }
    }

    public class MovieErrors
    {
        public bool NameError { get; set; }
        public bool PriceError { get; set; }
        public bool DescriptionError { get; set; }
        public bool RateError { get; set; }
    }




}
