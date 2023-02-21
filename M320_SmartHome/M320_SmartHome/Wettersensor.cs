﻿namespace M320_SmartHome {
    public class Wettersensor {
        private Random random;
        private double currentTemp;
        private const int MAX_TEMP = 35;
        private const int MIN_TEMP = -25;
        public Wettersensor() {
            this.random = new Random(Guid.NewGuid().GetHashCode());
            this.currentTemp = random.Next(MIN_TEMP, MAX_TEMP);
        }
        public Wetterdaten getFakeDaten(double temp, double windgschw, bool rain)
        {
            return new Wetterdaten { Aussentemperatur = temp, Windgeschwindigkeit = windgschw, Regen = rain };
        }
        public Wetterdaten GetWetterdaten() {
            var rand = this.random.NextDouble();

            var regen = rand > 0.5;

            var deltaTemp = rand * (regen ? -1 : 1);
            var newTemp = this.currentTemp + deltaTemp;
            if(newTemp < MIN_TEMP || newTemp > MAX_TEMP) {
                deltaTemp *= -1;
            }
            this.currentTemp += deltaTemp;
            this.currentTemp = Math.Round(this.currentTemp, 1);
            var wind = Math.Round(35d * rand, 1);
           

            return new Wetterdaten { Aussentemperatur = this.currentTemp, Windgeschwindigkeit = wind, Regen = regen };
        }
    }



}