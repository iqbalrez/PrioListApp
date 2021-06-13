
namespace PrioList
{
    partial class FormHapusNormal
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
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnRemoveImportant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImportant)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(239, 104);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(452, 26);
            this.tbTaskName.TabIndex = 4;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(59, 104);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(143, 20);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Normal Task Name";
            // 
            // btnRemoveImportant
            // 
            this.btnRemoveImportant.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImportant.BackgroundImage = global::PrioList.Resource1.btnRemove;
            this.btnRemoveImportant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveImportant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImportant.Location = new System.Drawing.Point(543, 155);
            this.btnRemoveImportant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveImportant.Name = "btnRemoveImportant";
            this.btnRemoveImportant.Size = new System.Drawing.Size(148, 54);
            this.btnRemoveImportant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemoveImportant.TabIndex = 19;
            this.btnRemoveImportant.TabStop = false;
            this.btnRemoveImportant.Click += new System.EventHandler(this.btnRemoveImportant_Click);
            // 
            // FormHapusNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.btnRemoveImportant);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.lblTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHapusNormal";
            this.Text = "FormHapusNormal";
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveImportant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.PictureBox btnRemoveImportant;
    }
}