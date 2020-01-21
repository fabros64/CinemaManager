using CinemaManager.Databases;
using CinemaManager.Model;
using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager
{
    public partial class ManageFilmShowForm : Form
    {
        List<Movie> movies = new List<Movie>();
        FilmScreeningsDb filmScreeningsDb;
        private Movie _selectedMovie;

        ListBox newestFilmScreeningsLB = new ListBox();

        public ManageFilmShowForm(ListBox newestFilmScreeningsLB)
        {
            InitializeComponent();
            this.newestFilmScreeningsLB = newestFilmScreeningsLB; 
            MoviesDb moviesDb = new MoviesDb("Movies.txt");
            //foreach(Movie movie in moviesDb.Movies)
            //{
            //    movies.Add(movie);
            //}
            movies = moviesDb.Movies;
            LoadMoviesList();
            filmScreeningsDb = new FilmScreeningsDb("FilmShows.txt", movies);
        }        

        private void AddFilmShowBtn_Click(object sender, EventArgs e)
        {
            AddFilmShow();
        }

        private void LoadMoviesList()
        {
            MoviesLb.DataSource = movies;
        }

        private void MoviesLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMovie = MoviesLb.SelectedItem as Movie;           
        }

        private void AddFilmShow()
        {
            try
            {
                DateTime myDate = FilmDatePicker.Value.Date +
                    FilmTimePicker.Value.TimeOfDay;
                FilmShow filmShow = new FilmShow()
                {
                    Date = myDate,
                    //Movie = _selectedMovie,
                    MovieId = _selectedMovie.Id
                };

                if (_selectedMovie == null)
                    IncorretMovie.Visible = true;
                else
                {
                    filmScreeningsDb.WriteToFile(filmShow);
                    List<NewestScreening> newestScreenings = new List<NewestScreening>();
                    foreach(FilmShow objShow in filmScreeningsDb.FilmShows)
                    {
                        NewestScreening NS = new NewestScreening
                        {
                            FilmName = movies.ElementAt(objShow.MovieId-1).Name,
                            FilmDate = objShow.Date
                        };
                        newestScreenings.Add(NS);
                    }
                    newestScreenings.OrderBy(p => p.FilmDate);
                    newestFilmScreeningsLB.DataSource = newestScreenings;
                    MessageBox.Show("Dodano seans filmowy pomyślnie");
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd");
                this.Close();
            }
            
        }


        private void DateTimeOfFilmScreening_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
