using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleTwenty.UI
{
    public partial class Rest : Form
    {
        DateTime endTime;

        public Rest()
        {
            InitializeComponent();
        }

        private void Rest_Load(object sender, EventArgs e)
        {
            var startTime = DateTime.UtcNow;
            endTime = startTime.AddSeconds(20);
            timer1.Start();
            BtnContinue.Enabled = false;
            BtnContinue.BackColor = Color.Red;
            Focus();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime <= TimeSpan.Zero)
            {
                timer1.Stop();
                BtnContinue.Enabled = true;
                BtnContinue.BackColor = Color.Green;
                SystemSounds.Asterisk.Play();
            }

            LblRemainingTime.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
            Close();
        }
    }
}
