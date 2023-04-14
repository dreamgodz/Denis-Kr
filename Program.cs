using dz.jen;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var json = new { Name= "Denis", Fam = "Krasnolobov" };
        json.ToJson();

        var gg = @"{
            'Name' : Katya ,
            'Fam' :Belyaeva ,
        }";
        gg.OffJson<dynamic>();
        Console.ReadKey();

    }
}
