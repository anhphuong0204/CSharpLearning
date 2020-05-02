namespace ExcuseManagement
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
            this.folder = new System.Windows.Forms.Button();
            this.saveExcuse = new System.Windows.Forms.Button();
            this.openExcuse = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.fileDate = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(12, 155);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(75, 23);
            this.folder.TabIndex = 0;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // saveExcuse
            // 
            this.saveExcuse.Location = new System.Drawing.Point(181, 155);
            this.saveExcuse.Name = "saveExcuse";
            this.saveExcuse.Size = new System.Drawing.Size(75, 23);
            this.saveExcuse.TabIndex = 1;
            this.saveExcuse.Text = "Save";
            this.saveExcuse.UseVisualStyleBackColor = true;
            this.saveExcuse.Click += new System.EventHandler(this.saveExcuse_Click);
            // 
            // openExcuse
            // 
            this.openExcuse.Location = new System.Drawing.Point(504, 155);
            this.openExcuse.Name = "openExcuse";
            this.openExcuse.Size = new System.Drawing.Size(75, 23);
            this.openExcuse.TabIndex = 2;
            this.openExcuse.Text = "Open";
            this.openExcuse.UseVisualStyleBackColor = true;
            this.openExcuse.Click += new System.EventHandler(this.openExcuse_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Location = new System.Drawing.Point(342, 155);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(75, 23);
            this.randomExcuse.TabIndex = 3;
            this.randomExcuse.Text = "Random";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(99, 9);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(480, 20);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(99, 43);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(480, 20);
            this.results.TabIndex = 6;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Used";
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(99, 78);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(318, 20);
            this.lastUsed.TabIndex = 11;
            // 
            // fileDate
            // 
            this.fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileDate.Location = new System.Drawing.Point(99, 112);
            this.fileDate.Name = "fileDate";
            this.fileDate.Size = new System.Drawing.Size(318, 22);
            this.fileDate.TabIndex = 12;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\ASUS\\Desktop\\Head First C#\\ExcuseManagement\\Excuses";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 193);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.openExcuse);
            this.Controls.Add(this.saveExcuse);
            this.Controls.Add(this.folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button saveExcuse;
        private System.Windows.Forms.Button openExcuse;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Label fileDate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

