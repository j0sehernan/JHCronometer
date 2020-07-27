using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Resources;

namespace Cronometer
{
    public partial class JHCronometer : Form
    {
        RemainingTime cronometer = new RemainingTime();
        TimeSpan time;
        TimeSpan second = new TimeSpan(0, 0, 1);
        TimeSpan time_00 = new TimeSpan(0, 0, -1);
        TimeSpan time10_00 = new TimeSpan(0, 9, 59);
        bool alert10Minutes = false;
        SoundPlayer soundPlayer = new SoundPlayer(Cronometer.Properties.Resources.despertador);
        public JHCronometer()
        {
            InitializeComponent();
        }
        private void subtractSecond() => time -= second;
        private void changeRemainingTime()
        {
            cronometer.lblHours.Text = getTimeFormatted(time.Hours.ToString());
            cronometer.lblMinutes.Text = getTimeFormatted(time.Minutes.ToString());
            cronometer.lblSeconds.Text = getTimeFormatted(time.Seconds.ToString());
            subtractSecond();
            if (time <= time10_00 && !alert10Minutes)
            {
                notifyIcon.BalloonTipText = "Ya casi se acaba el tiempo.";
                notifyIcon.ShowBalloonTip(3000);
                cronometer.BackColor = Color.FromArgb(241, 229, 188);
                alert10Minutes = true;
            }
            else if (time.Equals(time_00))
            {
                timer.Enabled = false;
                soundPlayer.PlayLooping();
                notifyIcon.BalloonTipText = "Tiempo terminado.";
                notifyIcon.ShowBalloonTip(3000);
                cronometer.BackColor = Color.FromArgb(204, 0, 0);
                alert10Minutes = true;
                timerAlways.Enabled = true;
            }
        }
        private void bringToFrontIfIsNecessary()
        {
            if (!txtHours.Focused && !txtMinutes.Focused && !txtSeconds.Focused && !btnGo.Focused && !btnStop.Focused && !btnDown.Focused && !btnRight.Focused && !btnMinimize.Focused && !btnClose.Focused)
            {
                cronometer.BringToFront();
            }
        }
        private void changeFinishColor()
        {
            if (cronometer.BackColor.Equals(Color.FromArgb(204, 0, 0)))
            {
                cronometer.BackColor = Color.White;
            }
            else if (cronometer.BackColor.Equals(Color.White))
            {
                cronometer.BackColor = Color.FromArgb(204, 0, 0);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            changeRemainingTime();
            bringToFrontIfIsNecessary();
        }
        private void go()
        {
            timerAlways.Enabled = false;
            if (Int32.Parse(txtHours.Text) > 0 || Int32.Parse(txtMinutes.Text) > 0 || Int32.Parse(txtSeconds.Text) > 0)
            {
                timer.Enabled = true;
                cronometer.Show();
                time = new TimeSpan(Int32.Parse(txtHours.Text), Int32.Parse(txtMinutes.Text), Int32.Parse(txtSeconds.Text));
                changeRemainingTime();
            }
            else
            {
                notifyIcon.BalloonTipText = "Por favor ingrese tiempo.";
                notifyIcon.ShowBalloonTip(3000);
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            go();
        }
        private void txtHours_Enter(object sender, EventArgs e)
        {
            txtHours.Text = "";
        }
        private void txtMinutes_Enter(object sender, EventArgs e)
        {
            txtMinutes.Text = "";
        }
        private void txtSeconds_Enter(object sender, EventArgs e)
        {
            txtSeconds.Text = "";
        }
        private void txtHours_Leave(object sender, EventArgs e)
        {
            txtHours.Text = getTimeFormatted(txtHours.Text);
        }
        private void txtMinutes_Leave(object sender, EventArgs e)
        {
            txtMinutes.Text = getTimeFormatted(txtMinutes.Text);
        }
        private void txtSeconds_Leave(object sender, EventArgs e)
        {
            txtSeconds.Text = getTimeFormatted(txtSeconds.Text);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerAlways.Enabled = false;
            cronometer.BackColor = Color.White;
            soundPlayer.Stop();
            cronometer.Hide();
        }
        private string getTimeFormatted(string time)
        {
            string timeFormatted = time;
            if (time.Length == 0)
                timeFormatted = "00";
            else if (time.Length == 1)
                timeFormatted = String.Concat("0", time);
            return timeFormatted;
        }
        private void txtHours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMinutes.Focus();
            }
        }
        private void txtMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSeconds.Focus();
            }
        }
        private void txtSeconds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.Focus();
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;
            cronometer.Location = new Point(deskWidth - cronometer.Width + 8, deskHeight - cronometer.Height - 33);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;
            cronometer.Location = new Point(deskWidth - cronometer.Width - 280, deskHeight - cronometer.Height + 8);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.SteelBlue;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerAlways_Tick(object sender, EventArgs e)
        {
            bringToFrontIfIsNecessary();
            changeFinishColor();
        }
    }
}
