using Microsoft.Win32;
using System.Media;
using System.Reflection;

namespace TripleTwenty.UI
{
    public partial class Dashboard : Form
    {
        readonly RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        readonly string applicationName = Assembly.GetEntryAssembly().GetName().Name;
        DateTime endTime;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            RunAtStartupCheck();
        }

        private void RunAtStartupCheck()
        {
            var rkValue = rkApp.GetValue(applicationName);
#if DEBUG
            if (rkValue is not null)
            {
                rkApp.DeleteValue(applicationName);
            }
#else
            if (rkValue is null)
            {
                rkApp.SetValue(applicationName, Application.ExecutablePath.ToString());
            }
#endif
        }

        private void StartNewTimer()
        {
            var startTime = DateTime.UtcNow;
            endTime = startTime.AddMinutes(20);
            timer1.Start();
        }

        private void BtnStartWorkingMode_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Working Mode Already Started, You Can Minimize The Window Now");
                return;
            }

            StartNewTimer();

            notifyIcon1.BalloonTipText = "Starting Working Mode In: 20 Minutes";
            notifyIcon1.ShowBalloonTip(3000);
            timer2.Start();
        }

        private void BtnStartMovieMode_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled && MessageBox.Show("Working Mode Already Started. If You Plan To Switch To Movie Mode, It Will Stop The Working Mode", "Are You Sure ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            };

            notifyIcon1.BalloonTipText = "Starting Movie Mode";
            notifyIcon1.ShowBalloonTip(3000);

            notifyIcon1.Text = "Movie Mode";
            timer1.Stop();
            Hide();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            else
            {
                Show();
            }
        }

        private void OpenAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;

            if (remainingTime <= TimeSpan.Zero)
            {
                timer1.Stop();

                var restForm = new Rest();
                if (restForm.ShowDialog(this) == DialogResult.Continue)
                {
                    StartNewTimer();
                }
                else
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }

                return;
            }

            LblRemainingTime.Text = remainingTime.ToString(@"hh\:mm\:ss");
            notifyIcon1.Text = string.Format("Working Mode, Remaining Time: {0}", remainingTime.ToString(@"hh\:mm\:ss"));
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Hide();
            timer2.Stop();
        }
    }
}
