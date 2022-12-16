using System.Diagnostics.Metrics;

namespace Soramame_dachi
{
    public partial class Form1 : Form
    {
        private int count = 1;
        private int buttonCount;
        private System.Windows.Forms.Timer timerLife;
        private System.Windows.Forms.Timer timerButton;
        public Form1()
        {
            InitializeComponent();
            timerLife = new System.Windows.Forms.Timer();
            timerLife.Interval = 750;
            timerLife.Tick += new EventHandler(timerLife_Tick);
            timerLife.Start();
        }

        private void timerLife_Tick(object sender, EventArgs e)
        {
            count++;
            if(count % 5 == 1)
            {
                progressBarWater.Value -= 5;
            }
            if(count % 7 == 1)
            {
                progressBarFood.Value -= 5;
                MessageUpdate();
            }
            if(count % 10 == 1)
            {
                progressBarFun.Value -= 5;
            }
            if(DeathCheck() == true) { HasDied(); }
        }

        private void MessageUpdate()
        {
            if(progressBarWater.Value < progressBarFood.Value && progressBarWater.Value < progressBarFun.Value)
            {
                if(progressBarWater.Value < 75)
                {
                    if (progressBarWater.Value < 50)
                    {
                        if (progressBarWater.Value < 25)
                        {
                            labelMessage.Text = "Soramame is really thirsty!";
                        } else labelMessage.Text = "Soramame is thirsty.";
                    } else labelMessage.Text = "Soramame is parched."; 
                } 
            } else if(progressBarFood.Value < progressBarFun.Value && progressBarFood.Value < progressBarWater.Value){
                if (progressBarFood.Value < 75)
                {
                    if (progressBarFood.Value < 50)
                    {
                        if (progressBarFood.Value < 25)
                        {
                            labelMessage.Text = "Soramame is really hungry!";
                        } else labelMessage.Text = "Soramame is hungry.";
                    } else labelMessage.Text = "Soramame is peckish.";
                }
            } else if(progressBarFun.Value < progressBarFood.Value && progressBarFun.Value < progressBarWater.Value)
            {
                if (progressBarFun.Value < 75)
                {
                    if (progressBarFun.Value < 50)
                    {
                        if (progressBarFun.Value < 25)
                        {
                            labelMessage.Text = "Soramame is really bored!";
                        }
                        else labelMessage.Text = "Soramame is bored.";
                    }else labelMessage.Text = "Soramame is looking for something to do.";
                }
            } else labelMessage.Text = "Soramame is hopping around.";
        }

        private bool DeathCheck()
        {
            if(progressBarFood.Value == 0) { return true; }
            if(progressBarWater.Value == 0) { return true; }
            if(progressBarFun.Value == 0) { return true; }
            return false;
        }
        
        private void HasDied()
        {
            pictureBox1.Image = Properties.Resources.soramameBW;
            timerLife.Stop();
            timerLife.Dispose();
            if(timerButton != null)
            {
                timerButton.Stop();
                timerButton.Dispose();
            }
            buttonFeed.Enabled = false;
            buttonWater.Enabled = false;
            buttonPlay.Enabled = false;
            progressBarFood.Value = 0;
            progressBarWater.Value = 0;
            progressBarFun.Value = 0;
            labelMessage.Text = "Soramame has died.";
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if(progressBarFood.Value > 85)
            {
                progressBarFood.Value += 100 - progressBarFood.Value;
            } else { progressBarFood.Value += 15; }
            labelMessage.Text = "Soramame gobbles up the food.";
            ButtonTimer();
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            if (progressBarWater.Value > 85)
            {
                progressBarWater.Value += 100 - progressBarWater.Value;
            }
            else { progressBarWater.Value += 15; }
            labelMessage.Text = "Soramame guzzles the water.";
            ButtonTimer();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (progressBarFun.Value > 85)
            {
                progressBarFun.Value += 100 - progressBarFun.Value;
            }
            else { progressBarFun.Value += 15; }
            Random rnd = new Random();
            int pogCheck = rnd.Next(1, 5);
            if (pogCheck == 4)
            {
                labelMessage.Text = "Soramame is poggin' out!";
            }else labelMessage.Text = "Soramame is having fun.";
            ButtonTimer();
        }

        private void ButtonTimer()
        {
            buttonFeed.Enabled = false;
            buttonWater.Enabled = false;
            buttonPlay.Enabled = false;
            buttonCount = 0;
            timerButton = new System.Windows.Forms.Timer();
            timerButton.Interval = 750;
            timerButton.Tick += new EventHandler(TimerButton_Tick);
            timerButton.Start();
        }

        private void TimerButton_Tick(object sender, EventArgs e)
        {
            buttonCount++;
            if(buttonCount >= 6)
            {
                timerButton.Stop();
                buttonFeed.Enabled = true;
                buttonWater.Enabled = true;
                buttonPlay.Enabled = true;
                timerButton.Dispose();
            }
        }
    }
}