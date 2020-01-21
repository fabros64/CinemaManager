using CinemaManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManager.Model;
using CinemaManager.Databases;

namespace CinemaManager.Managers
{
    class MovieManager : IMovie
    {
        private readonly MoviesDb _moviesDb;

        public MovieManager()
        {
            _moviesDb = new MoviesDb(ConstValue.MoviesTable + ConstValue.CurrentExtensionDatabase);
        }

        public bool AddMovie(Movie movie)
        {
            try
            {
                _moviesDb.WriteToFile(movie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangeMovie(Movie movie)
        {
            //try
            //{
                _moviesDb.EditDbObject(movie.Id, movie);
                return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public bool DeleteMoviee(Movie movie)
        {
            try
            {
                _moviesDb.DeleteObj(movie);
                return true;
            }
            catch (Exception)
            {
                //return false;
                throw;
            }
        }

        public List<Movie> LoadMovies()
        {
            return _moviesDb.ReadFromFile();
        }




    }
}
