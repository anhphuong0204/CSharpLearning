namespace Move_Shuffle_ResetDeskCard
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.move1To2 = new System.Windows.Forms.Button();
            this.shuffleDesk2 = new System.Windows.Forms.Button();
            this.move2To1 = new System.Windows.Forms.Button();
            this.shuffleDesk1 = new System.Windows.Forms.Button();
            this.resetDesk1 = new System.Windows.Forms.Button();
            this.resetDesk2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(221, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 238);
            this.listBox2.TabIndex = 1;
            // 
            // move1To2
            // 
            this.move1To2.Location = new System.Drawing.Point(140, 114);
            this.move1To2.Name = "move1To2";
            this.move1To2.Size = new System.Drawing.Size(75, 23);
            this.move1To2.TabIndex = 2;
            this.move1To2.Text = ">>";
            this.move1To2.UseVisualStyleBackColor = true;
            this.move1To2.Click += new System.EventHandler(this.move1To2_Click);
            // 
            // shuffleDesk2
            // 
            this.shuffleDesk2.Location = new System.Drawing.Point(221, 364);
            this.shuffleDesk2.Name = "shuffleDesk2";
            this.shuffleDesk2.Size = new System.Drawing.Size(120, 23);
            this.shuffleDesk2.TabIndex = 3;
            this.shuffleDesk2.Text = "Shuffle Desk #2";
            this.shuffleDesk2.UseVisualStyleBackColor = true;
            this.shuffleDesk2.Click += new System.EventHandler(this.shuffleDesk2_Click);
            // 
            // move2To1
            // 
            this.move2To1.Location = new System.Drawing.Point(140, 199);
            this.move2To1.Name = "move2To1";
            this.move2To1.Size = new System.Drawing.Size(75, 23);
            this.move2To1.TabIndex = 4;
            this.move2To1.Text = "<<";
            this.move2To1.UseVisualStyleBackColor = true;
            this.move2To1.Click += new System.EventHandler(this.move2To1_Click);
            // 
            // shuffleDesk1
            // 
            this.shuffleDesk1.Location = new System.Drawing.Point(14, 364);
            this.shuffleDesk1.Name = "shuffleDesk1";
            this.shuffleDesk1.Size = new System.Drawing.Size(120, 23);
            this.shuffleDesk1.TabIndex = 5;
            this.shuffleDesk1.Text = "Shuffle Desk #1";
            this.shuffleDesk1.UseVisualStyleBackColor = true;
            this.shuffleDesk1.Click += new System.EventHandler(this.shuffleDesk1_Click);
            // 
            // resetDesk1
            // 
            this.resetDesk1.Location = new System.Drawing.Point(14, 313);
            this.resetDesk1.Name = "resetDesk1";
            this.resetDesk1.Size = new System.Drawing.Size(120, 23);
            this.resetDesk1.TabIndex = 6;
            this.resetDesk1.Text = "Reset Desk #1";
            this.resetDesk1.UseVisualStyleBackColor = true;
            this.resetDesk1.Click += new System.EventHandler(this.resetDesk1_Click);
            // 
            // resetDesk2
            // 
            this.resetDesk2.Location = new System.Drawing.Point(221, 313);
            this.resetDesk2.Name = "resetDesk2";
            this.resetDesk2.Size = new System.Drawing.Size(120, 23);
            this.resetDesk2.TabIndex = 7;
            this.resetDesk2.Text = "Reset Desk #2";
            this.resetDesk2.UseVisualStyleBackColor = true;
            this.resetDesk2.Click += new System.EventHandler(this.resetDesk2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetDesk2);
            this.Controls.Add(this.resetDesk1);
            this.Controls.Add(this.shuffleDesk1);
            this.Controls.Add(this.move2To1);
            this.Controls.Add(this.shuffleDesk2);
            this.Controls.Add(this.move1To2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button move1To2;
        private System.Windows.Forms.Button shuffleDesk2;
        private System.Windows.Forms.Button move2To1;
        private System.Windows.Forms.Button shuffleDesk1;
        private System.Windows.Forms.Button resetDesk1;
        private System.Windows.Forms.Button resetDesk2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

