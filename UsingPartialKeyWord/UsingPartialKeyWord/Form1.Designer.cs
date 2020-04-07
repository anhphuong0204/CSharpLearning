namespace UsingPartialKeyWord
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
            this.toChangeColorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toChangeColorBtn
            // 
            this.toChangeColorBtn.Location = new System.Drawing.Point(358, 164);
            this.toChangeColorBtn.Name = "toChangeColorBtn";
            this.toChangeColorBtn.Size = new System.Drawing.Size(80, 75);
            this.toChangeColorBtn.TabIndex = 0;
            this.toChangeColorBtn.UseVisualStyleBackColor = true;
            this.toChangeColorBtn.Click += new System.EventHandler(this.toChangeColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toChangeColorBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toChangeColorBtn;
    }
}

