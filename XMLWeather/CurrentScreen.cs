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
            currentOutput.Text = Form1.days[0].currentTemp+"°";
            highOutput.Text = Form1.days[0].tempLow+ "°";
            lowOutput.Text = Form1.days[0].tempHigh + "°";
            countryLabel.Text = "," + Form1.days[0].country;
            weatherOuput.Text = Form1.days[0].weather;
            updateOutput.Text = "Last time updated" + " " +Form1.days[0].update;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        
    }
}
