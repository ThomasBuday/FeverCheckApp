namespace FeverCheckApp.Models
{
    public class TemperatureChecker
    {
        public static string CheckTemperature(double temperature, string unite)
        {

            if (unite == "F")           //Convert to Celsius
            {
                temperature = (temperature - 32) * 5 / 9;
            }

            if (temperature >= 38.0)    //In case of fever
            {
                return "You have a fever";
            }
            else if (temperature <= 35) //In case of Hypothermia
            {
                return "You have hypothermia";
            }
            else                        //In case of nothing...
            {
                return "You are ok";
            }
        }
    }
}
