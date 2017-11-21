using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poplawski_Zad1.Methods
{
    class Cosinus : List<List<double>>
    {
        double[,] MatrixCos;
        public Cosinus Licz(TFM tfm)
        {
            for (int i = 0; i < tfm.Count; i++)
            {
                Add(new List<double>());
                for (int j = 0; j < tfm.Count; j++)
                {
                    double temp1 = 0.0;
                    double temp2 = 0.0;
                    double temp3 = 0.0;
                    for (int k = 0; k < tfm[i].Count; k++)
                    {
                        temp1 += tfm[i][k] * tfm[j][k];
                        temp2 += Math.Pow(tfm[i][k], 2.0);
                        temp3 += Math.Pow(tfm[j][k], 2.0);
                    }
                    if (temp1 == 0)
                        this[i].Add(0);
                    else
                        this[i].Add(temp1 / ((Math.Sqrt(temp2) * Math.Sqrt(temp3))));
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,4:0.00} | ")
        {
            Console.WriteLine("Odleglosc Cosinusowa");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }
        //przypisanie pierwszej kolumny do result

        //    result.Add(new List<double>());
        //        for (int i = 0; i< 15; i++)
        //        {
        //            result[result.Count - 1].Add(MatrixCos[i, 0]);
        //}
    }
}
