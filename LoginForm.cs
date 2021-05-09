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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Verify = false;
            using (var db = new UserInfoModel())
            {
                var query = from UserInfo in db.UserInfoes where UserInfo.username == tbUserID.Text && UserInfo.password == tbPassword.Text select UserInfo;
                foreach (var item in query)
                {
                    User user1 = new User(item.username, item.password);
                    MainForm mainForm = new MainForm(tbUserID.Text);
                    mainForm.Show();
                    Verify = true;
                }
            }
            if (Verify)
                MessageBox.Show("Login success");
            else
                MessageBox.Show("UserID and Password is not registered");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();
        }
    }
}
