using System;
using System.IO;

namespace Cwiczenia
{
    class Helper
    {
        public static string ReadFile(string name)
        {
            try
            {
                using (StreamReader sr = new StreamReader(name))
                    return sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                return "The file could not be read:";
            }
        }
        public static string doubleToString(double value)
        {
            if (value == 0)
                return " | " + " 0,00";
            else
                return " | " + String.Format("{0:00.00}", value);
        }
    }
}
