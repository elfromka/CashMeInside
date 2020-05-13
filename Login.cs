using System;
using System.Windows.Forms;

namespace CashMeInside
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
            passwordInput.Text = "";
;        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            Tables tablesWindow = new Tables();
            tablesWindow.usernameLabelText = username;

            if ((username == "admin" && password == "admin123") || (username == "waiter" && password == "waiter123"))
            {
                this.Hide();
                tablesWindow.Show();
            }
            else
            {
                MessageBox.Show("The entered username or password is incorrect.", "Something is wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Well, that's not good... I feel sorry for you.", "You really forgot your password?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
