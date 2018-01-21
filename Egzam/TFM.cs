using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzam
{
    class TFM : List<dItem>
    {
        static List<dItem> d = new List<dItem>();
        public static List<string> t = new List<string>()
        {
            "Wieśmac",
            "McRoyal",
            "McChicken",
            "Filet-O-Fish",
            "Chicker",
            "Cheesburger",
            "KurczakBurger",
            "Hamburger",
            "McWrap",
            "McZestaw",
            "HappyMeal",
            "ChickenBox Duży",
            "ChickenBox",
            "Chicken McNugets",
            "Chicken Strips",
            "Chicken Wings",
            "Frytki Małe",
            "Frytki Srednie",
            "Frytki Duze",
            "Kawa",
            "Herbata",
            "Woda",
            "Sok",
            "Shake",
            "Mały lód",
            "Mussli & Jogurt",
            "McTost",
            "McWrap śniadaniowy",
            "Placek",
            "Kajzerka",
            "McMuffin",
            "Godzina",
            "Wiek",
            "Płeć",
            "Miasto",
            "Województwo",
            "Name"
        };

        public void Wypelnij()
        {
            List<dItem> temp = new List<dItem>();
            temp.Add(new dItem(10, 10, true, "Koszalin", "ZP", "User" + (temp.Count  +1))
            { HappyMeal=true,Sok= true, MalyLod= true });
            temp.Add(new dItem(11, 20, false, "Koszalin", "ZP", "User" + (temp.Count  +1)){KurczakBurger= true, Cola= true });
            temp.Add(new dItem(13, 30, false, "Koszalin", "ZP", "User" + (temp.Count  +1)) { Chicker = true, Cola = true,Katchup=true, Frytki= true });
            temp.Add(new dItem(16, 30, true, "Koszalin", "ZP", "User" + (temp.Count  +1)){Hamburger= true, Cola= true, Frytki= true });
            temp.Add(new dItem(15, 40, true, "Koszalin", "ZP", "User" + (temp.Count  +1)){Frytki= true, Hamburger= true, Cola= true });

            temp.Add(new dItem(17, 10, true, "Białogard", "ZP", "User" + (temp.Count  +1)) { McZestaw = true, Sok = true });
            temp.Add(new dItem(14, 20, true, "Białogard", "ZP", "User" + (temp.Count  +1)){McChicken= true });
            temp.Add(new dItem(15, 20, false, "Białogard", "ZP", "User" + (temp.Count  +1)){FiletOFish= true });
            temp.Add(new dItem(12, 30, true, "Białogard", "ZP", "User" + (temp.Count  +1)){Chicker= true });
            temp.Add(new dItem(16, 40, true, "Białogard", "ZP", "User" + (temp.Count  +1)){Cheesburger= true });

            temp.Add(new dItem(13, 10, true, "Karlino", "ZP", "User" + (temp.Count  +1)) { McZestaw = true, Cola = true });
            temp.Add(new dItem(12, 20, false, "Karlino", "ZP", "User" + (temp.Count  +1)){KurczakBurger= true });
            temp.Add(new dItem(13, 20, true, "Karlino", "ZP", "User" + (temp.Count  +1)){ ChickenBox = true, Cola = true, Katchup = true, Frytki = true });
            temp.Add(new dItem(15, 30, true, "Karlino", "ZP", "User" + (temp.Count  +1)){McWrap=true, Sok=true});
            temp.Add(new dItem(18, 30, false, "Karlino", "ZP", "User" + (temp.Count  +1)){McWrapSniadaniowy=true,Sok=true});

            temp.Add(new dItem(17, 10, true, "Gorzów", "Lubuskie", "User" + (temp.Count  +1)) { Hamburger= true, Cola= true });
            temp.Add(new dItem(18, 20, true, "Gorzów", "Lubuskie", "User" + (temp.Count  +1)) { Kajzerka = true, Kawa = true });
            temp.Add(new dItem(19, 20, false, "Gorzów", "Lubuskie", "User" + (temp.Count  +1)){Kajzerka=true,Herbata=true});
            temp.Add(new dItem(20, 30, false, "Gorzów", "Lubuskie", "User" + (temp.Count  +1)){McZestaw=true});
            temp.Add(new dItem(21, 30, true, "Gorzów", "Lubuskie", "User" + (temp.Count  +1)){ McZestaw = true });

            temp.Add(new dItem(16, 20, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count  +1)){ McZestaw = true });
            temp.Add(new dItem(15, 30, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count  +1)){ChickenBox=true, Cola=true, Katchup = true,Frytki = true});
            temp.Add(new dItem(14, 40, false, "Zielona Góra", "Lubuskie", "User" + (temp.Count  +1)){ ChickenBoxDuży = true, Cola = true, Katchup = true,Frytki = true });
            temp.Add(new dItem(13, 40, false, "Zielona Góra", "Lubuskie", "User" + (temp.Count  +1)){ ChickenBox = true, Cola = true, Katchup = true,Frytki = true });
            temp.Add(new dItem(15, 50, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count  +1)){ ChickenBoxDuży = true, Cola = true, Katchup = true, Frytki = true });

            temp.Add(new dItem(16, 20, true, "Poznań", "Wielkopolskie", "User" + (temp.Count  +1)){ Katchup = true,Frytki = true,Cola=true,Hamburger=true});
            temp.Add(new dItem(17, 20, false, "Poznań", "Wielkopolskie", "User" + (temp.Count  +1)){ Katchup = true,Frytki = true, Cola = true, Hamburger = true });
            temp.Add(new dItem(18, 30, true, "Poznań", "Wielkopolskie", "User" + (temp.Count  +1)){ Katchup = true,Frytki = true, Cola = true, Hamburger = true });
            temp.Add(new dItem(19, 30, true, "Poznań", "Wielkopolskie", "User" + (temp.Count  +1)){ Katchup = true,Frytki = true, Cola = true, Cheesburger = true });
            temp.Add(new dItem(18, 50, false, "Poznań", "Wielkopolskie", "User" + (temp.Count  +1)){ Katchup = true, Frytki = true, Cola = true, Chicker = true });

            temp.Add(new dItem(16, 50, false, "Gdańsk", "Pomorskie", "User" + (temp.Count  +1)){Hamburger=true,Cola=true,Cheesburger=true});
            temp.Add(new dItem(15, 20, true, "Gdańsk", "Pomorskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Cheesburger = true , Katchup = true,Frytki = true});
            temp.Add(new dItem(14, 20, true, "Gdańsk", "Pomorskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Wiesmac = true });
            temp.Add(new dItem(18, 50, true, "Gdańsk", "Pomorskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Wiesmac = true });
            temp.Add(new dItem(19, 30, false, "Gdańsk", "Pomorskie", "User" + (temp.Count  +1)){Kawa=true,Kajzerka=true,McTost=true});

            temp.Add(new dItem(18, 50, true, "Warszawa", "Mazowieckie", "User" + (temp.Count  +1)){ Chicker = true, Cola = true, Wiesmac = true, Katchup = true,Frytki = true });
            temp.Add(new dItem(18, 50, false, "Warszawa", "Mazowieckie", "User" + (temp.Count  +1)){ Kawa = true, Kajzerka = true, McTost = true });
            temp.Add(new dItem(17, 10, false, "Warszawa", "Mazowieckie", "User" + (temp.Count  +1)) { Chicker= true, Frytki= true, Katchup= true, Cola= true });
            temp.Add(new dItem(19, 20, false, "Warszawa", "Mazowieckie", "User" + (temp.Count  +1)){ Kawa = true, Kajzerka = true, McTost = true });
            temp.Add(new dItem(16, 20, true, "Warszawa", "Mazowieckie", "User" + (temp.Count  +1)){ KurczakBurger = true, Cola = true, Chicker= true, Katchup = true, Frytki = true });

            temp.Add(new dItem(16, 20, true, "Lublin", "Lubelskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Cheesburger = true,Majonez=true, Frytki = true });
            temp.Add(new dItem(17, 20, false, "Lublin", "Lubelskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Cheesburger = true, Majonez = true, Frytki = true });
            temp.Add(new dItem(17, 20, false, "Lublin", "Lubelskie", "User" + (temp.Count  +1)){ Hamburger = true, Cola = true, Cheesburger = true, Majonez = true, Frytki = true });
            temp.Add(new dItem(18, 30, true, "Lublin", "Lubelskie", "User" + (temp.Count  +1)){ Kawa = true, Kajzerka = true, McTost = true });
            temp.Add(new dItem(19, 30, false, "Lublin", "Lubelskie", "User" + (temp.Count  +1)){ Kawa = true, Kajzerka = true, McTost = true });

            temp.Add(new dItem(17, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count  +1)){ FiletOFish = true, Cola = true, Majonez = true, Frytki = true });
            temp.Add(new dItem(16, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count  +1)){ McWrap = true, Kawa= true, Majonez = true, Frytki = true });
            temp.Add(new dItem(16, 30, true, "Kielce", "Świętokrzyskie", "User" + (temp.Count  +1)){ McMuffin= true, Herbata= true, Majonez = true, Frytki = true });
            temp.Add(new dItem(15, 30, true, "Kielce", "Świętokrzyskie", "User" + (temp.Count  +1)){ FiletOFish = true, Cola = true, Majonez = true, Frytki = true });
            temp.Add(new dItem(18, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count  +1)){ FiletOFish = true, Cola = true, Majonez = true, Frytki = true });
            this.AddRange(temp);
        }
    }
    class dItem
    {
        public dItem(int godzina, int wiek, bool mezczyzna, string miasto, string wojewodztwo, string name)
        {
            Godzina = godzina;
            Wiek = wiek;
            Plec = mezczyzna;
            Miasto = miasto;
            Wojewodztwo = wojewodztwo;
            Name = name;
        }

        private bool cola = false;//0
        private bool katchup = false;//1
        private bool majonez = false;//2
        private bool wiesmac = false;//3
        private bool mcRoyal = false;//4
        private bool mcChicken = false;//5
        private bool filetOFish = false;//6
        private bool chicker = false;//7
        private bool cheesburger = false;//8
        private bool kurczakBurger = false;//9
        private bool hamburger = false;//10
        private bool mcWrap = false;//11
        private bool mcZestaw = false;//12
        private bool happyMeal = false;//13---
        private bool chickenBoxDuży = false;//14
        private bool chickenBox = false;//15
        private bool chickenMcNugets = false;//16
        private bool chickenStrips = false;//17
        private bool chickenWings = false;//18
        private bool frytki = false;//19
        private bool kawa = false;//20
        private bool herbata = false;//21
        private bool woda = false;//22
        private bool sok = false;//23
        private bool shake = false;//24
        private bool malyLod = false;//25--
        private bool mussliAndJogurt = false;//26
        private bool mcTost = false;//27
        private bool mcWrapSniadaniowy = false;//28
        private bool placek = false;//29
        private bool kajzerka = false;//30
        private bool mcMuffin = false;//31
        private int godzina;
        private int wiek;
        private bool plec;
        private string miasto;
        private string wojewodztwo;
        private string name;

        public bool Cola { get => cola; set => cola = value; }
        public bool Katchup { get => katchup; set => katchup = value; }
        public bool Majonez { get => majonez; set => majonez = value; }
        public bool Wiesmac { get => wiesmac; set => wiesmac = value; }
        public bool McRoyal { get => mcRoyal; set => mcRoyal = value; }
        public bool McChicken { get => mcChicken; set => mcChicken = value; }
        public bool FiletOFish { get => filetOFish; set => filetOFish = value; }
        public bool Chicker { get => chicker; set => chicker = value; }
        public bool Cheesburger { get => cheesburger; set => cheesburger = value; }
        public bool KurczakBurger { get => kurczakBurger; set => kurczakBurger = value; }
        public bool Hamburger { get => hamburger; set => hamburger = value; }
        public bool McWrap { get => mcWrap; set => mcWrap = value; }
        public bool McZestaw { get => mcZestaw; set => mcZestaw = value; }
        public bool HappyMeal { get => happyMeal; set => happyMeal = value; }
        public bool ChickenBoxDuży { get => chickenBoxDuży; set => chickenBoxDuży = value; }
        public bool ChickenBox { get => chickenBox; set => chickenBox = value; }
        public bool ChickenMcNugets { get => chickenMcNugets; set => chickenMcNugets = value; }
        public bool ChickenStrips { get => chickenStrips; set => chickenStrips = value; }
        public bool ChickenWings { get => chickenWings; set => chickenWings = value; }
        public bool Frytki { get => frytki; set => frytki = value; }
        public bool Kawa { get => kawa; set => kawa = value; }
        public bool Herbata { get => herbata; set => herbata = value; }
        public bool Woda { get => woda; set => woda = value; }
        public bool Sok { get => sok; set => sok = value; }
        public bool Shake { get => shake; set => shake = value; }
        public bool MalyLod { get => malyLod; set => malyLod = value; }
        public bool MussliAndJogurt { get => mussliAndJogurt; set => mussliAndJogurt = value; }
        public bool McTost { get => mcTost; set => mcTost = value; }
        public bool McWrapSniadaniowy { get => mcWrapSniadaniowy; set => mcWrapSniadaniowy = value; }
        public bool Placek { get => placek; set => placek = value; }
        public bool Kajzerka { get => kajzerka; set => kajzerka = value; }
        public bool McMuffin { get => mcMuffin; set => mcMuffin = value; }
        public int Godzina { get => godzina; set => godzina = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public bool Plec { get => plec; set => plec = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string Wojewodztwo { get => wojewodztwo; set => wojewodztwo = value; }
        public string Name { get => name; set => name = value; }
    }


}
