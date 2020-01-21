using CinemaManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Interfaces
{
    interface IMovie
    {

        bool AddMovie(Movie movie);

        bool DeleteMoviee(Movie movie);

        bool ChangeMovie(Movie movie);

        List<Movie> LoadMovies();

    }
}
