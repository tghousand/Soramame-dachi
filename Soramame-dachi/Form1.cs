using Soramame_dachi.Properties;
using System.Diagnostics.Metrics;

namespace Soramame_dachi
{
    public partial class Form1 : Form
    {
        private int count;
        private int buttonCount;
        private bool isDead = false;
        private System.Windows.Forms.Timer timerLife = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerButton;
        public Form1()
        {
            InitializeComponent();
            loadSettings();
            Properties.Settings.Default.openDateTime = DateTime.Now;
            if(Properties.Settings.Default.firstOpen == false && DeathCheck() == false) { calculateTime(); }
            Properties.Settings.Default.firstOpen = false;
            timerLife.Interval = 1000;
            timerLife.Tick += new EventHandler(timerLife_Tick);
            timerLife.Start();
        }

        //important functions
        private void timerLife_Tick(object sender, EventArgs e)
        {
            count++;
            if (DeathCheck() == true) { HasDied(); }
            if (count % 9 == 1)
            {
                progressBarWater.Value -= 5;
            }
            if(count % 12 == 1)
            {
                progressBarFood.Value -= 5;
                MessageUpdate();
            }
            if(count % 15 == 1)
            {
                progressBarFun.Value -= 5;
            }
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
            isDead = true;
            pictureBox1.Image = Properties.Resources.soramameBW;
            if (timerLife.Enabled == true)
            {
                timerLife.Stop();
                timerLife.Dispose();
            }
            if(timerButton != null)
            {
                timerButton.Stop();
                timerButton.Dispose();
            }
            buttonFeed.Enabled = false;
            buttonWater.Enabled = false;
            buttonPlay.Enabled = false;
            buttonRestart.Visible = true;
            progressBarFood.Value = 0;
            progressBarWater.Value = 0;
            progressBarFun.Value = 0;
            Properties.Settings.Default.Reset();
            labelMessage.Text = "Soramame has died.";
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
        private void loadSettings()
        {
            Properties.Settings.Default.Reload();
            this.progressBarFood.Value = Properties.Settings.Default.food;
            this.progressBarFun.Value = Properties.Settings.Default.fun;
            this.progressBarWater.Value = Properties.Settings.Default.water;
            count = Properties.Settings.Default.count;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.food = this.progressBarFood.Value;
            Properties.Settings.Default.fun = this.progressBarFun.Value;
            Properties.Settings.Default.water = this.progressBarWater.Value;
            Properties.Settings.Default.count = count;
            Properties.Settings.Default.closeDateTime = DateTime.Now;
            Properties.Settings.Default.Save();
        }
        private void calculateTime()
        {
            int elapsedSeconds = (int) System.Math.Abs((Properties.Settings.Default.openDateTime - Properties.Settings.Default.closeDateTime).TotalSeconds);
            int foodSubtract = elapsedSeconds / 12;
            int waterSubtract = elapsedSeconds / 9;
            int funSubtract = elapsedSeconds / 15;
            while (foodSubtract > 0 && DeathCheck() == false)
            {
                progressBarFood.Value -= 5;
                foodSubtract--; 
            }
            while (waterSubtract > 0 && DeathCheck() == false)
            {
                progressBarWater.Value -= 5;
                waterSubtract--;
            }
            while (funSubtract > 0 && DeathCheck() == false)
            {
                progressBarFun.Value -= 5;
                funSubtract--;
            }
            if (DeathCheck() == true) { HasDied(); } else count += elapsedSeconds;
        }


        //buttons
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
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.soramame;
            timerLife = new System.Windows.Forms.Timer();
            timerLife.Interval = 750;
            timerLife.Tick += new EventHandler(timerLife_Tick);
            timerLife.Start();
            progressBarFood.Value = 100;
            progressBarFun.Value = 100;
            progressBarWater.Value = 100;
            count = 1;
            buttonFeed.Enabled = true;
            buttonPlay.Enabled = true;
            buttonWater.Enabled = true;
            labelMessage.Text = "Meet Soramame. Your new frog.";
            buttonRestart.Visible = false;
        }

    }
}