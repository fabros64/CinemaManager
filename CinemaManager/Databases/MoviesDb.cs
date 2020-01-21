using CinemaManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Databases
{
    class MoviesDb : FileDatabaseManagement<Movie>
    {
        public List<Movie> Movies
        {
            get
            {
                return DBObjects;
            }
        }

        public MoviesDb(string fileName) : base(fileName)
        {
        }

        protected override Movie ReadSingleTxtLineToDbObj(string[] lineMembers)
        {
            return new Movie
            {
                Id = int.Parse(lineMembers[0].Trim(new char[] { '.' })),
                Name = lineMembers[1].Replace('_', ' '),
                Price = double.Parse(lineMembers[2]),
                Description = lineMembers[3].Replace('_', ' '),
                Rate = int.Parse(lineMembers[4])
            };
        }
    }
}
