using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTimer
{
    public partial class Form1 : Form
    {
        int i;
        DateTime stopTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            lblCounter.Text = i.ToString();
            if (DateTime.Now > this.stopTime)
            {
                timer1.Enabled = false;
                stopTime = DateTime.Now;
            }
            else
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
                {

                    player.Play();
                }

            }

        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            lblCounter.Text = "0";
            DateTime startDate = DateTime.Now;

            this.stopTime = startDate.AddMinutes(double.Parse(txbTimeLength.Text));
            var interval = int.Parse(txbTimerInterval.Text) * 60000;

            timer1.Interval = interval;

            timer1.Enabled = true;


        }
    }
}
