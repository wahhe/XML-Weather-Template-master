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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;

            humLabel.Text = Form1.days[0].humidity;

            wddabel.Text = Form1.days[0].windSpeed + " " + Form1.days[0].windDirection;
            wdirLabel.Text = Form1.days[0].windname;
            condiOutput.Text = Form1.days[0].condition;

            //change currentimage for different condition
           
            if (Form1.days[0].condition.Contains("rain"))
            {
                currentImage.BackgroundImage = Properties.Resources.purerain;
            }
            else if (Form1.days[0].condition.Contains("clouds"))
            {
                currentImage.BackgroundImage = Properties.Resources.overcast;
            }
            else if (Form1.days[0].condition.Contains("clear"))
            {
                currentImage.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Form1.days[0].condition.Contains("thunderstorm"))
            {
                currentImage.BackgroundImage = Properties.Resources.thunder;
            }
            else
            {
                currentImage.BackgroundImage = Properties.Resources.overcast;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        //private void CurrentScreen_Load(object sender, EventArgs e)
     

        // private void CurrentScreen_Load(object sender, EventArgs e)



        // private void label1_Click(object sender, EventArgs e)

    }
}
