
using FiksturApplication;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var teams = new List<string>
        {
            "Fenerbahçe", "Galatasaray", "Beşiktaş", "Trabzonspor",
            "Sivasspor", "Alanyaspor", "Gaziantep FK", "Kasımpaşa",
            "Konyaspor", "Antalyaspor", "Malatyaspor","Samsunspor",
            "Kayserispor", "Hatayspor", "Karagümrük", "Başakşehir",
            "Pendikspor","Adana DemirSspor", "Ç.Rizespor ","Ankaragücü"


        };

        //takımın fenerbahce olup olmadığı kontrolü
        static bool IsFenerbahce(string team)
        {
            return team == "fenerbahçe" || team == "fenerbahce"|| team=="FENERBAHÇE" || team=="FENERBAHCE";

        }


        //Fenerbahce Fikstür gösteren metod.Fixture class ını kullanıyoruz.
        static void ShowFixtures(string team)
        {
            var fixtures = new List<Fixture>
        {
            new Fixture { Rakip = "Gaziantep FK",Konum = "Ev" },
            new Fixture { Rakip = "Samsunspor", Konum = "Deplasman" },
            new Fixture { Rakip = "Başakşehir", Konum = "Ev" },
            new Fixture { Rakip = "Ankaragücü", Konum = "Deplasman" },
            new Fixture { Rakip = "Antalya", Konum = "Ev" },
            new Fixture { Rakip = "Alanya", Konum = "Deplasman" },
            new Fixture { Rakip = "Ç. Rizespor", Konum = "Ev" },
            new Fixture { Rakip = "Kasımpaşa", Konum = "Deplasman" },
            new Fixture { Rakip = "Hatayspor", Konum = "Ev" },
            new Fixture { Rakip = "Pendikspor",Konum="Deplasman"},
            new Fixture { Rakip = "Trabzonspor",Konum="Ev"},
            new Fixture { Rakip = "Adana DemirSpor",Konum="Deplasman"},
            new Fixture { Rakip = "Karagümrük",Konum="Ev"},
            new Fixture { Rakip = "SivasSpor",Konum="Ev"},
            new Fixture { Rakip = "Beşiktaş",Konum="Deplasman"},
            new Fixture { Rakip = "Konyaspor",Konum="Ev"},
            new Fixture { Rakip = "Kayserispor",Konum="Deplasman"},
            new Fixture { Rakip = "Galatasaray",Konum="Ev"},
            new Fixture { Rakip = "İstanbulspor",Konum="Deplasman"},
            new Fixture { Rakip = "Gaziantep FK",Konum="Deplasman"},
            new Fixture { Rakip = "Samsunspor",Konum="Ev"},
            new Fixture { Rakip ="Başakşehir",Konum="Deplasman"},
        };

            Console.WriteLine($"\n{team.ToUpper()} FİKSTÜRÜ:");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|        RAKİP        |        KONUM        |");
            Console.WriteLine("----------------------------------------------------------------------------------");

            foreach (var fixture in fixtures)
            {
                Console.WriteLine($"| {fixture.Rakip,-19} | {fixture.Konum,-19} |");


            }
        }


        Console.Write("Lütfen takım ismi giriniz: ");
        var team = Console.ReadLine().ToLower();

        if (IsFenerbahce(team))
        {
            ShowFixtures("Fenerbahçe");
        }

        else if (!teams.Contains(team))
        {
            Console.WriteLine("Bu takım için bir fikstür mevcut değil.");
        }
        else
        {
            Console.WriteLine("Geçersiz takım adı.");
        }



    }
}