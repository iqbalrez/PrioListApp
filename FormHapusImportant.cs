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
    public partial class FormHapusImportant : Form
    {
        public FormHapusImportant()
        {
            InitializeComponent();
        }

        private void btnRemoveImportant_Click(object sender, EventArgs e)
        {
            using (var db = new DBImportantTaskModel())
            {
                db.ImportantTaskDBs.RemoveRange(db.ImportantTaskDBs.Where(item => item.TaskName == tbTaskName.Text));
                db.SaveChanges();
                MessageBox.Show("Tugas important berhasil dihapus");
                this.Close();
            }
        }
    }
}
