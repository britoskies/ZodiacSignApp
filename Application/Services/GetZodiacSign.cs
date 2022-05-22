using System;

namespace Application.Services
{
    public class GetZodiacSign
    {
        public string GetSign(int month, int day)
        {
            if (day == 0 || month == 0) return "Inexistente";

            switch (month)
            {
                case (int)Months.December:
                {
                    return day < 22 ? "Sagitario" : "Capricornio";
                }
                case (int)Months.November:
                {
                    return day < 22 ? "Escorpio" : "Sagitario";
                }

                case (int)Months.October: 
                {
                    return day < 23 ? "Libra" : "Escorpio";
                }

                case (int)Months.September:
                {
                    return day < 23 ? "Virgo" : "Libra";
                }

                case (int)Months.August:
                {
                    return day < 23 ? "Leo" : "Virgo";
                }

                case (int)Months.July:
                {
                    return day < 23 ? "Cancer" : "Leo";
                }

                case (int)Months.June:
                {
                    return day < 23 ? "Geminis" : "Cancer";
                }

                case (int)Months.May:
                {
                    return day < 21 ? "Tauro" : "Geminis";
                }

                case (int)Months.April:
                {
                    return day < 20 ? "Aries" : "Tauro";
                }

                case (int)Months.March:
                {
                    return day < 21 ? "Piscis" : "Aries";
                }

                case (int)Months.February:
                {
                    if (day > 29) return "Inexistente";
                    return day < 20 ? "Acuario" : "Piscis";
                }

                case (int)Months.January:
                {
                    return day < 21 ? "Capricornio" : "Acuario";
                }
            }

            return "";
        }
    }
}
