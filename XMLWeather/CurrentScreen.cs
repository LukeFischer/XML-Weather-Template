﻿using System;
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
        public static int ct;
        
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location + "," + Form1.days[0].country;
            currentOutput.Text = Form1.days[0].currentTemp + "°";
            lowOutput.Text = Form1.days[0].tempLow + "°";
            highOutput.Text = Form1.days[0].tempHigh + "°";
            weatherOuput.Text = Form1.days[0].weather;
            updateOutput.Text = "Last time updated" + " " + Form1.days[0].update;
            humidityOutput.Text = "Humidity" + " " + Form1.days[0].humidity + Form1.days[0].unit;
            label1.Text = Convert.ToString(ct);

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
        
        
