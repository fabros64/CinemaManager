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
    public partial class ChangeDeleteUserForm : Form
    {
        private bool isEdit;
        private const int WidthWithEdit = 540;
        private const int WidthNoneEdit = 266;
        private User _selectedUser = new User();
        private List<User> users = new List<User>();
        private UsersDb usersDb;

        public ChangeDeleteUserForm()
        {
            InitializeComponent();
            PrepareForm();
        }

        private void PrepareForm()
        {
            isEdit = false;
            this.Width = WidthNoneEdit;
        }

        private void ChangeDeleteUserForm_Load(object sender, EventArgs e)
        {
            RefreshUsersListBox();          

        }

        private void RefreshUsersListBox()
        {
            usersDb = new UsersDb("Users.txt");
            users = usersDb.Users;
            EditBtn.Enabled = users.Count != 0;

            UsersListBox.DataSource = users;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;

            if (!isEdit)
            {
                panel1.Visible = false;
                this.Width = WidthNoneEdit;
            }
            else
            {
                panel1.Visible = true;
                this.Width = WidthWithEdit;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            usersDb.DeleteObj(_selectedUser);
            RefreshUsersListBox();
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedUser = UsersListBox.SelectedItem as User;
            RefreshPanel();
        }

        private void RefreshPanel()
        {
            nameTxtBox.Text = _selectedUser.Name;
            surnameTxtBox.Text = _selectedUser.Surname;
            LoginTxtBox.Text = _selectedUser.Login;
            PasswordTxtBox.Text = _selectedUser.Password;
            if (_selectedUser.IsAdmin)
                TrueChBox.Checked = true;
            else
                FalseChBox.Checked = true;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = nameTxtBox.Text,
                Surname = surnameTxtBox.Text,
                Login = LoginTxtBox.Text,
                Password = PasswordTxtBox.Text,
                IsAdmin = TrueChBox.Checked
            };


            usersDb.EditDbObject(_selectedUser.Id, user);

            RefreshUsersListBox();
        }
    }
}
