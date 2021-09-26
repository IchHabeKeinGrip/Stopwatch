using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;

        private void btStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isActive == true)
            {
                timeCs++;
                if(timeCs >= 100)
                {
                    timeSec++;
                    timeCs = 0;
                    if(timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }

            DrawTime();
        }

        private void DrawTime()
        {
            lbCs.Text = String.Format("{0:00}", timeCs);
            lbSec.Text = String.Format("{0:00}", timeSec);
            lbMin.Text = String.Format("{0:00}", timeMin);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            
            isActive = false;
        }

    }
}
