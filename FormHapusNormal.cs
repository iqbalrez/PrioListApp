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
    public partial class FormHapusNormal : Form
    {
        public FormHapusNormal()
        {
            InitializeComponent();
        }

        private void btnRemoveImportant_Click(object sender, EventArgs e)
        {
            using (var db = new DBNormalTaskModel())
            {
                db.NormalTaskDBs.RemoveRange(db.NormalTaskDBs.Where(item => item.TaskName == tbTaskName.Text));
                db.SaveChanges();
                MessageBox.Show("Tugas normal berhasil dihapus");
                this.Close();
            }
        }
    }
}
