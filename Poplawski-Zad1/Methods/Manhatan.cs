using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poplawski_Zad1.Methods
{
    class Manhatan: List<List<int>>
    {
        //lista jest po YX zamiast XY - dla np d0 jest manhatan[0][i]
        public Manhatan Licz(TFM tfm)
        {
            for (int k = 0; k < tfm.Count; k++)
            {
                Add(new List<int>());
                for (int i = 0; i < tfm.Count; i++)
                {
                    var value = 0;
                    for (int j = 0; j < tfm[i].Count; j++)
                    {
                        value += Math.Abs(tfm[k][j] - tfm[i][j]);
                    }
                    this[k].Add(value);
                }
            }
            return this;
        }
        public void Wyswietl(string Format = "{0,4:#} | ")
        {
            Console.WriteLine("Manhatan");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                    Console.Write((String.Format(Format, this[j][i])));
                Console.WriteLine();
            }
        }
    }
}
