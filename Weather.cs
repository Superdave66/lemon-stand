using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Weather
    {
        public string condition;
        public int temperature = 75;
        public string forcastedCondition = "Sunny and warm";
        private List<string> weatherConditions;




        public void WeatherConditions()
        {
            weatherConditions = new List <Weather>("Sunny, Rainy" );
           
            foreach (string condition in weatherConditions)
            {
                Console.WriteLine(condition);
            }

            
        }

























               






























































        public string predictedForcast;
    }
}
