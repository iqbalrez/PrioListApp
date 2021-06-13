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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateAccount createAccount = new FormCreateAccount();
            createAccount.Show();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            bool Verify = false;
            using (var db = new DBUserModel())
            {
                var query = from UserDB in db.UserDBs where UserDB.userID == tbUserID.Text && UserDB.password == tbPassword.Text select UserDB;
                foreach (var item in query)
                {
                    User user1 = new User(item.userID, item.password);
                    FormMain mainForm = new FormMain(tbUserID.Text);
                    mainForm.Show();
                    Verify = true;
                }
            }
            if (Verify)
            {
                MessageBox.Show("Login success");
            }
            else
                MessageBox.Show("UserID and Password is not registered");
        }
    }
}
