using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Poplawski_Zad1.Methods
{
    class TFM : List<List<int>>
    {
        static List<dItem> d = new List<dItem>();
        static List<string> t = new List<string>()
        {
            "frytki","hamburger","hot-dog","fast food","szkodliwosc","otylosc","zawaly","kalorie","pizza"
        };
        public TFM()
        {
            d = dItem.FillMe();
        }
        public TFM Licz(string StringFormat = "{0,2:#} | ")
        {
            for (int i = 0; i < d.Count; i++)
            {
                d[i].textFromFile = Helper.ReadFile(d[i].FileName).ToLowerInvariant();
                d[i].textFromFile = d[i].textFromFile.Replace("ą", "a").Replace("ę", "e").Replace("ś", "s").Replace("ć", "c").Replace("ł", "l").Replace("ń", "n").Replace("ó", "o").Replace("ź", "z").Replace("ż", "z");
                Add(new List<int>());
                for (int j = 0; j < t.Count; j++)
                    this[i].Add(Regex.Matches(d[i].textFromFile, t[j]).Count);
            }
            return this;
        }
        public void Wyswietl(string StringFormat = "{0,2:#} | ")
        {
            Console.WriteLine("TFM");
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < this[i].Count; j++)
                    Console.Write(String.Format(StringFormat, this[i][j]));
                Console.WriteLine();
            }
        }
    }
    class dItem
    {
        public dItem(string name)
        {
            FileName = name;
        }
        public string FileName { get; set; }
        public string textFromFile { get; set; }
        public static List<dItem> FillMe()
        {
            return
                new List<dItem>()
                {
                    new dItem("d0-Wszechobecny fast food.txt"),
                    new dItem("d1-dlaczego hot-dogi sa niezdrowe.txt"),
                    new dItem("d2-Jak zjeść zdrowo w restauracji fast food.txt"),
                    new dItem("d3-Fast food czy żywność bio.txt"),
                    new dItem("d4-Czipsy i frytki bardziej szkodliwe, niż myśleliśmy.txt"),

                    new dItem("d5-14-letni hamburger z McDonalda wygląda prawie jak nowy.txt"),
                    new dItem("d6- Fast Food.txt"),
                    new dItem("d7-Fast food - czemu tak naprawdę jest szkodliwy.txt"),
                    new dItem("d8-Otyłość – kiedy własne ciało zabija.txt"),
                    new dItem("d9-Otyłość.txt"),

                    new dItem("d10-Zawały serca rano najbardziej śmiertelne.txt"),
                    new dItem("d11-Zawał serca.txt"),
                    new dItem("d12-Kalorie.txt"),
                    new dItem("d13-Ile kalorii ma jedzenie typu fast food.txt"),
                    new dItem("d14-Fast food bez wyrzutów sumienia. To możliwe.txt"),
                };
        }
    }
}
