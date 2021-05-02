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
        public string taskItem;
        public AddNewTaskForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(tbTaskName.Text, dtpDeadline.Text, cbPriorityLevel.Text);
            taskItem = tbTaskName.Text + "/t" + dtpDeadline.Text + "/t" + cbPriorityLevel.Text;
            Close();
        }
    }
}
