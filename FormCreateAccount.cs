using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrioList
{
    public partial class FormCreateAccount : Form
    {
        User user;
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void TambahData()
        {
            if (tbUserID.Text != "" || tbPassword.Text != "")
            {
                try
                {
                    // ini kodenya, yg catch buat tahu salahnya apa
                    using (var db = new DBUserModel())
                    {
                        UserDB newUser = new UserDB
                        {
                            userID = tbUserID.Text,
                            password = tbPassword.Text
                        };
                        db.UserDBs.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("User successfully added");
                        Close();
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TambahData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
