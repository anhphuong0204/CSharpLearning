namespace PracticeWithRef
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
            this.elephant1 = new System.Windows.Forms.Button();
            this.elephant2 = new System.Windows.Forms.Button();
            this.swapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elephant1
            // 
            this.elephant1.Location = new System.Drawing.Point(23, 25);
            this.elephant1.Name = "elephant1";
            this.elephant1.Size = new System.Drawing.Size(75, 23);
            this.elephant1.TabIndex = 0;
            this.elephant1.Text = "Adam";
            this.elephant1.UseVisualStyleBackColor = true;
            this.elephant1.Click += new System.EventHandler(this.elephant1_Click);
            // 
            // elephant2
            // 
            this.elephant2.Location = new System.Drawing.Point(23, 66);
            this.elephant2.Name = "elephant2";
            this.elephant2.Size = new System.Drawing.Size(75, 23);
            this.elephant2.TabIndex = 1;
            this.elephant2.Text = "Eva";
            this.elephant2.UseVisualStyleBackColor = true;
            this.elephant2.Click += new System.EventHandler(this.elephant2_Click);
            // 
            // swapBtn
            // 
            this.swapBtn.Location = new System.Drawing.Point(23, 112);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBtn.TabIndex = 2;
            this.swapBtn.Text = "Swap!";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 169);
            this.Controls.Add(this.swapBtn);
            this.Controls.Add(this.elephant2);
            this.Controls.Add(this.elephant1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elephant1;
        private System.Windows.Forms.Button elephant2;
        private System.Windows.Forms.Button swapBtn;
    }
}

