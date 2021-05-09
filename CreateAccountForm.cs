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
    public partial class CreateAccountForm : Form
    {
        UserInfo UserInfo;
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void TambahData()
        {
            if (tbUserID.Text != "" || tbPassword.Text != "")
            {
                using (var db = new UserInfoModel())
                {
                    UserInfo newUser = new UserInfo
                    {
                        username = tbUserID.Text,
                        password = tbPassword.Text
                    };
                    db.UserInfoes.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("User successfully added");
                    Close();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TambahData();
        }
    }
}
