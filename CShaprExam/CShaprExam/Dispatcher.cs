using System;
using System.Collections.Generic;
using System.Text;

namespace TarasenkoCShaprExam
{
    class Dispatcher
    {
        public string Name { get; set; }
        public int Penalty { get; set; }
        protected int WeatherAdj; // погодные условия
        protected static Random RandForWeather;

        public Dispatcher(string Name)
        {
            this.Name = Name;
            RandForWeather = new Random();
            WeatherAdj = RandForWeather.Next(-200, 201);
            Penalty = 0;
        }

        public void RecomHeight(int _speed, int _height)
        {
            int RecomIndicators = _speed * 7 - WeatherAdj;

            int IndicatorsDifference; // для разницы между текущей и рекомендованой

            if (_height > RecomIndicators)
                IndicatorsDifference = _height - RecomIndicators;
            else
                IndicatorsDifference = RecomIndicators - _height;

            Console.WriteLine($"Dispatcher {Name} reports: Recomended height is: {RecomIndicators} meters!");

            if(_speed > 1000)
            {
                Penalty += 100;
                Console.WriteLine($"Dispatcher {Name} reports: DROP THE SPEED IMMEDIATELY!!!");
            }

            if (IndicatorsDifference >= 300 && IndicatorsDifference < 600)
                Penalty += 25;
            else if (IndicatorsDifference >= 600 && IndicatorsDifference < 1000)
                Penalty += 50;
            else if (IndicatorsDifference >= 1000 || (_speed <= 0 && _height <= 0))
                throw new CrushExept("Simulation is over - PLANE HAS BEEN CRUSHED!"); // Генерация "самолет разбился"

            if (Penalty >= 1000)
                throw new PenaltyExept("Simulation is over - To many Penalty Points! YOU ARE UNSUITABLE!!!"); // генерация "непригоден"
        }
    }
}
