using System;
using System.Collections.Generic;

namespace Cwiczenia.Methods
{
    class TFIDF:List<List<double>>
    {
        //wiersz jest rowny kolumnie z excella
        public TFIDF Licz(TFM tfm)
        {           
            for (int i = 0; i < tfm[i].Count; i++)
            {
                Add(new List<double>());
                for (int j = 0; j < tfm.Count; j++)
                {
                    var N = tfm.Count;
                    double n = 0;
                    for (int k = 0; k < tfm.Count; k++)
                        n += (tfm[k][i] > 0) ? 1 : 0;
                    this[i].Add(tfm[j][i] * Math.Log(N / ((n == 0) ? 1 : n)));
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,5:#.##} | ")
        {
            Console.WriteLine("Tabela TF IDF");
            for (int i = 0; i < this[0].Count; i++)
            {
                for (int j = 0; j < Count; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }
    }
}
