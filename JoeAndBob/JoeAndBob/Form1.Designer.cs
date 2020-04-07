namespace JoeAndBob
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesBob = new System.Windows.Forms.Button();
            this.bobGivesJoe = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Location = new System.Drawing.Point(26, 28);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joeCashLabel.TabIndex = 0;
            this.joeCashLabel.Text = "label1";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Location = new System.Drawing.Point(26, 67);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobCashLabel.TabIndex = 1;
            this.bobCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(26, 109);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give Joe 10$";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive 5$ from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesBob
            // 
            this.joeGivesBob.Location = new System.Drawing.Point(174, 150);
            this.joeGivesBob.Name = "joeGivesBob";
            this.joeGivesBob.Size = new System.Drawing.Size(114, 23);
            this.joeGivesBob.TabIndex = 5;
            this.joeGivesBob.Text = "Joe gives Bob 5$";
            this.joeGivesBob.UseVisualStyleBackColor = true;
            this.joeGivesBob.Click += new System.EventHandler(this.joeGivesBob_Click);
            // 
            // bobGivesJoe
            // 
            this.bobGivesJoe.Location = new System.Drawing.Point(174, 199);
            this.bobGivesJoe.Name = "bobGivesJoe";
            this.bobGivesJoe.Size = new System.Drawing.Size(114, 23);
            this.bobGivesJoe.TabIndex = 6;
            this.bobGivesJoe.Text = "Bob give Joe 10$";
            this.bobGivesJoe.UseVisualStyleBackColor = true;
            this.bobGivesJoe.Click += new System.EventHandler(this.bobGivesJoe_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(174, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(114, 99);
            this.exit.TabIndex = 7;
            this.exit.Text = "Stop fooling around";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 266);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bobGivesJoe);
            this.Controls.Add(this.joeGivesBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesBob;
        private System.Windows.Forms.Button bobGivesJoe;
        private System.Windows.Forms.Button exit;
    }
}

