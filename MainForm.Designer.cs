
namespace PrioList
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTaskList = new System.Windows.Forms.DataGridView();
            this.taskListDataSet = new PrioList.TaskListDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskListTableAdapter = new PrioList.TaskListDataSetTableAdapters.TaskListTableAdapter();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Task:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hello,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // dgTaskList
            // 
            this.dgTaskList.AllowUserToAddRows = false;
            this.dgTaskList.AllowUserToDeleteRows = false;
            this.dgTaskList.AutoGenerateColumns = false;
            this.dgTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskNameDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.priorityLevelDataGridViewTextBoxColumn,
            this.setDone});
            this.dgTaskList.DataSource = this.bindingSource1;
            this.dgTaskList.Location = new System.Drawing.Point(29, 89);
            this.dgTaskList.Name = "dgTaskList";
            this.dgTaskList.ReadOnly = true;
            this.dgTaskList.RowHeadersWidth = 62;
            this.dgTaskList.RowTemplate.Height = 28;
            this.dgTaskList.Size = new System.Drawing.Size(655, 243);
            this.dgTaskList.TabIndex = 5;
            // 
            // taskListDataSet
            // 
            this.taskListDataSet.DataSetName = "TaskListDataSet";
            this.taskListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TaskList";
            this.bindingSource1.DataSource = this.taskListDataSet;
            // 
            // taskListTableAdapter
            // 
            this.taskListTableAdapter.ClearBeforeFill = true;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Task Name";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            this.deadlineDataGridViewTextBoxColumn.ReadOnly = true;
            this.deadlineDataGridViewTextBoxColumn.Width = 150;
            // 
            // priorityLevelDataGridViewTextBoxColumn
            // 
            this.priorityLevelDataGridViewTextBoxColumn.DataPropertyName = "PriorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.HeaderText = "Priority Level";
            this.priorityLevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priorityLevelDataGridViewTextBoxColumn.Name = "priorityLevelDataGridViewTextBoxColumn";
            this.priorityLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityLevelDataGridViewTextBoxColumn.Width = 150;
            // 
            // setDone
            // 
            this.setDone.HeaderText = "Done";
            this.setDone.MinimumWidth = 8;
            this.setDone.Name = "setDone";
            this.setDone.ReadOnly = true;
            this.setDone.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(720, 432);
            this.Controls.Add(this.dgTaskList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrioList";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTaskList;
        private TaskListDataSet taskListDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TaskListDataSetTableAdapters.TaskListTableAdapter taskListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setDone;
    }
}