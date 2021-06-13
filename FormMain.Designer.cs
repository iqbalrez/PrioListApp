
namespace PrioList
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgTaskListNormal = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioLevNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgTaskListImportant = new System.Windows.Forms.DataGridView();
            this.TaskImportant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateImportant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioLevImportant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRemoveImportant = new System.Windows.Forms.PictureBox();
            this.btnRemoveNormal = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskListNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskListImportant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImportant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hello,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 49);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 27);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "lblName";
            // 
            // dgTaskListNormal
            // 
            this.dgTaskListNormal.AllowUserToAddRows = false;
            this.dgTaskListNormal.AllowUserToDeleteRows = false;
            this.dgTaskListNormal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgTaskListNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskListNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.DueDate,
            this.PrioLevNormal,
            this.setDone});
            this.dgTaskListNormal.GridColor = System.Drawing.SystemColors.Control;
            this.dgTaskListNormal.Location = new System.Drawing.Point(644, 140);
            this.dgTaskListNormal.Name = "dgTaskListNormal";
            this.dgTaskListNormal.ReadOnly = true;
            this.dgTaskListNormal.RowHeadersWidth = 32;
            this.dgTaskListNormal.RowTemplate.Height = 28;
            this.dgTaskListNormal.Size = new System.Drawing.Size(598, 448);
            this.dgTaskListNormal.TabIndex = 5;
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 8;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            this.Task.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 150;
            // 
            // PrioLevNormal
            // 
            this.PrioLevNormal.HeaderText = "Level";
            this.PrioLevNormal.MinimumWidth = 8;
            this.PrioLevNormal.Name = "PrioLevNormal";
            this.PrioLevNormal.ReadOnly = true;
            this.PrioLevNormal.Width = 150;
            // 
            // setDone
            // 
            this.setDone.HeaderText = "Done";
            this.setDone.MinimumWidth = 8;
            this.setDone.Name = "setDone";
            this.setDone.ReadOnly = true;
            this.setDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.setDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.setDone.Width = 150;
            // 
            // dgTaskListImportant
            // 
            this.dgTaskListImportant.AllowUserToAddRows = false;
            this.dgTaskListImportant.AllowUserToDeleteRows = false;
            this.dgTaskListImportant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgTaskListImportant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskListImportant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskImportant,
            this.DueDateImportant,
            this.PrioLevImportant,
            this.dataGridViewTextBoxColumn1});
            this.dgTaskListImportant.GridColor = System.Drawing.SystemColors.Control;
            this.dgTaskListImportant.Location = new System.Drawing.Point(24, 140);
            this.dgTaskListImportant.Name = "dgTaskListImportant";
            this.dgTaskListImportant.ReadOnly = true;
            this.dgTaskListImportant.RowHeadersWidth = 32;
            this.dgTaskListImportant.RowTemplate.Height = 28;
            this.dgTaskListImportant.Size = new System.Drawing.Size(600, 448);
            this.dgTaskListImportant.TabIndex = 13;
            // 
            // TaskImportant
            // 
            this.TaskImportant.HeaderText = "Task";
            this.TaskImportant.MinimumWidth = 8;
            this.TaskImportant.Name = "TaskImportant";
            this.TaskImportant.ReadOnly = true;
            this.TaskImportant.Width = 150;
            // 
            // DueDateImportant
            // 
            this.DueDateImportant.HeaderText = "Due Date";
            this.DueDateImportant.MinimumWidth = 8;
            this.DueDateImportant.Name = "DueDateImportant";
            this.DueDateImportant.ReadOnly = true;
            this.DueDateImportant.Width = 150;
            // 
            // PrioLevImportant
            // 
            this.PrioLevImportant.HeaderText = "Level";
            this.PrioLevImportant.MinimumWidth = 8;
            this.PrioLevImportant.Name = "PrioLevImportant";
            this.PrioLevImportant.ReadOnly = true;
            this.PrioLevImportant.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Done";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnRemoveImportant
            // 
            this.btnRemoveImportant.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImportant.BackgroundImage = global::PrioList.Resource1.btnRemove;
            this.btnRemoveImportant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveImportant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImportant.Location = new System.Drawing.Point(456, 495);
            this.btnRemoveImportant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveImportant.Name = "btnRemoveImportant";
            this.btnRemoveImportant.Size = new System.Drawing.Size(148, 54);
            this.btnRemoveImportant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemoveImportant.TabIndex = 18;
            this.btnRemoveImportant.TabStop = false;
            this.btnRemoveImportant.Click += new System.EventHandler(this.btnRemoveImportant_Click);
            // 
            // btnRemoveNormal
            // 
            this.btnRemoveNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveNormal.BackgroundImage = global::PrioList.Resource1.btnRemove;
            this.btnRemoveNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveNormal.Location = new System.Drawing.Point(1076, 495);
            this.btnRemoveNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveNormal.Name = "btnRemoveNormal";
            this.btnRemoveNormal.Size = new System.Drawing.Size(148, 54);
            this.btnRemoveNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemoveNormal.TabIndex = 17;
            this.btnRemoveNormal.TabStop = false;
            this.btnRemoveNormal.Click += new System.EventHandler(this.btnRemoveNormal_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PrioList.Resource1.btn_close;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(1250, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PrioList.Resource1.refresh;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(1215, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImage = global::PrioList.Resource1.Asset_12;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Location = new System.Drawing.Point(1104, 620);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(138, 54);
            this.btnAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PrioList.Resource1.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1076, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PrioList.Resource1.pb1_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-262, -205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 1048);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnRemoveImportant);
            this.Controls.Add(this.btnRemoveNormal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgTaskListImportant);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgTaskListNormal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrioList";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskListNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskListImportant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImportant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgTaskListNormal;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnAddNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgTaskListImportant;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioLevNormal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn setDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskImportant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateImportant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioLevImportant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnRemoveImportant;
        private System.Windows.Forms.PictureBox btnRemoveNormal;
    }
}