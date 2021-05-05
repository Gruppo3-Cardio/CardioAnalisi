using System;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static double Max(double x)
        {
            double risultato = 220 - x;
            double max = (risultato / 100) * 90;
            return max;
        }

        public static double Min(double x)
        {
            double risultato = 220 - x;
            double min = (risultato / 100) * 70;
            return min;
        }

        public static string Battiti(int x)
        {
            string risposta="";

            if (x < 60)
            {
                risposta = "bradicardico";

            }
            else if(x>=60 && x<= 100)
            {
                risposta = "battito regolare";
            }
            else
            {
                risposta = "tachicardico";
            }
            return risposta;
        }

        public static double Calorie(int età, double tempo, string sesso, int frequenza, double peso)
        {
            double calorie = 0;
            if (sesso == "maschio")
            {
                calorie = (((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.09699) * tempo / 4.184);
                calorie = Math.Round(calorie, 3);
            }
            else if(sesso=="femmina")
            {
                calorie=(((età * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022)* tempo / 4.184);
                calorie = Math.Round(calorie, 3);
            }
            else
            {
                calorie = 0;
            }

            return calorie;
        }

        public static double Corsa_Camminata(double km, double peso, string velocità)
        {
            double spesa_energetica = 0;
            if (velocità == "camminata")
            {
                spesa_energetica = 0.50 * km * peso;
                spesa_energetica = Math.Round(spesa_energetica, 1);
            }
            else
            {
                spesa_energetica = 0.9 * km * peso;
                spesa_energetica = Math.Round(spesa_energetica, 1);
            }

            return spesa_energetica;
        }
    }
}
