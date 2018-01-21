using System;
using System.Collections.Generic;

namespace Cwiczenia.Methods
{
    class Minikowski: List<List<double>>
    {
        public Minikowski Licz(TFM tfm,double p, double r)
        {
            this.Clear();
            for (int k = 0; k < tfm.Count; k++)
            {
                Add(new List<double>());
                for (int i = 0; i < tfm.Count; i++)
                {
                    var value = 0.0;
                    for (int j = 0; j < tfm[i].Count; j++)
                        value += Math.Pow(Math.Abs(tfm[k][j] - tfm[i][j]), p);
                    this[k].Add(Math.Pow(value, 1.0 / r));
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,6:#.##} |")
        {
            Console.WriteLine("Minikowski");
            for (int i = 0; i < this[0].Count; i++)
            {
                for (int j = 0; j < Count; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }
    }
}
