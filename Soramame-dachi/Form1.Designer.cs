namespace Soramame_dachi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFood = new System.Windows.Forms.Label();
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.labelWater = new System.Windows.Forms.Label();
            this.progressBarWater = new System.Windows.Forms.ProgressBar();
            this.progressBarFun = new System.Windows.Forms.ProgressBar();
            this.labelFun = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Soramame_dachi.Properties.Resources.soramame;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(12, 223);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(37, 15);
            this.labelFood.TabIndex = 1;
            this.labelFood.Text = "Food:";
            // 
            // progressBarFood
            // 
            this.progressBarFood.Location = new System.Drawing.Point(55, 218);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(100, 25);
            this.progressBarFood.TabIndex = 2;
            this.progressBarFood.Value = 100;
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Location = new System.Drawing.Point(8, 254);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(41, 15);
            this.labelWater.TabIndex = 3;
            this.labelWater.Text = "Water:";
            // 
            // progressBarWater
            // 
            this.progressBarWater.Location = new System.Drawing.Point(55, 249);
            this.progressBarWater.Name = "progressBarWater";
            this.progressBarWater.Size = new System.Drawing.Size(100, 25);
            this.progressBarWater.TabIndex = 4;
            this.progressBarWater.Value = 100;
            // 
            // progressBarFun
            // 
            this.progressBarFun.Location = new System.Drawing.Point(55, 279);
            this.progressBarFun.Name = "progressBarFun";
            this.progressBarFun.Size = new System.Drawing.Size(100, 25);
            this.progressBarFun.TabIndex = 5;
            this.progressBarFun.Value = 100;
            // 
            // labelFun
            // 
            this.labelFun.AutoSize = true;
            this.labelFun.Location = new System.Drawing.Point(19, 284);
            this.labelFun.Name = "labelFun";
            this.labelFun.Size = new System.Drawing.Size(30, 15);
            this.labelFun.TabIndex = 6;
            this.labelFun.Text = "Fun:";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(161, 218);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(51, 25);
            this.buttonFeed.TabIndex = 7;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.Location = new System.Drawing.Point(161, 249);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(51, 25);
            this.buttonWater.TabIndex = 8;
            this.buttonWater.Text = "Water";
            this.buttonWater.UseVisualStyleBackColor = true;
            this.buttonWater.Click += new System.EventHandler(this.buttonWater_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(161, 279);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(51, 25);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 307);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(200, 40);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Text = "Meet Soramame. Your new frog.";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(161, 324);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(51, 23);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 356);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonWater);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelFun);
            this.Controls.Add(this.progressBarFun);
            this.Controls.Add(this.progressBarWater);
            this.Controls.Add(this.labelWater);
            this.Controls.Add(this.progressBarFood);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Soramame-dachi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelFood;
        private ProgressBar progressBarFood;
        private Label labelWater;
        private ProgressBar progressBarWater;
        private ProgressBar progressBarFun;
        private Label labelFun;
        private Button buttonFeed;
        private Button buttonWater;
        private Button buttonPlay;
        private Label labelMessage;
        private Button buttonRestart;
    }
}