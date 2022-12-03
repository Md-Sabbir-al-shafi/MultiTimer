using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        int seconds_left;
        int minute_left;
        int TCentiSecond, TMinute, TSecond;
        bool isActive;

        public string BeginingSecond { get; set; }
        public string BeginningMinute { get; set; }

        public Timer()
        {
            InitializeComponent();
        }

        public string GetCurrentSecond()
        {
            return SecondText.Text;
        }
        private string GetCurrentMinute()
        {
            return MinuteText.Text;
        }

        private void TimerS_Tick(object sender, EventArgs e)
        {

            seconds_left = int.Parse(GetCurrentSecond());
            minute_left = int.Parse(GetCurrentMinute());

            if (seconds_left > 0)
            {
                seconds_left = seconds_left - 1;
                MinuteText.Text = minute_left + "";
                SecondText.Text = seconds_left + "";
                if (seconds_left == 0 && minute_left > 0)
                {
                    seconds_left = 59;
                    SecondText.Text = seconds_left + "";

                    minute_left = minute_left - 1;
                    MinuteText.Text = minute_left + "";

                    seconds_left = seconds_left - 1;

                }
            }
            else if(seconds_left == 0 && minute_left > 0)
            {
                seconds_left = 59;
                SecondText.Text = seconds_left + "";

                minute_left = minute_left - 1;
                MinuteText.Text = minute_left + "";

                seconds_left = seconds_left - 1;
            }
            else
            {
                TimerS.Stop();
                MinuteText.Text = "Time";
                SecondText.Text = "End";
            }
        }
       
        private void PlusButton_Click(object sender, EventArgs e)
        {

            seconds_left = seconds_left + 5;
            if (seconds_left > 60)
            {
                seconds_left =seconds_left- 60;
                minute_left = minute_left + 1;
            }
            SecondText.Text = seconds_left + "";
            MinuteText.Text = minute_left + "";
        }

        private void MinusButton_Click_1(object sender, EventArgs e)
        {
          
            seconds_left = seconds_left - 5;
            if (seconds_left <= 0)
            {
                seconds_left = 60+seconds_left;
                minute_left=minute_left - 1;
                if(minute_left<0)
                {
                    minute_left= 0;
                }
            }
            SecondText.Text = seconds_left + "";
            MinuteText.Text = minute_left + "";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            BeginingSecond = GetCurrentSecond();
            BeginningMinute = GetCurrentMinute();
            TimerS.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            TimerS.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            TimerS.Stop();
            SecondText.Text = BeginingSecond;
            MinuteText.Text = BeginningMinute;
        }


       /*********************************** STOP WATCH ********************************/

        private void Start2_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void Stop2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {

            TCentiSecond = 0;
            TMinute = 0;
            TSecond = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                TCentiSecond++;
                if (TCentiSecond >= 60)
                {
                    TSecond++;
                    TCentiSecond = 0;
                    if (TSecond >= 60)
                    {
                        TMinute++;
                        TSecond = 0;
                    }
                }
            }


            DrawTime();
        }

        private void DrawTime()
        {

            Minute.Text = String.Format("{0:00}", TMinute);
            Second.Text = String.Format("{0:00}", TSecond);
            CentiSecond.Text = String.Format("{0:00}", TCentiSecond);
        }

        private void Timer_Load(object sender, EventArgs e)
        {
           
            ResetTime();
            isActive = false;

        }

        private void MinuteText_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(MinuteText.Text, MinuteText.Font);
            MinuteText.Width = size.Width;
            MinuteText.Height = size.Height;
        }

        private void SecondText_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(SecondText.Text, SecondText.Font);
            SecondText.Width = size.Width;
            SecondText.Height = size.Height;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

    }

}
