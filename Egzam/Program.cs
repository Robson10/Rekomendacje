using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Egzam
{
    class Program
    {
        private static TFM tfm = new TFM();
        private static Euklides euk = new Euklides();
        static void Main(string[] args)
        {
            tfm.Wypelnij();
            bool work = true;

            int h = DateTime.Now.TimeOfDay.Hours;
            Console.WriteLine("Podaj Imie i Nazwisko");
            string name="Harry Router";//=Console.ReadLine();
            Console.WriteLine("Podaj Wiek");
            int wiek = 23;// Int32.Parse(Console.ReadLine());
            wiek =(int) (Math.Round(wiek / 10.0)*10);
            Console.WriteLine("Podaj Płeć (m/k)");
            string plec = "m";// Console.ReadLine();
            Console.WriteLine("Podaj Miasto");
            string miasto = "Karlino";//Console.ReadLine();
            Console.WriteLine("Podaj Województwo");
            string wojewodztwo = "ZP";// Console.ReadLine();

            tfm.Add(new dItem(h,wiek,plec.Equals("m"),miasto,wojewodztwo,name));
            while (work)
            {
                PropertyInfo[] properties = typeof(dItem).GetProperties();
                for (var index = 0; index < properties.Length - 6; index++)
                {
                    Console.WriteLine(index + ". " + properties[index].Name);
                }
                    var wariant =Console.ReadLine();
                
                switch (wariant)
                {
                    case "-1":
                        work = false;break;
                    default: tfm[tfm.Count - 1].GetType().GetProperty(properties[Int32.Parse(wariant)].Name).SetValue(tfm[tfm.Count - 1], true);break;
                }
                euk.Licz(tfm);
            }
            euk.Licz(tfm);
        }
    }
}
