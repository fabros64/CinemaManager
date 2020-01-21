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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }


        private bool IsRegistrationValidationCorrect()
        {
            if (nameTxtBox.Text == "" || surnameTxtBox.Text == ""
                || LoginTxtBox.Text == "" || PasswordTxtBox.Text == "" ||
                (!TrueChBox.Checked && !FalseChBox.Checked))
            {
                errorLbl.Visible = true;
                return false;
            }

            return true;
        }

        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RegisterUser();
        }

        private void RegisterUser()
        {
            if (IsRegistrationValidationCorrect())
            {
                bool isAdmin;
                if (FalseChBox.Checked)
                    isAdmin = false;
                else
                    isAdmin = true;

                User user = new User()
                {
                    Name = nameTxtBox.Text,
                    Surname = surnameTxtBox.Text,
                    Login = LoginTxtBox.Text,
                    Password = PasswordTxtBox.Text,
                    IsAdmin = isAdmin
                };
                UsersDb usersDb = new UsersDb("Users.txt");
                usersDb.WriteToFile(user);
                MessageBox.Show("New user has successfuly registered");
                this.Dispose();
            }
        }
    }
}
