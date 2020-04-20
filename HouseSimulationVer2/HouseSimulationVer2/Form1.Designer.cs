namespace HouseSimulationVer2
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
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.listOfLocations = new System.Windows.Forms.ComboBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.goThruTheDoorBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.descriptionBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(313, 180);
            this.descriptionBox.TabIndex = 0;
            // 
            // listOfLocations
            // 
            this.listOfLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfLocations.FormattingEnabled = true;
            this.listOfLocations.Items.AddRange(new object[] {
            "Kitchen Room",
            "Living Room"});
            this.listOfLocations.Location = new System.Drawing.Point(93, 200);
            this.listOfLocations.Name = "listOfLocations";
            this.listOfLocations.Size = new System.Drawing.Size(232, 21);
            this.listOfLocations.TabIndex = 1;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(12, 198);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Go here:";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // goThruTheDoorBtn
            // 
            this.goThruTheDoorBtn.Location = new System.Drawing.Point(12, 256);
            this.goThruTheDoorBtn.Name = "goThruTheDoorBtn";
            this.goThruTheDoorBtn.Size = new System.Drawing.Size(313, 23);
            this.goThruTheDoorBtn.TabIndex = 3;
            this.goThruTheDoorBtn.Text = "Go thru the door";
            this.goThruTheDoorBtn.UseVisualStyleBackColor = true;
            this.goThruTheDoorBtn.Click += new System.EventHandler(this.goThruTheDoorBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(13, 227);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(312, 23);
            this.checkBtn.TabIndex = 4;
            this.checkBtn.Text = "checkBtn";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(12, 285);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(312, 23);
            this.hideBtn.TabIndex = 5;
            this.hideBtn.Text = "Hide!";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 316);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.goThruTheDoorBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.listOfLocations);
            this.Controls.Add(this.descriptionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ComboBox listOfLocations;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button goThruTheDoorBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button hideBtn;
    }
}

