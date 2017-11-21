using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using Poplawski_Zad1.Methods;

namespace Poplawski_Zad1
{
    class Program
    {

        static TFM tfm = new TFM();
        static Euklides euklides = new Euklides();
        static TFIDF tfidf = new TFIDF();
        static Cosinus cosinus = new Cosinus();
        static Manhatan manhatan = new Manhatan();
        static Maximum maximum = new Maximum();
        static Minikowski minikowski = new Minikowski();

        static void Main(string[] args)
        {
            tfm.Licz().Wyswietl();
            euklides.Licz(tfm).Wyswietl();
            tfidf.Licz(tfm).Wyswietl();
            cosinus.Licz(tfm).Wyswietl();
            manhatan.Licz(tfm).Wyswietl();
            maximum.Licz(tfm).Wyswietl();
            minikowski.Licz(tfm, 3, 5).Wyswietl();
            minikowski.Licz(tfm, 5, 3).Wyswietl();
            minikowski.Licz(tfm, 3, 3).Wyswietl();
            ShowResult();
            Console.ReadKey();
        }

        private static void ShowResult(string Format = "{0,6:#.##}| ")
        {
            List<List<double>> result = new List<List<double>>();
            result.Add(new List<double>());
            result[0].AddRange(euklides[0]);
            result.Add(new List<double>());
            result[1].AddRange(cosinus[0]);
            result.Add(new List<double>());
            result[2].AddRange(maximum[0].Select<int, double>(i => i).ToList());
            result.Add(new List<double>());
            result[3].AddRange(manhatan[0].Select<int, double>(i => i).ToList());
            result.Add(new List<double>());
            result[4].AddRange(minikowski.Licz(tfm, 3, 5)[0]);
            result.Add(new List<double>());
            result[5].AddRange(minikowski.Licz(tfm, 5, 3)[0]);
            result.Add(new List<double>());
            result[6].AddRange(minikowski.Licz(tfm, 3, 3)[0]);

            Console.WriteLine("wyniki");
            for (int i = 0; i < result[0].Count; i++)
            {
                for (int j = 0; j < result.Count; j++)
                    Console.Write(String.Format(Format, result[j][i]));
                Console.WriteLine();
            }
        }
    }
}
