﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        string temp;
        public static int temperature;
        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");

        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode parent;
            parent = doc.DocumentElement;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "city")
                {
                    d.location = child.Attributes["name"].Value;


                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "country")
                            d.country = grandChild.InnerText;
                    }
                }
                

                if (child.Name == "temperature")
                {
                    
                    d.tempHigh = child.Attributes["max"].Value;
                    d.tempLow = child.Attributes["min"].Value;
                    d.currentTemp = child.Attributes["value"].Value;
                    temp = (d.currentTemp);
                    temperature = Convert.ToInt16(temp);
                    CurrentScreen.ct = temperature;
                }
                if (child.Name == "humidity")
                {
                    d.humidity = child.Attributes["value"].Value;
                    d.unit = child.Attributes["unit"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                            d.wind = grandChild.Attributes["name"].Value;
                    }
                }
            
                    if (child.Name == "weather")
                {
                    d.weather = child.Attributes["value"].Value;
                }
                if (child.Name == "lastupdate")
                {
                    d.update = child.Attributes["value"].Value;
                }


            }
            days.Add(d);
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            XmlNode parent;
            parent = doc.DocumentElement;

            d = new Day();
            
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            d.date = grandChild.Attributes["day"].Value;

                            if (greatGrandChild.Name == "temperature")
                            {
                                d.tempHigh = greatGrandChild.Attributes["max"].Value;
                                d.tempLow = greatGrandChild.Attributes["min"].Value;
                            }
                            if (greatGrandChild.Name == "clouds")
                            {
                                d.condition = greatGrandChild.Attributes["value"].Value;
                                days.Add(d);
                                d = new Day();
                            }
                        }
                    }
                }
            }
            days.RemoveAt(1);
        }
    }
}
    

