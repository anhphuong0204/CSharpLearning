namespace BeeAssignmentVer2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.listOfJobs = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.workBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignBtn);
            this.groupBox1.Controls.Add(this.listOfJobs);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workers Bee Assignment";
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(29, 128);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(318, 23);
            this.assignBtn.TabIndex = 4;
            this.assignBtn.Text = "Assign this job to a bee";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // listOfJobs
            // 
            this.listOfJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfJobs.FormattingEnabled = true;
            this.listOfJobs.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintance",
            "Honey manufacturing",
            "Nectar collection",
            "Sting patrol"});
            this.listOfJobs.Location = new System.Drawing.Point(29, 72);
            this.listOfJobs.Name = "listOfJobs";
            this.listOfJobs.Size = new System.Drawing.Size(121, 21);
            this.listOfJobs.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(227, 73);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(13, 202);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(775, 236);
            this.reportTextBox.TabIndex = 1;
            // 
            // workBtn
            // 
            this.workBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workBtn.Location = new System.Drawing.Point(380, 13);
            this.workBtn.Name = "workBtn";
            this.workBtn.Size = new System.Drawing.Size(408, 182);
            this.workBtn.TabIndex = 5;
            this.workBtn.Text = "Work the next shift";
            this.workBtn.UseVisualStyleBackColor = true;
            this.workBtn.Click += new System.EventHandler(this.workBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workBtn);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.ComboBox listOfJobs;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Button workBtn;
    }
}

