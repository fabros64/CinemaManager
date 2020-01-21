using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Databases;
using CinemaManager.Model;
using CinemaManager.Interfaces;
using CinemaManager.Managers;

namespace CinemaManager
{
    public partial class ManageMovieForm : Form
    {
        private MovieErrors _movieErrors;
        private readonly IMovie _movieDb;


        public ManageMovieForm()
        {
            InitializeComponent();
            _movieDb = new MovieManager();
        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            AddMovie();
        }

        private bool CheckPosition()
        {
            ValidatePosition();
            if (_movieErrors.NameError || _movieErrors.PriceError || _movieErrors.DescriptionError || _movieErrors.RateError)
            {
                return false;
            }
            return true;
        }

        private void ValidatePosition()
        {
            MovieErrors errors = new MovieErrors();
            errors.NameError =
                errors.PriceError =
                    errors.DescriptionError =
                        errors.RateError = false;


            if (NameTb.Text == "")
                errors.NameError = true;
            if (PriceTb.Text == "")
                errors.PriceError = true;
            if (DescriptionTb.Text == "")
                errors.DescriptionError = true;
            if (RateTb.Text == "")
                errors.RateError = true;


            _movieErrors = errors;
        }

        private void ManageMovieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddMovie();
            }
        }

        private void AddMovie()
        {
            if (CheckPosition())
            {                                

                double price;
                int rate;
                if (!double.TryParse(PriceTb.Text.Replace('.', ','), out price))
                    IncoretPrice.Visible = true;
                else
                    IncoretPrice.Visible = false;
                if (!int.TryParse(RateTb.Text, out rate))
                    IncoretRate.Visible = true;
                else
                    IncoretRate.Visible = false;
                if(double.TryParse(PriceTb.Text.Replace('.', ','), out price) &&
                   int.TryParse(RateTb.Text, out rate))
                {
                    Movie movie = new Movie()
                    {
                        Name = NameTb.Text.Replace(' ', '_'),
                        Price = double.Parse(PriceTb.Text.Replace('.',',')),
                        Description = DescriptionTb.Text.Replace(' ', '_'),
                        Rate = int.Parse(RateTb.Text)
                    };
                    _movieDb.AddMovie(movie);
                    MessageBox.Show("Pomyślnie dodano film");
                    this.Close();
                }
                              
            }

            else
            {
                if (_movieErrors.NameError)
                {
                    IncoretName.Visible = true;
                }
                if (_movieErrors.PriceError)
                {
                    IncoretPrice.Visible = true;
                }
                if (_movieErrors.DescriptionError)
                {
                    IncoretDescription.Visible = true;
                }
                if (_movieErrors.RateError)
                {
                    IncoretRate.Visible = true;
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
