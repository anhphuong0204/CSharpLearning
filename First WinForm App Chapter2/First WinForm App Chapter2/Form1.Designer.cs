namespace First_WinForm_App_Chapter2
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
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.toChangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(12, 12);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(157, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Change the label if checked";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(362, 12);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(110, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Enable to change";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // toChangeLabel
            // 
            this.toChangeLabel.Location = new System.Drawing.Point(12, 69);
            this.toChangeLabel.Name = "toChangeLabel";
            this.toChangeLabel.Size = new System.Drawing.Size(460, 23);
            this.toChangeLabel.TabIndex = 2;
            this.toChangeLabel.Text = "Press the button to change my text";
            this.toChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.toChangeLabel);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label toChangeLabel;
    }
}

