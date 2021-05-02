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
    public partial class MainForm : Form
    {
        BindingSource tasks = new BindingSource();
        public MainForm(string userID)
        {
            InitializeComponent();
            label3.Text = userID;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewTaskForm addNewTask = new AddNewTaskForm(); 
            addNewTask.Show();
        }
    }
}
