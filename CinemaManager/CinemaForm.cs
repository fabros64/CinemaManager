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
    public partial class CinemaForm : Form
    {
        private UserDTO CurrentUser;
        Point point;

        public CinemaForm()
        {
            InitializeComponent();           
        }

        private void CinemaForm_Load(object sender, EventArgs e)
        {            
            LoadLoginForm();
            LoadNewestScreenings();
        }

        private void LoadNewestScreenings()
        {
            MoviesDb moviesDb = new MoviesDb("Movies.txt");
            List<Movie> movies = moviesDb.Movies;
            FilmScreeningsDb filmScreeningsDb = new FilmScreeningsDb("FilmShows.txt", movies);
            List<NewestScreening> newestScreenings = new List<NewestScreening>();
            foreach (FilmShow objShow in filmScreeningsDb.FilmShows)
            {
                NewestScreening NS = new NewestScreening
                {
                    FilmName = movies.ElementAt(objShow.MovieId - 1).Name,
                    FilmDate = objShow.Date
                };
                newestScreenings.Add(NS);
            }
            newestScreenings.OrderBy(p => p.FilmDate);
            NewestFilmShowsLb.DataSource = newestScreenings;
        }

        private void PrepareFormAfterLogIn()
        {
            this.Show();
            point = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
            NameLabel.Text = CurrentUser.Name;
            SurnameLabel.Text = CurrentUser.Surname;

            DateTimeLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();

            if (CurrentUser.IsAdmin)
            {
                zarejestrujNowegoUżytkownikaToolStripMenuItem.Enabled = true;
                edytujUsuńUżytkownikaToolStripMenuItem.Enabled = true;
                EmployeeLabel.Text = "Administrator";
            }

            else
            {
                zarejestrujNowegoUżytkownikaToolStripMenuItem.Enabled = false;
                edytujUsuńUżytkownikaToolStripMenuItem.Enabled = false;
                EmployeeLabel.Text = "Pracownik";
            }

        }

        private void TimerMinutes_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog(this);
            this.Visible = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoadLoginForm();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            LoadLoginForm(true);
        }


        private void LoadLoginForm(bool block = false)
        {
            LogInForm logIn = new LogInForm();
            this.Hide();

            if (block)
            {
                logIn.Block = true;
                logIn.currentUser = CurrentUser;
            }

            var result = logIn.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                CurrentUser = logIn.currentUser;

                PrepareFormAfterLogIn();
            }
            else
            {
                Application.Exit();
            }
        }

    

        private void zarząToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLoginForm();
        }

        private void zablokujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLoginForm(true);
        }

        private void zarejestrujNowegoUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog(this);           
        }

        private void dodajFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMovieForm mmf = new ManageMovieForm();

            mmf.ShowDialog(this);
        }

        private void usuńFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDeleteMovie cdm = new ChangeDeleteMovie();

            cdm.ShowDialog(this);
        }

        private void dodajSeansFilmowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFilmShowForm mfsf = new ManageFilmShowForm(NewestFilmShowsLb);

            mfsf.ShowDialog(this);
        }

        private void edytujUsuńUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDeleteUserForm changeDeleteUserForm = new ChangeDeleteUserForm();            
            changeDeleteUserForm.ShowDialog(this);
        }

        private void CinemaForm_LocationChanged(object sender, EventArgs e)
        {
           point = new Point(this.Location.X - this.Width / 2, this.Location.Y - this.Height / 2);
        }

        private void edytujUsuńSeansFilmowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDeleteFilmShow changeDeleteFilmShowForm = new ChangeDeleteFilmShow();
            changeDeleteFilmShowForm.ShowDialog(this);
        }

        private void SellTicketButton_Click(object sender, EventArgs e)
        {
            SellTicketForm sellTicketForm = new SellTicketForm();
            sellTicketForm.ShowDialog(this);

            SeatingManagementForm.registeredSeats = null;
            SeatingManagementForm.isNew = false;
        }

        private void DeleteTicketBtn_Click(object sender, EventArgs e)
        {
            DeleteTicketsForm deleteTicketsForm = new DeleteTicketsForm();
            deleteTicketsForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeatingManagementForm seatingManagementForm = new SeatingManagementForm();
            seatingManagementForm.ShowDialog(this);
        }

       
    }



}
