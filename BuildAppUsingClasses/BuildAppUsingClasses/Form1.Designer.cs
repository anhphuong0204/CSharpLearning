namespace BuildAppUsingClasses
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
            this.label2 = new System.Windows.Forms.Label();
            this.thingToSay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timesToSay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timesToSay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Say this :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time to say :";
            // 
            // thingToSay
            // 
            this.thingToSay.Location = new System.Drawing.Point(125, 42);
            this.thingToSay.Name = "thingToSay";
            this.thingToSay.Size = new System.Drawing.Size(100, 20);
            this.thingToSay.TabIndex = 2;
            this.thingToSay.Text = "Hello";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Talk to me !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timesToSay
            // 
            this.timesToSay.Location = new System.Drawing.Point(125, 87);
            this.timesToSay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timesToSay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timesToSay.Name = "timesToSay";
            this.timesToSay.Size = new System.Drawing.Size(100, 20);
            this.timesToSay.TabIndex = 5;
            this.timesToSay.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 165);
            this.Controls.Add(this.timesToSay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thingToSay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timesToSay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox thingToSay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown timesToSay;
    }
}

