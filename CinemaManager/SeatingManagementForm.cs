using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CinemaManager
{
    public partial class SeatingManagementForm : Form
    {
        private int boardHeight;
        private int boardWidth;
        private int buttonHeight;

        private Button[,] buttons;

        private int buttonWidth;
        private int height;
        private int width;
        private CinemaHall size;
        private bool[,] temps;
        public static bool isNew = false;
        public static List<Cell> registeredSeats;

        public static string roomName;

        public int count { get; set; }
        public List<RoomPlace> places;

        public SeatingManagementForm()
        {
            InitializeComponent();

            boardWidth = 10;
            boardHeight = 15;
            roomName = "Średnia";
            średniaToolStripMenuItem.Checked = true;
        }

        private void SeatingManagementForm_Load(object sender, EventArgs e)
        {
            screenLoad();
           
        }

        public void FillRoomAndSeats()
        {
            
                SellTicketForm.HallTB.Text = roomName;

            if (registeredSeats != null)
            {
                foreach (var seat in registeredSeats)
                {
                    SellTicketForm.PlaceTb.Text += "M:" + seat.X + "," + "R:" + seat.Y +',';

                }
                
            }
               

        }

        public void setTabFalse(bool[,] tab)
        {

            for (var x = 0; x < boardWidth; x++)
            for (var y = 0; y < boardHeight; y++)
            {
                tab[x, y] = false;
                
            }
                
            
        }

        public void screenLoad()
        {
            seats.Controls.Clear();

            width = seats.Width;
            height = seats.Height;

            buttonWidth = width / boardWidth;
            buttonHeight = height / boardHeight;

            buttons = new Button[boardWidth, boardHeight];
            temps = new bool[boardWidth, boardHeight];
            setTabFalse(temps);


            for (var x = 0; x < boardWidth; x++)
            for (var y = 0; y < boardHeight; y++)
            {
                var button = new Button();
                button.Location = new Point(x * buttonWidth, y * buttonHeight);
                button.Size = new Size(buttonWidth, buttonHeight);


                button.Click += ButtonOnClick;
                button.Tag = new Cell(x, y);
                button.BackColor = Color.LightGray;
                buttons[x, y] = button;
                seats.Controls.Add(button);
            }

            loadCinemaHallFromFile("srednia");
           
        }


        private void ButtonOnClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            var a = button.Tag as Cell;


            if (a.IsActive)
            {
                a.IsActive = false;
                temps[a.X, a.Y] = false;

                button.BackColor = Color.LightGray;
                count--;
                return;
            }

            if (button != null && button.Tag != null)
            {
                Debug.Write(button.Tag as Cell);

                a.IsActive = true;
                temps[a.X, a.Y] = true;
                count++;
                button.BackColor = Color.Black;

            }
        }
        public void saveSeats()
        {
            places = new List<RoomPlace>();
            registeredSeats = new List<Cell>();
            for (var x = 0; x < boardWidth; x++)
            {
                for (var y = 0; y < boardHeight; y++)
                {
                    var button = buttons[x, y].Tag as Cell;
                    button.IsActive = temps[x, y];

                    if ( buttons[x, y].Enabled == true && buttons[x,y].BackColor == Color.Black)
                    {
                        registeredSeats.Add(button);

                        places.Add(new RoomPlace (size, x, y));
                    }
                    
                }
            }
        }

        public void updateButtons(Button[,] buttons, bool[,] temps)
        {
            for (var x = 0; x < boardWidth; x++)
            {
                for (var y = 0; y < boardHeight; y++)
                {
                    var button = buttons[x, y].Tag as Cell;
                    button.IsActive = temps[x, y];


                    if (button.IsActive)
                             buttons[x, y].BackColor = Color.Black;
                    else
                        buttons[x, y].BackColor = Color.LightGray;


                    if (isNew && button.IsActive)
                    {
                        buttons[x, y].Enabled = false;
                        buttons[x, y].BackColor = Color.Green;
                    }
                }
            }
        }



        void małaToolStripMenuItem_Click(object sender, EventArgs e)
            {
                średniaToolStripMenuItem.Checked = false;
                dużaToolStripMenuItem1.Checked = false;
                size = CinemaHall.Small;
                małaToolStripMenuItem.Checked = true;
                boardWidth = 10;
                boardHeight = 10;
                roomName = "Mała";

                screenLoad();
                loadCinemaHallFromFile("mala");
            }


            void średniaToolStripMenuItem_Click(object sender, EventArgs e)
            {
                dużaToolStripMenuItem1.Checked = false;
                małaToolStripMenuItem.Checked = false;
            size = CinemaHall.Medium;
            średniaToolStripMenuItem.Checked = true;
                boardWidth = 10;
                boardHeight = 15;
                roomName = "Średnia";

            screenLoad();
                loadCinemaHallFromFile("srednia");
            }


            void dużaToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                średniaToolStripMenuItem.Checked = false;
                małaToolStripMenuItem.Checked = false;
                size = CinemaHall.Big;
                dużaToolStripMenuItem1.Checked = true;
                boardWidth = 20;
                boardHeight = 20;
                roomName = "Duża";

            screenLoad();
                loadCinemaHallFromFile("duza");
            }




            void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                var save = new SaveFileDialog();

                if (małaToolStripMenuItem.Checked)
                    filePath = filePath = Path.Combine(Application.StartupPath, "mala.txt"); ;
                if (średniaToolStripMenuItem.Checked)
                    filePath = filePath = Path.Combine(Application.StartupPath, "srednia.txt"); ;
                if (dużaToolStripMenuItem1.Checked)
                    filePath = filePath = Path.Combine(Application.StartupPath, "duza.txt"); ;

                save.Filter = "Text File | *.txt";


                var writer = new StreamWriter(filePath);

                for (var x = 0; x < boardWidth; x++)

                for (var y = 0; y < boardHeight; y++)
                    writer.WriteLine(temps[x, y]);

                writer.Dispose();
                writer.Close();

               
                isNew = false;
                saveSeats();
                FillRoomAndSeats();
                MessageBox.Show("Zapis udany");
                this.Hide();


        }


            void loadCinemaHallFromFile(string size)
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Application.StartupPath;
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (małaToolStripMenuItem.Checked)
                        filePath = filePath = Path.Combine(Application.StartupPath, "mala.txt");
                    ;
                    if (średniaToolStripMenuItem.Checked)
                        filePath = filePath = Path.Combine(Application.StartupPath, "srednia.txt");
                    ;
                    if (dużaToolStripMenuItem1.Checked)
                        filePath = filePath = Path.Combine(Application.StartupPath, "duza.txt");
                    ;

                    using (var reader = new StreamReader(filePath))
                    {
                        for (var x = 0; x < boardWidth; x++)
                        for (var y = 0; y < boardHeight; y++)
                            temps[x, y] = bool.Parse(reader.ReadLine());
                        updateButtons(buttons, temps);
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
            {
                setTabFalse(temps);
                updateButtons(buttons, temps);
            }

        public class Cell
        {
            public Cell(int x, int y)
            {
                X = x;
                Y = y;
                IsActive = false;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public bool IsActive { get; set; }

            public override string ToString()
            {
                return "(" + X + ":" + Y + ")";
            }
        }
    }
}