using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerWinForms
{
    public partial class MainForm : Form
    {
        private int seconds;
        private int minutes;
        private int hours;
        private bool timerMode;
        private bool isPaused;
        public MainForm()
        {
            isPaused = false;
            timerMode = false;
            SetProcessDpiAwarenessContext(-1);
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDpiAwarenessContext(int value);

        private void OnStartPauseNextClick(object sender, EventArgs e)
        {
            if (timerMode)
            {
                if (isPaused)
                {
                    secondTimer.Start();
                    startBtn.Text = "Пауза";
                    startBtn.BackColor = Color.Yellow;
                }
                else
                {
                    secondTimer.Stop();
                    startBtn.Text = "Далее";
                    startBtn.BackColor = Color.Chartreuse;
                }
                isPaused = !isPaused;
            }
            else
            {
                if (secondUpDown.Value == 0 && minuteUpDown.Value == 0 && hourUpDown.Value == 0)
                {
                    MessageBox.Show("Укажите время, которые требуется отсчитать", "Ошикба");
                    return;
                }
                hours = (int)hourUpDown.Value;
                minutes = (int)minuteUpDown.Value;
                seconds = (int)secondUpDown.Value;
                timeLabel.Text = GetTimeStirng(seconds, minutes, hours);
                secondUpDown.Visible = minuteUpDown.Visible = hourUpDown.Visible
                    = hourLabel.Visible = minuteLabel.Visible = secondLabel.Visible = false;
                timeLabel.Visible = true;
                startBtn.Text = "Пауза";
                startBtn.BackColor = Color.Yellow;
                Text = "Таймер";
                timerMode = true;
                secondTimer.Start();
                cancelBtn.Enabled = true;
            }
        }

        private void OnSecondChange(object sender, EventArgs e)
        {
            if (secondUpDown.Value >= 60)
            {
                secondUpDown.Value = 0;
                minuteUpDown.Value += 1;
            }
        }

        private void OnMinuteChange(object sender, EventArgs e)
        {
            if (minuteUpDown.Value >= 60)
            {
                minuteUpDown.Value = 0;
                if (hourUpDown.Value != hourUpDown.Maximum)
                {
                    hourUpDown.Value += 1;
                }
            }
        }

        private string GetTimeStirng(int second, int minute, int hour)
        {
            if (minute < 10)
            {
                if (second < 10)
                {
                    return $"{hour}:0{minute}:0{second}";
                }
                return $"{hour}:0{minute}:{second}";
            }
            else if (second < 10)
            {
                return $"{hour}:{minute}:0{second}";
            }
            return $"{hour}:{minute}:{second}";
        }

        private void OnSecondPass(object sender, EventArgs e)
        {
            if (seconds == 0 && minutes == 0 && hours == 0)
            {
                secondTimer.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Таймер завершился!", "Уведомление");
                secondUpDown.Visible = minuteUpDown.Visible = hourUpDown.Visible
                    = hourLabel.Visible = minuteLabel.Visible = secondLabel.Visible = true;
                timeLabel.Visible = false;
                startBtn.Text = "Старт";
                startBtn.BackColor = Color.Chartreuse;
                Text = "Запуск таймера";
                timerMode = false;
                cancelBtn.Enabled = false;
            }
            seconds--;
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }
            if (minutes < 0)
            {
                hours--;
                minutes = 59;
            }
            timeLabel.Text = GetTimeStirng(seconds, minutes, hours);
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            secondTimer.Stop();
            if (MessageBox.Show("Вы действительно хотите остановить таймер?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secondUpDown.Visible = minuteUpDown.Visible = hourUpDown.Visible
                    = hourLabel.Visible = minuteLabel.Visible = secondLabel.Visible = true;
                timeLabel.Visible = false;
                startBtn.Text = "Старт";
                startBtn.BackColor = Color.Chartreuse;
                Text = "Запуск таймера";
                timerMode = false;
                cancelBtn.Enabled = false;
            }
            else
            {
                secondTimer.Start();
            }
        }
    }
}