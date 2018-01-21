using System;
using System.Collections.Generic;

namespace Cwiczenia.Methods
{
    class Euklides : List<List<double>>
    {
        //wiersz jest rowny kolumnie z excella
        public Euklides Licz(TFM tfm)
        {
            this.Clear();
            for (int k = 0; k < tfm.Count; k++)
            {
                Add(new List<double>());
                for (int i = 0; i < tfm.Count; i++)
                {
                    var value = 0.0;
                    for (int j = 0; j < tfm[i].Count; j++)
                        value += Math.Pow(Math.Abs(tfm[k][j] - tfm[i][j]), 2.0);
                    this[k].Add(Math.Pow(value, 1.0 / 2.0));
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,6:#.##} |")
        {
            Console.WriteLine("Euklides");
            for (int i = 0; i < this[0].Count; i++)
            {
                for (int j = 0; j < Count; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }

    }
}