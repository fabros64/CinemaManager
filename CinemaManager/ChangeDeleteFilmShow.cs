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
    public partial class ChangeDeleteFilmShow : Form
    {
        private bool isEdit;
        private const int WidthWithEdit = 667;
        private const int WidthNoneEdit = 301;
        private FilmShow _selectedFilmShow = new FilmShow();
        private List<FilmShow> filmShows = new List<FilmShow>();
        private FilmScreeningsDb filmScreeningsDb;

        public ChangeDeleteFilmShow()
        {
            InitializeComponent();
            PrepareForm();
        }

        private void PrepareForm()
        {
            isEdit = false;
            this.Width = WidthNoneEdit;
        }

        private void ChangeDeleteFilmShow_Load(object sender, EventArgs e)
        {
            RefreshMoviesListBox();
            RefreshFilmScreeningsListBox();           
        }

        private void RefreshMoviesListBox()
        {
            MoviesLB.DataSource = new MoviesDb("Movies.txt").Movies;
        }

        private void RefreshFilmScreeningsListBox()
        {
            List<Movie> movies = new List<Movie>();
            movies = new MoviesDb("Movies.txt").Movies;
            filmScreeningsDb = new FilmScreeningsDb("FilmShows.txt", movies);
            List<object> newestScreenings = new List<object>();
            foreach(FilmShow fs in filmScreeningsDb.FilmShows)
            {
                EditScreening es = new EditScreening 
                {
                    FilmName = movies.ElementAt(fs.MovieId-1).Name,
                    FilmDate = fs.Date,
                    FilmScreeningId = fs.Id,
                };
                newestScreenings.Add(es);
            }
            ListFilmShowsLb.DataSource = newestScreenings;

            if (newestScreenings.Count == 0)
                EditBtn.Enabled = false;
            else
                EditBtn.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;

            if (!isEdit)
            {
                EditPanel.Visible = false;
                this.Width = WidthNoneEdit;
            }
            else
            {
                EditPanel.Visible = true;
                this.Width = WidthWithEdit;
            }
        }

        private void ListFilmShowsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditScreening _selectedItem = ListFilmShowsLb.SelectedItem as EditScreening;
            _selectedFilmShow = filmScreeningsDb.FilmShows.ElementAt(_selectedItem.FilmScreeningId-1);
            RefreshFilmScreeningsPanel(_selectedItem);          
        }

        private void RefreshFilmScreeningsPanel(EditScreening selectedItem)
        {
            MoviesLB.SelectedIndex = filmScreeningsDb.FilmShows.ElementAt(selectedItem.FilmScreeningId-1).MovieId-1;
            MovieIDTb.Text = (MoviesLB.SelectedIndex+1).ToString();
        }

        private void MoviesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie _selectedMovie = MoviesLB.SelectedItem as Movie;
            RefreshMoviesPanel(_selectedMovie);
        }

        private void RefreshMoviesPanel(Movie selectedMovie)
        {
            MovieIDTb.Text = selectedMovie.Id.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            filmScreeningsDb.DeleteObj(_selectedFilmShow);
            RefreshFilmScreeningsListBox();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DateTime myDate = FilmDatePicker.Value.Date +
                    FilmTimePicker.Value.TimeOfDay;
            Movie movie = MoviesLB.SelectedItem as Movie;
            FilmShow filmShow = new FilmShow
            {
                MovieId = movie.Id,
                Date = myDate
            };

            filmScreeningsDb.EditDbObject(_selectedFilmShow.Id, filmShow);
            RefreshFilmScreeningsListBox();
        }
    }
}
