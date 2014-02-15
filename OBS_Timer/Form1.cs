using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;

namespace OBS_Timer
{
    public partial class OBS_Timer : Form
    {
        private DateTime _countdownTime;
        private DateTime _currentTime;
        private DateTime _nulltime;
        private TimeSpan _zeroTime = new TimeSpan(0);

        private String _textFilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\obs_timer_text.txt";

        public OBS_Timer()
        {
            InitializeComponent();
            writeMessageFile("");
            addButtonEvents();
            setOutputText();
            initCountdownOffsetScroller();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            timerClock.Interval = 1000;
            _currentTime = DateTime.Now.TruncateSeconds();
            updateClock();
            updateButtons();
            updateCountdown();
        }

        private void addButtonEvents()
        {
            iterateButtons((button) =>
            {
                button.Click += new EventHandler(setCountdownText);
            }
            );
        }

        private void setCountdownText(object button_object, EventArgs args)
        {
            _countdownTime = futureTime((Button)button_object);
            this.btnStop.Enabled = true;
        }


        private void updateClock()
        {
            this.clockLabel.Text = _currentTime.ToString("HH:mm:ss");
        }

        private void updateCountdown()
        {
            string countdownText = "00:00:00";
            if (_countdownTime != _nulltime)
            {
                TimeSpan countDown = _countdownTime - _currentTime;

                if (countDown > _zeroTime)
                {
                    int countdownOffsetSeconds = readCountdownOffsetSeconds();
                    countDown = countDown.Add(new TimeSpan(0, 0, countdownOffsetSeconds)); 
                    countdownText = countDown.ToString(@"hh\:mm\:ss");
                    writeMessageFile(countdownText);
                }
                else
                {
                    stopCountdown();
                }
            }

            this.countLabel.Text = countdownText;

        }

        private void stopCountdown()
        {
            _countdownTime = _nulltime;
            writeMessageFile("");
            this.btnStop.Enabled = false;
        }

        private void updateButtons() 
        {
            iterateButtons((button) =>
            {
                button.Text = futureTime(button).ToString("HH:mm");
            }
            );
         }


        private void writeMessageFile(string timeText)
        {
            string timerMessage = "";
            if (timeText != "")
            { 
                timerMessage = this.txtTimerMessage.Text + " " + timeText;
            }

            //try
            //{
                File.WriteAllText(_textFilePath, timerMessage);
            //}
            //catch
            //{
            //    timerClock.Enabled = false;
            //    _countdownTime = _nulltime;
            //}

        }


        private DateTime futureTime(Button button)
        {
            double minutes      = Convert.ToDouble(button.Tag);
            DateTime time       = _currentTime.AddMinutes(minutes);

            double futureMins   = time.Minute % 15;
            DateTime future     = time.AddMinutes(futureMins * -1).TruncateMinutes();

            return future;
        }


        private void setOutputText()
        {
            this.txtTimerMessage.Text = Properties.Settings.Default.TimerMessage;
        }

        private void saveTimerMessage(string text)
        {
            Properties.Settings.Default["TimerMessage"] = text;
            Properties.Settings.Default.Save();
        }

        private void txtOutputText_TextChanged(object sender, EventArgs e)
        {
            saveTimerMessage(txtTimerMessage.Text);
        }

        private void iterateButtons(Action<Button> lambda)
        {
            foreach (Control control in this.grpButtons.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    lambda((Button)control);
                }
            }
            return;
        }

        private void OBS_Timer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerClock.Enabled = false;
            writeMessageFile("");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCountdown();
        }

        private void initCountdownOffsetScroller()
        {
            this.scrollCountOffset.Value = readCountdownOffsetSeconds() / 15;
            setCountdownOffsetSecondsText();
        }

        private void scrollCountdownOffset_Scroll(object sender, ScrollEventArgs e)
        {
            int seconds = e.NewValue * 15;
            updateCountdownOffsetSeconds(seconds);
    
        }

        private void updateCountdownOffsetSeconds(int seconds)
        {
            saveCountdownOffsetSeconds(seconds);
            setCountdownOffsetSecondsText();
        }

        private int readCountdownOffsetSeconds()
        {
            return (int)Properties.Settings.Default.CountdownOffsetSeconds;
        }

        private void saveCountdownOffsetSeconds(int seconds)
        {
            Properties.Settings.Default["CountdownOffsetSeconds"] = seconds;
            Properties.Settings.Default.Save();
        }

        private void setCountdownOffsetSecondsText()
        {
            this.lblCountOffset.Text = readCountdownOffsetSeconds().ToString();
        }

    }
}
