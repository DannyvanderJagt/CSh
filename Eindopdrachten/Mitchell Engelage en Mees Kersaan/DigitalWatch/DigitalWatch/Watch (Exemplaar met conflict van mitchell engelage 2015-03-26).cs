using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Globalization;
using System.Net;
using DigitalWatch.Properties;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DigitalWatch
{
    public partial class Watch : Form
    {
        Display display;
        IStrategy strategy;
        Time hour;
        Time minute;
        
         

        bool twelveHourNotation = false;

        int modus = 0;
        int counter = DateTime.Now.Second;

        int[] time;
        
        public Watch()
        {
            InitializeComponent();

            segmentDisplay1.BackColor = Color.Transparent;
            segmentDisplay2.BackColor = Color.Transparent;
            segmentDisplay3.BackColor = Color.Transparent;
            segmentDisplay4.BackColor = Color.Transparent;
            
            display = new Display();
            hour = new Time(DateTime.Now.Hour, 23);
            minute = new Time(DateTime.Now.Minute, 59);

            setStrategy("getTime");
            time = strategy.doAction(null);
            hour.setTime(time[0]);
            minute.setTime(time[1]);
            updateTime();
        }

        private void setStrategy(string strategyName)
        {
            switch (strategyName)
            {
                case "getTime":
                    strategy = new GetTime();
                    break;
                case "twelveHourNotation":
                    strategy = new GetTwelveHourNotation();
                    break;
            }
        }

        private void updateTime()
        {
            if (twelveHourNotation)
            {
                setStrategy("twelveHourNotation");
                time = strategy.doAction(new int[] { hour.getTime(), minute.getTime() });
                lblAMPM.Text = time[0] == hour.getTime() ? "AM" : "PM";
                display.updateTime(time[0], time[1]);
            }
            else
            {
                display.updateTime(hour.getTime(), minute.getTime());
            }

            updateDisplay();
        }

        private void updateDisplay()
        {
            for (int j = 0; j < 7; j++)
            {
                segmentDisplay1.Controls[j].Visible = display.segmentDisplays[0].segments[j].getState();
                segmentDisplay2.Controls[j].Visible = display.segmentDisplays[1].segments[j].getState();
                segmentDisplay3.Controls[j].Visible = display.segmentDisplays[2].segments[j].getState();
                segmentDisplay4.Controls[j].Visible = display.segmentDisplays[3].segments[j].getState();
            }
        }

        private void secondtimer_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter == 60)
            {
                if (minute.getTime() == 59)
                {
                    hour.incrementTime();
                }

                minute.incrementTime();
                counter = 0;

                updateTime();
            }

            lblColon.Visible = !lblColon.Visible;
        }

        private void incrementtimer_Tick(object sender, EventArgs e)
        {
            switch (modus)
            {
                case 0: // watch modus
                    //
                    break;
                case 1: // increment minute modus
                    segmentDisplay3.Visible = !segmentDisplay3.Visible;
                    segmentDisplay4.Visible = !segmentDisplay4.Visible;
                    break;
                case 2: // increment hour modus
                    segmentDisplay1.Visible = !segmentDisplay1.Visible;
                    segmentDisplay2.Visible = !segmentDisplay2.Visible;
                    break;
                case 3: // switch 12/24 notation modus
                    segmentDisplay1.Visible = !segmentDisplay1.Visible;
                    segmentDisplay2.Visible = !segmentDisplay2.Visible;
                    segmentDisplay3.Visible = !segmentDisplay3.Visible;
                    segmentDisplay4.Visible = !segmentDisplay4.Visible;
                    if (twelveHourNotation)
                    lblAMPM.Visible = !lblAMPM.Visible;
                    break;
            }
        }

        private void btnModus_Click(object sender, EventArgs e)
        {
            modus++;
            modus = modus % 4;

            segmentDisplay1.Visible = true;
            segmentDisplay2.Visible = true;
            segmentDisplay3.Visible = true;
            segmentDisplay4.Visible = true;
            lblAMPM.Visible = twelveHourNotation;

            switch (modus)
            {
                case 0: // watch modus
                    incrementtimer.Stop();
                    secondtimer.Start();
                    break;
                case 1: // increment minute modus
                    lblColon.Visible = true;
                    incrementtimer.Start();
                    secondtimer.Stop();
                    break;
                case 2: // increment hour modus
                    incrementtimer.Start();
                    break;
                case 3: // switch 12/24 notation modus
                    incrementtimer.Start();
                    break;
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            switch (modus)
            {
                case 0: // watch modus
                    //
                    break;
                case 1: // increment minute modus
                    minute.incrementTime();
                    segmentDisplay3.Visible = true;
                    segmentDisplay4.Visible = true;
                    incrementtimer.Stop();
                    updateTime();
                    break;
                case 2: // increment hour modus
                    hour.incrementTime();
                    incrementtimer.Stop();
                    segmentDisplay1.Visible = true;
                    segmentDisplay2.Visible = true;
                    updateTime();
                    break;
                case 3: // switch 12/24 notation modus
                    twelveHourNotation = !twelveHourNotation;
                    incrementtimer.Stop();
                    segmentDisplay1.Visible = true;
                    segmentDisplay2.Visible = true;
                    segmentDisplay3.Visible = true;
                    segmentDisplay4.Visible = true;
                    lblAMPM.Visible = twelveHourNotation;
                    updateTime();
                    break;
            }
        }

        private void btnIncrement_MouseUp(object sender, MouseEventArgs e)
        {
            incrementtimer.Start();
        }
    }
}
