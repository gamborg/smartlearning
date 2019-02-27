using System;

namespace opgave2_2
{
    static class Tempature
    {
        public static float CelciusToFahrenheit(float celcius) 
        {
            var f = celcius * 1.8F + 32;
            return f;
        }

        public static float FahrenheitToCelcius(float fahrenheit)
        {
            var c = (fahrenheit - 32) * .5556F;
            return c;
        }
    }
}