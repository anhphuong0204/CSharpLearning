namespace BetGreyHoundGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raceBtn = new System.Windows.Forms.Button();
            this.alBetStatus = new System.Windows.Forms.Label();
            this.johnBetStatus = new System.Windows.Forms.Label();
            this.joeBetStatus = new System.Windows.Forms.Label();
            this.betBtn = new System.Windows.Forms.Button();
            this.dogToBet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.burkToBet = new System.Windows.Forms.NumericUpDown();
            this.bettorLabel = new System.Windows.Forms.Label();
            this.alRadioBtn = new System.Windows.Forms.RadioButton();
            this.johnRadioBtn = new System.Windows.Forms.RadioButton();
            this.joeRadioBtn = new System.Windows.Forms.RadioButton();
            this.betMinLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burkToBet)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(1010, 245);
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(16, 17);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(100, 50);
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(16, 79);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(100, 50);
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(16, 202);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(100, 50);
            this.dog4.TabIndex = 3;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(16, 140);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(100, 50);
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raceBtn);
            this.groupBox1.Controls.Add(this.alBetStatus);
            this.groupBox1.Controls.Add(this.johnBetStatus);
            this.groupBox1.Controls.Add(this.joeBetStatus);
            this.groupBox1.Controls.Add(this.betBtn);
            this.groupBox1.Controls.Add(this.dogToBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.burkToBet);
            this.groupBox1.Controls.Add(this.bettorLabel);
            this.groupBox1.Controls.Add(this.alRadioBtn);
            this.groupBox1.Controls.Add(this.johnRadioBtn);
            this.groupBox1.Controls.Add(this.joeRadioBtn);
            this.groupBox1.Controls.Add(this.betMinLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // raceBtn
            // 
            this.raceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBtn.Location = new System.Drawing.Point(582, 40);
            this.raceBtn.Name = "raceBtn";
            this.raceBtn.Size = new System.Drawing.Size(230, 99);
            this.raceBtn.TabIndex = 15;
            this.raceBtn.Text = "Race!";
            this.raceBtn.UseVisualStyleBackColor = true;
            this.raceBtn.Click += new System.EventHandler(this.raceBtn_Click);
            // 
            // alBetStatus
            // 
            this.alBetStatus.AutoSize = true;
            this.alBetStatus.Location = new System.Drawing.Point(250, 113);
            this.alBetStatus.Name = "alBetStatus";
            this.alBetStatus.Size = new System.Drawing.Size(35, 13);
            this.alBetStatus.TabIndex = 14;
            this.alBetStatus.Text = "label4";
            // 
            // johnBetStatus
            // 
            this.johnBetStatus.AutoSize = true;
            this.johnBetStatus.Location = new System.Drawing.Point(250, 89);
            this.johnBetStatus.Name = "johnBetStatus";
            this.johnBetStatus.Size = new System.Drawing.Size(35, 13);
            this.johnBetStatus.TabIndex = 13;
            this.johnBetStatus.Text = "label2";
            // 
            // joeBetStatus
            // 
            this.joeBetStatus.AutoSize = true;
            this.joeBetStatus.Location = new System.Drawing.Point(250, 65);
            this.joeBetStatus.Name = "joeBetStatus";
            this.joeBetStatus.Size = new System.Drawing.Size(35, 13);
            this.joeBetStatus.TabIndex = 12;
            this.joeBetStatus.Text = "label1";
            // 
            // betBtn
            // 
            this.betBtn.Location = new System.Drawing.Point(59, 145);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(33, 23);
            this.betBtn.TabIndex = 11;
            this.betBtn.Text = "Bet";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // dogToBet
            // 
            this.dogToBet.Location = new System.Drawing.Point(230, 148);
            this.dogToBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogToBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogToBet.Name = "dogToBet";
            this.dogToBet.Size = new System.Drawing.Size(37, 20);
            this.dogToBet.TabIndex = 10;
            this.dogToBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "bucks on dog";
            // 
            // burkToBet
            // 
            this.burkToBet.Location = new System.Drawing.Point(98, 148);
            this.burkToBet.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.burkToBet.Name = "burkToBet";
            this.burkToBet.Size = new System.Drawing.Size(39, 20);
            this.burkToBet.TabIndex = 8;
            this.burkToBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bettorLabel
            // 
            this.bettorLabel.AutoSize = true;
            this.bettorLabel.Location = new System.Drawing.Point(24, 150);
            this.bettorLabel.Name = "bettorLabel";
            this.bettorLabel.Size = new System.Drawing.Size(34, 13);
            this.bettorLabel.TabIndex = 7;
            this.bettorLabel.Text = "bettor";
            // 
            // alRadioBtn
            // 
            this.alRadioBtn.AutoSize = true;
            this.alRadioBtn.Location = new System.Drawing.Point(18, 109);
            this.alRadioBtn.Name = "alRadioBtn";
            this.alRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.alRadioBtn.TabIndex = 3;
            this.alRadioBtn.TabStop = true;
            this.alRadioBtn.Text = "radioButton3";
            this.alRadioBtn.UseVisualStyleBackColor = true;
            this.alRadioBtn.CheckedChanged += new System.EventHandler(this.alRadioBtn_CheckedChanged);
            // 
            // johnRadioBtn
            // 
            this.johnRadioBtn.AutoSize = true;
            this.johnRadioBtn.Location = new System.Drawing.Point(18, 85);
            this.johnRadioBtn.Name = "johnRadioBtn";
            this.johnRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.johnRadioBtn.TabIndex = 2;
            this.johnRadioBtn.TabStop = true;
            this.johnRadioBtn.Text = "radioButton2";
            this.johnRadioBtn.UseVisualStyleBackColor = true;
            this.johnRadioBtn.CheckedChanged += new System.EventHandler(this.johnRadioBtn_CheckedChanged);
            // 
            // joeRadioBtn
            // 
            this.joeRadioBtn.AutoSize = true;
            this.joeRadioBtn.Location = new System.Drawing.Point(18, 61);
            this.joeRadioBtn.Name = "joeRadioBtn";
            this.joeRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.joeRadioBtn.TabIndex = 1;
            this.joeRadioBtn.TabStop = true;
            this.joeRadioBtn.Text = "radioButton1";
            this.joeRadioBtn.UseVisualStyleBackColor = true;
            this.joeRadioBtn.CheckedChanged += new System.EventHandler(this.joeRadioBtn_CheckedChanged);
            // 
            // betMinLabel
            // 
            this.betMinLabel.AutoSize = true;
            this.betMinLabel.Location = new System.Drawing.Point(15, 25);
            this.betMinLabel.Name = "betMinLabel";
            this.betMinLabel.Size = new System.Drawing.Size(43, 13);
            this.betMinLabel.TabIndex = 0;
            this.betMinLabel.Text = "Min Bet";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burkToBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dogToBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown burkToBet;
        private System.Windows.Forms.Label bettorLabel;
        private System.Windows.Forms.RadioButton alRadioBtn;
        private System.Windows.Forms.RadioButton johnRadioBtn;
        private System.Windows.Forms.RadioButton joeRadioBtn;
        private System.Windows.Forms.Label betMinLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.Label alBetStatus;
        private System.Windows.Forms.Label johnBetStatus;
        private System.Windows.Forms.Label joeBetStatus;
        private System.Windows.Forms.Button raceBtn;
    }
}

