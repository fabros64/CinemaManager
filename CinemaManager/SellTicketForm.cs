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
    public partial class SellTicketForm : Form
    {

        private FilmShow _selectedFilmShow = new FilmShow();
        private List<FilmShow> filmShows = new List<FilmShow>();
        private FilmScreeningsDb filmScreeningsDb;
        List<Movie> movies = new List<Movie>();
        private int Count { get; set; }

        public List<RoomPlace> places; 

        public SellTicketForm()
        {
            InitializeComponent();
            
        }

        private void SellBTN_Click(object sender, EventArgs e)
        {
            if (PlaceTb.Text != "")
            {
                try
                {
                    //todo za 100 trzeba podać 
                    PaymentForm pf = new PaymentForm(float.Parse(TicketPriceTB.Text) * Count);
                    if (pf.ShowDialog(this) == DialogResult.Yes)// Jeśli form zwróci ok to drukujemy bilet, zatwierdzamy transakcje
                    {
                        // DRUKUJ PARAGON
                        this.Close();
                        TicketsDb ticketsDb = new TicketsDb("Tickets.txt", filmShows);
                        foreach (RoomPlace rp in places)
                        {
                            Ticket ticket = new Ticket
                            {
                                FilmShowId = _selectedFilmShow.Id,
                                Price = double.Parse(TicketPriceTB.Text.Replace('.', ',')),
                                RoomPlace = rp
                            };
                            ticketsDb.WriteToFile(ticket);
                        }
                    }
                    else // anulujemy transakcje, przywracanie miejsc w kinie
                    {


                    }
                }
                catch
                {

                }
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChoosePlaceBTN_Click(object sender, EventArgs e)
        {
            SeatingManagementForm.isNew = true;
            SeatingManagementForm.roomName = "";
            SeatingManagementForm.registeredSeats = null;

            PlaceTb.Text = "";
            RoomPlaceTB.Text = "";

            SeatingManagementForm seatingManagementForm = new SeatingManagementForm();
            seatingManagementForm.ShowDialog(this);
            Count = seatingManagementForm.count;
            places = seatingManagementForm.places;
            EditScreening _selectedItem = FilmScreeningsLB.SelectedItem as EditScreening;
            RefreshFilmScreeningsPanel(_selectedItem);
            int z = 5;

        }

        private void SellTicketForm_Load(object sender, EventArgs e)
        {
            RefreshFilmScreeningsListBox();
        }

        private void RefreshFilmScreeningsListBox()
        {
            movies = new List<Movie>();
            movies = new MoviesDb("Movies.txt").Movies;
            filmScreeningsDb = new FilmScreeningsDb("FilmShows.txt", movies);
            List<object> newestScreenings = new List<object>();
            foreach (FilmShow fs in filmScreeningsDb.FilmShows)
            {
                EditScreening es = new EditScreening
                {
                    FilmName = movies.ElementAt(fs.MovieId - 1).Name,
                    FilmDate = fs.Date,
                    FilmScreeningId = fs.Id,
                };
                newestScreenings.Add(es);
            }
            FilmScreeningsLB.DataSource = newestScreenings;
        }

        private void FilmScreeningsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditScreening _selectedItem = FilmScreeningsLB.SelectedItem as EditScreening;
            _selectedFilmShow = filmScreeningsDb.FilmShows.ElementAt(_selectedItem.FilmScreeningId - 1);
            RefreshFilmScreeningsPanel(_selectedItem);
        }

        private void RefreshFilmScreeningsPanel(EditScreening selectedItem)
        {
            Movie movie = movies.ElementAt(filmScreeningsDb.FilmShows.ElementAt(selectedItem.FilmScreeningId - 1).MovieId - 1);
            MovieNameTB.Text = movie.Name;
            TicketPriceTB.Text = (movie.Price*Count==0? movie.Price : movie.Price * Count).ToString();
            DateTB.Text = selectedItem.FilmDate.ToString();
            RoomPlaceTB.Text = HallTB.Text + " " + PlaceTb.Text; 
        }

        
        private void HallTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PlaceTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
