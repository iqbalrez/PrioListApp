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
    public partial class AddNewTaskForm : Form
    {
        public AddNewTaskForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TambahTask();
        }

        private void TambahTask()
        {
            using (var db = new TaskListModel())
                if (tbTaskName.Text != "" && dtpDeadline.Text != "")
                {
                    int prioLevel;
                    DateTime deadline = DateTime.Parse(dtpDeadline.Text);
                    if (cbPriorityLevel.Text == "Important")
                    {
                        prioLevel = 2;
                    }
                    else prioLevel = 1;
                    TaskList newTask = new TaskList
                    {
                        TaskName = tbTaskName.Text,
                        Deadline = deadline,
                        PriorityLevel = cbPriorityLevel.Text,
                        PrioLev = prioLevel
                    };
                    db.TaskLists.Add(newTask);
                    db.SaveChanges();
                    MessageBox.Show("Task baru sudah dibuat!");
                    Close();
                }
                else MessageBox.Show("Masukkan nama task!");
        }
    }
}
