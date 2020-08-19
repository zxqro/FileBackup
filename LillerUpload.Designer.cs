namespace Liller_Backup_Tool_v0._1
{
    partial class Form1
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
            this.buPath = new System.Windows.Forms.TextBox();
            this.butBackup = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to backup (Default Z:\\Testing)";
            // 
            // buPath
            // 
            this.buPath.Enabled = false;
            this.buPath.Location = new System.Drawing.Point(53, 91);
            this.buPath.Name = "buPath";
            this.buPath.Size = new System.Drawing.Size(311, 22);
            this.buPath.TabIndex = 1;
            this.buPath.Text = "Z:\\Testing";
            // 
            // butBackup
            // 
            this.butBackup.Location = new System.Drawing.Point(53, 164);
            this.butBackup.Name = "butBackup";
            this.butBackup.Size = new System.Drawing.Size(127, 23);
            this.butBackup.TabIndex = 2;
            this.butBackup.Text = "Backup Now";
            this.butBackup.UseVisualStyleBackColor = true;
            this.butBackup.Click += new System.EventHandler(this.butBackup_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(237, 164);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(127, 23);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "Delete Local Files";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(53, 119);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(127, 23);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "Select folder";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(389, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 299);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uploaded Files";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butBackup);
            this.Controls.Add(this.buPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buPath;
        private System.Windows.Forms.Button butBackup;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

