using CinemaManager.Interfaces;
using CinemaManager.Managers;
using CinemaManager.Model;
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
    public partial class ChangeDeleteMovie : Form
    {
        private bool isEdit;
        private readonly IMovie _moviesDb;
        private List<Movie> Movies { get; set; }

        private Movie _selectedMovie;

        private const int WidthWithEdit = 536;

        private const int WidthNoneEdit = 250;

        public ChangeDeleteMovie()
        {
            InitializeComponent();
            PrepareForm();
            _moviesDb = new MovieManager();
        }

        private void PrepareForm()
        {
            isEdit = false;
            this.Width = WidthNoneEdit;
        }

        private void ChangeDeleteMovie_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            Movies = _moviesDb.LoadMovies();

            EditBtn.Enabled = Movies.Count != 0;

            ListMoviesLb.DataSource = Movies;
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


        private void ListMoviesLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMovie = ListMoviesLb.SelectedItem as Movie;
            RefreshPanel();
        }

        private void RefreshPanel()
        {
            NameTb.Text = _selectedMovie.Name;
            PriceTb.Text = _selectedMovie.Price.ToString();
            RateTb.Text = _selectedMovie.Rate.ToString();
            DescriptionTb.Text = _selectedMovie.Description;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            bool result = true;
            //try
            //{

                _selectedMovie.Name = NameTb.Text.Replace(' ', '_');
                _selectedMovie.Rate = int.Parse(RateTb.Text);
                _selectedMovie.Description = DescriptionTb.Text.Replace(' ', '_');
                _selectedMovie.Price = double.Parse(PriceTb.Text.Replace('.', ','));


                result = _moviesDb.ChangeMovie(_selectedMovie);

                RefreshListBox();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Wystąpił nieoczekiwany błąd");
            //}

            //ShowError(result, "Wystąpił błąd z modyfikacją filmu");
        }

        private static void ShowError(bool result,string com)
        {
            if (!result)
            {
                MessageBox.Show(com);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _moviesDb.DeleteMoviee(_selectedMovie);
            RefreshListBox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
