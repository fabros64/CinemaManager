using CinemaManager.Model;
using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Databases
{
    class FilmScreeningsDb : FileDatabaseManagement<FilmShow>
    {
        public List<FilmShow> FilmShows
        {
            get
            {
                return DBObjects;
            }
        }
        private List<Movie> Movies { get; set; }

        public FilmScreeningsDb(string fileName, List<Movie> movies) : base(fileName)
        {
            Movies = movies;
        }        

        protected override FilmShow ReadSingleTxtLineToDbObj(string[] lineMembers)
        {
            return new FilmShow
            {
                Id = int.Parse(lineMembers[0].Trim(new char[] { '.' })),
                MovieId = int.Parse(lineMembers[1]),
                Date = DateTime.Parse(lineMembers[2] + " " + lineMembers[3]),
                //Movie = Movies.ElementAt(int.Parse(lineMembers[1])-1)
            };
        }
    }
}
