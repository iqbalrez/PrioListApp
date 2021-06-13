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
    public partial class FormAddNewTask : Form
    {
        public FormAddNewTask(string username)
        {
            InitializeComponent();
            lblName.Text = username;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (cbPriorityLevel.Text != "Normal")
            {
                TambahImportantTask();
            }
            else TambahNormalTask();
        }

        private void TambahImportantTask()
        {
            using (var db = new DBImportantTaskModel())
                if (tbTaskName.Text != "" && dtpDeadline.Text != "")
                {
                    int prioLevel;
                    DateTime deadline = DateTime.Parse(dtpDeadline.Text);
                    if (cbPriorityLevel.Text == "Important 1")
                    {
                        prioLevel = 1;
                    }
                    else if (cbPriorityLevel.Text == "Important 2")
                    {
                        prioLevel = 2;
                    }
                    else prioLevel = 3;
                    ImportantTaskDB newImportantTask = new ImportantTaskDB
                    {
                        TaskName = tbTaskName.Text,
                        Deadline = deadline,
                        PriorityLevel = cbPriorityLevel.Text,
                        PrioLev = prioLevel,
                        userID = lblName.Text
                    };
                    db.ImportantTaskDBs.Add(newImportantTask);
                    db.SaveChanges();
                    MessageBox.Show("Important task baru sudah dibuat!");
                    Close();
                }
                else MessageBox.Show("Masukkan nama task!");
        }

        private void TambahNormalTask()
        {
            using (var db = new DBNormalTaskModel())
                if (tbTaskName.Text != "" && dtpDeadline.Text != "")
                {
                    DateTime deadline = DateTime.Parse(dtpDeadline.Text);
                    NormalTaskDB newNormalTask = new NormalTaskDB
                    {
                        TaskName = tbTaskName.Text,
                        Deadline = deadline,
                        PriorityLevel = cbPriorityLevel.Text,
                        PrioLev = 0,
                        userID = lblName.Text
                    };
                    db.NormalTaskDBs.Add(newNormalTask);
                    db.SaveChanges();
                    MessageBox.Show("Normal task baru sudah dibuat!");
                    Close();
                }
                else MessageBox.Show("Masukkan nama task!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
