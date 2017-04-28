using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            condi1.Text = Form1.days[1].condition;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            condi2.Text = Form1.days[2].condition;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            condi3.Text = Form1.days[3].condition;

            //date 1 image 
            if (Form1.days[1].condition.Contains("clouds"))
            {
                fBox1.BackgroundImage = Properties.Resources.overcast;
            }
            else if (Form1.days[1].condition.Contains("rain"))
            {
                fBox1.BackgroundImage = Properties.Resources.purerain;
            }

            else if (Form1.days[1].condition.Contains("clear"))
            {
               fBox1.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Form1.days[1].condition.Contains("thunderstorm"))
            {
                fBox1.BackgroundImage = Properties.Resources.thunder;
            }
            
            else
            {
                fBox1.BackgroundImage = Properties.Resources.overcast;
            }

            //date 2 image
            if (Form1.days[2].condition.Contains("clouds"))
            {
                fBox2.BackgroundImage = Properties.Resources.overcast;
            }
            else if (Form1.days[2].condition.Contains("rain"))
            {
                fBox2.BackgroundImage = Properties.Resources.purerain;
            }

            else if (Form1.days[2].condition.Contains("clear"))
            {
                fBox2.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Form1.days[2].condition.Contains("thunderstorm"))
            {
                fBox2.BackgroundImage = Properties.Resources.thunder;
            }
           
            else
            {
                fBox2.BackgroundImage = Properties.Resources.overcast;
            }
            //date 3 image
            if (Form1.days[3].condition.Contains("clouds"))
            {
                fBox3.BackgroundImage = Properties.Resources.overcast;
            }
            else if (Form1.days[3].condition.Contains("rain"))
            {
                fBox3.BackgroundImage = Properties.Resources.purerain;
            }

            else if (Form1.days[3].condition.Contains("clear"))
            {
                fBox3.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Form1.days[3].condition.Contains("thunderstorm"))
            {
                fBox3.BackgroundImage = Properties.Resources.thunder;
            }
            
            else
            {
                fBox3.BackgroundImage = Properties.Resources.overcast;
            }



        }

        private void todayL_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        //private void todayL_Click(object sender, EventArgs e)

    }
}
