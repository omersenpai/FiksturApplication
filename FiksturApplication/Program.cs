
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
        static bool Fikstur(string team)
        {
            return team == "fenerbahçe" || team == "fenerbahce" ;
        }

        Console.Write("Lütfen takım ismi giriniz: ");
        var team = Console.ReadLine().ToLower();

        if (Fikstur(team))
        {
            Console.WriteLine($"\n{team.ToUpper()} FİKSTÜRÜ:");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|        RAKİP        |        KONUM        |");
            Console.WriteLine("----------------------------------------------------------------------------------");

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].ToLower() != team.ToLower())
                {
                    var konum = i % 2 == 0 ? "Ev" : "Deplasman"; //çift sayıysa ev ,tek sayıysa deplasman 
                    Console.WriteLine($"| {teams[i],-19} | {konum,-19} |"); 
                }
            }
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
