using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poplawski_Zad1.Methods
{
    class Maximum: List<List<int>>
    {
        public Maximum Licz(TFM tfm)
        {
            for (int k = 0; k < tfm.Count; k++)
            {
                Add(new List<int>());
                for (int i = 0; i < tfm.Count; i++)
                {
                    var value = new List<int>();
                    for (int j = 0; j < tfm[i].Count; j++)
                        value.Add(Math.Abs(tfm[k][j] - tfm[i][j]));
                    this[k].Add(value.Max<int>());
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,4:#} | ")
        {
            Console.WriteLine("Maximum");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }
    }
}
