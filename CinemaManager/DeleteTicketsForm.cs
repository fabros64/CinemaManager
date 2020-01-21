using CinemaManager.Databases;
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
    public partial class DeleteTicketsForm : Form
    {
        private Ticket _selectedTicket = new Ticket();
        private List<Ticket> tickets = new List<Ticket>();
        private TicketsDb ticketsDb;
        private FilmScreeningsDb filmScreeningsDb;
        MoviesDb moviesDb;

        public DeleteTicketsForm()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteTicketsForm_Load(object sender, EventArgs e)
        {
            RefreshTicketsListBox();
        }

        private void RefreshTicketsListBox()
        {
            moviesDb = new MoviesDb("Movies.txt");
            filmScreeningsDb = new FilmScreeningsDb("FilmShows.txt", moviesDb.Movies);
            ticketsDb = new TicketsDb("Tickets.txt", filmScreeningsDb.FilmShows);
            List<TicketToShow> ticketsToShow = new List<TicketToShow>();

            foreach(Ticket ticket in ticketsDb.Tickets)
            {
                TicketToShow tts = new TicketToShow
                {
                    MovieName = moviesDb.Movies.ElementAt(filmScreeningsDb.FilmShows.ElementAt(ticket.FilmShowId - 1).MovieId - 1).Name,
                    Price = ticket.Price,
                    RoomPlace = ticket.RoomPlace,
                    TicketId = ticket.Id
                };
                ticketsToShow.Add(tts);
            }

            TicketsLB.DataSource = ticketsToShow;
        }

        private void TicketsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            TicketToShow tts = TicketsLB.SelectedItem as TicketToShow;
            _selectedTicket = ticketsDb.Tickets.ElementAt(tts.TicketId - 1);
            RefreshTicketPanel(_selectedTicket);
        }

        private void RefreshTicketPanel(Ticket selectedTicket)
        {
            MovieNameTB.Text = moviesDb.Movies.ElementAt(filmScreeningsDb.FilmShows.ElementAt(selectedTicket.FilmShowId - 1).MovieId - 1).Name;
            DateTB.Text = filmScreeningsDb.FilmShows.ElementAt(selectedTicket.FilmShowId - 1).Date.ToLongDateString();
            RoomPlaceTB.Text = selectedTicket.RoomPlace.ToString();
            TicketPriceTB.Text = selectedTicket.Price.ToString();
        }

        private void ReturnTicketBTN_Click(object sender, EventArgs e)
        {
            ticketsDb.DeleteObj(_selectedTicket);
            RefreshTicketsListBox();
        }
    }
}
