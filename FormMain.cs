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
    public partial class FormMain : Form
    {
        BindingSource TaskListBindingSource = new BindingSource();
        public FormMain(string userID)
        {
            InitializeComponent();
            lblName.Text = userID;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNewTask addNewTask = new FormAddNewTask(lblName.Text);
            addNewTask.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (var dbn = new DBNormalTaskModel())
            {
                dgTaskListNormal.Rows.Clear();
                var query = from x in dbn.NormalTaskDBs where x.userID == lblName.Text select x;
                foreach (var item in query)
                {
                    if (item.TaskName == dgTaskListNormal.CurrentCell.ToString())
                        dbn.NormalTaskDBs.Remove(item);
                }
            }
            using (var dbi = new DBImportantTaskModel())
            {
                dgTaskListNormal.Rows.Clear();
                var query = from y in dbi.ImportantTaskDBs where y.userID == lblName.Text select y;
                foreach (var item in query)
                {
                    if (item.TaskName == dgTaskListImportant.CurrentCell.ToString()) 
                        dbi.ImportantTaskDBs.Remove(item);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dgTaskListNormal.Rows.Clear();
            dgTaskListImportant.Rows.Clear();
            Update();
        }

        private void Update()
        {
            using (var dbn = new DBNormalTaskModel())
            {
                var query = from x in dbn.NormalTaskDBs where x.userID == lblName.Text select x;
                foreach (var item in query)
                {
                    dgTaskListNormal.Rows.Add(item.TaskName, item.Deadline, item.PriorityLevel, item.IsDone);
                }
            }
            using (var dbi = new DBImportantTaskModel())
            {
                var query = from y in dbi.ImportantTaskDBs where y.userID == lblName.Text select y;
                foreach (var item in query)
                {
                    dgTaskListImportant.Rows.Add(item.TaskName, item.Deadline, item.PriorityLevel, item.IsDone);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemoveNormal_Click(object sender, EventArgs e)
        {
            FormHapusNormal hapusNormal = new FormHapusNormal();
            hapusNormal.ShowDialog();
        }
        private void btnRemoveImportant_Click(object sender, EventArgs e)
        {
            FormHapusImportant hapusImportant = new FormHapusImportant();
            hapusImportant.ShowDialog();
        }
    }
}
