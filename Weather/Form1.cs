using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000;
        }

        private void UpdateWeather(WeatherObject weatherObject)
        {
            label_cityNameValue.Text = weatherObject.Name;
            label_temperatureValue.Text = Math.Round(weatherObject.Main.TempMax - 273).ToString() + " °C";
            label_skyConditionValue.Text = weatherObject.Weather[0].Description;
            label_pressureValue.Text = weatherObject.Main.Pressure.ToString() + " hPa";
        }

        private void button_startSave_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_stopSave_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartSaveEventHandler();
        }

        private void StartSaveEventHandler()
        {
            WeatherObject weatherObject = CheckWeatherEventHandler();
            string fileName = weatherObject.Name + ".txt";
            FileWriter.WriteToFile(fileName, weatherObject);
        }

        private WeatherObject CheckWeatherEventHandler()
        {
            string json = APICaller.GetWeatherFromOpenWeather(textBox_inputCity.Text);
            WeatherObject weatherObject = JsonConvert.DeserializeObject<WeatherObject>(json);
            UpdateWeather(weatherObject);
            return weatherObject;
        }

        private void button_checkWeather_Click(object sender, EventArgs e)
        {
            string json = APICaller.GetWeatherFromOpenWeather(textBox_inputCity.Text);
            WeatherObject weatherObject = JsonConvert.DeserializeObject<WeatherObject>(json);
            UpdateWeather(weatherObject);
            
        }
    }
}
