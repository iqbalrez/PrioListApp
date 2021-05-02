using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrioList
{
    public partial class LoginForm : Form
    {
        User user1 = new User("irharsy", "iqbal");
        public LoginForm()
        {
            InitializeComponent();
            lblTempMessage.Text = "Gunakan user ID: irharsy dan password: iqbal\n(Akun sementara)";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user1.Verify(tbUserID.Text, tbPassword.Text))
            {
                this.Hide();
                MainForm mainForm = new MainForm(user1.UserID);
                mainForm.Show();
            }
            else
                MessageBox.Show("User ID atau Password salah.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();
        }
    }
}
