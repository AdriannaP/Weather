using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    static class FileWriter
    {
        static public void WriteToFile(string filePath, WeatherObject weatherObject)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                string singleLine = DateTime.Now.ToString() + " Temp: " + Math.Round(weatherObject.Main.Temp - 273) + " °C"
                    + " Sky Condition: " + weatherObject.Weather[0].Description
                    + " Pressure: " + weatherObject.Main.Pressure + " hPa";
                file.WriteLine(singleLine);
            }
        }
    }
}
