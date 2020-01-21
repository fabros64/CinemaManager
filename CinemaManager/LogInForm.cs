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
    public partial class LogInForm : Form
    {

        public UserDTO currentUser;
        public bool Block { get; set; }
        public LogInForm()
        {
            InitializeComponent();
        }

        

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            LogIn();         
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                LogIn();
        }

        private void LogIn()
        {
            LoginData loginData = new LoginData { Login = LoginTxtBox.Text, Password = PasswordTxtBox.Text };

            ILogIn login = new LogInManager();

            var result = login.CheckUser(loginData);

            if (result.Result)
            {
                currentUser = result.User;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ErrorLoginLabel.Visible = true;
                ErrorLoginLabel.Text = result.Message;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            if (Block)
            {
                LoginTxtBox.Enabled = false;
                LoginTxtBox.Text = currentUser.Login;
            }
        }
    }
}
