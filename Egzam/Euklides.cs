using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Egzam
{
    class Euklides : List<double>
    {
        //wiersz jest rowny kolumnie z excella
        List<List<string>> convert = new List<List<string>>();

        private List<Tuple<double, int>> proposition = new List<Tuple<double, int>>();

        public Euklides Licz(TFM tfm)
        {
            Console.Clear();
            proposition.Clear();
            convert.Clear();
            this.Clear();
            PropertyInfo[] properties = typeof(dItem).GetProperties();
            for (int i = 0; i < tfm.Count(); i++)
            {
                convert.Add(new List<string>());
                //Console.WriteLine();
                for (var index = 0; index < properties.Length; index++)
                {
                    PropertyInfo property = properties[index];
                    var temp = property.GetValue(tfm[i]).ToString();
                    convert[i].Add((temp.Equals("True") ? "1" : (temp.Equals("False") ? "0" : temp)));
                }
            }


            Console.WriteLine();
            for (int i = 0; i < tfm.Count; i++)
            {
                double value = 0.0;
                for (int j = 0; j < convert[i].Count; j++)
                {
                    var a = convert[i][j];
                    var b = convert[convert.Count - 1][j];
                    bool c = a.Equals(b);
                    double temp = c ? 0.0 : 2.0;

                    if (!b.Equals("0"))
                        value += Math.Pow(Math.Abs(temp), 2.0);
                }
                value = Math.Pow(value, 1.0 / 2.0);
                this.Add(value);
                proposition.Add(new Tuple<double, int>(value, i));

            }

            proposition = proposition.OrderBy(x => x.Item1).ToList();
            var minValue = proposition[1].Item1;
            var offsetValue = (proposition.Last().Item1 - minValue) / 3;
            for (int i = proposition.Count - 1; i >= 0; i--)
            {
                if (proposition[i].Item1 < minValue + offsetValue)
                {
                    Console.Write("Malo - ");
                }
                else if (proposition[i].Item1 < minValue + offsetValue * 2)
                {
                    Console.Write("Sred - ");
                }
                else
                {
                    Console.Write("Duzo - ");
                }
                Console.Write(String.Format("{0,4:00.00} - ", proposition[i].Item1));
                wyswietlPropozycje(convert.Count - 1, proposition[i].Item2, tfm);
            }
            return this;
        }

        private void wyswietlPropozycje(int CustomerId, int BestEquals, TFM tfm)
        {
            PropertyInfo[] properties = typeof(dItem).GetProperties();
            Console.WriteLine(properties.Last().GetValue(tfm[BestEquals]));
            string str = "";
            for (var index = 0; index < properties.Length - 6; index++)
            {
                PropertyInfo property = properties[index];
                if (!property.GetValue(tfm[CustomerId]).ToString()
                        .Equals(property.GetValue(tfm[BestEquals]).ToString()) &&
                    property.GetValue(tfm[CustomerId]).ToString().Equals("False"))
                {
                    str += ("         " + index + ". " + properties[index].Name + Environment.NewLine);
                }
            }
            if (!str.Equals(""))
            {
                //Console.WriteLine("     Moze ");
                Console.WriteLine(str);
                //Console.WriteLine("     do tego?");
                Console.WriteLine();
            }
        }

    }
}