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
            //City
            cityOutput.Text = Form1.days[0].location + "," + Form1.days[0].country;
            

            //Day 1
            dateOutput1.Text = Form1.days[1].date;
            minLabel1.Text = Form1.days[1].tempLow + "°";
            maxLabel1.Text = Form1.days[1].tempHigh + "°";

            //Day 2
            dateOutput2.Text = Form1.days[2].date;
            minLabel2.Text = Form1.days[2].tempLow + "°";
            maxLabel2.Text = Form1.days[2].tempHigh + "°";

            //Day 3
            dateOutput3.Text = Form1.days[3].date;
            minLabel3.Text = Form1.days[3].tempLow + "°";
            maxLabel3.Text = Form1.days[3].tempHigh + "°";

            //Day 4
            dateOutput4.Text = Form1.days[4].date;
            minLabel4.Text = Form1.days[4].tempLow + "°";
            maxLabel4.Text = Form1.days[4].tempHigh + "°";

            //Day 5
            dateOutput5.Text = Form1.days[5].date;
            minLabel5.Text = Form1.days[5].tempLow + "°";
            maxLabel5.Text = Form1.days[5].tempHigh + "°";

            //Day 6
            dateOutput6.Text = Form1.days[6].date;
            minLabel6.Text = Form1.days[6].tempLow + "°";
            maxLabel6.Text = Form1.days[6].tempHigh + "°";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        
    }
}
