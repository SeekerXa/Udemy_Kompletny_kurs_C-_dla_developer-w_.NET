using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = @"E:\Projects\Learning\C#\Udemy_Kompletny_kurs_C-_dla_developer-w_.NET\JSONSerialization\JSonSave\";

            var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealthPoint = 100,
                Statistics = new List<Statistic>
                    {
                        new Statistic()
                        {
                            Name = "Strength",
                            Points = 10

                        },
                        new Statistic()
                        {
                            Name = "Intelligence",
                            Points = 10

                        }
                    }
            };


            player.Level++;

            //save
            string serializedPlayer = JsonConvert.SerializeObject(player);
            File.WriteAllText($"{directory}MarioJSON.json", serializedPlayer);

            //load
            //string serializedPlayer = File.ReadAllText(directory + "MarioJSON.json");
            //Player player = JsonConvert.DeserializeObject<Player>(serializedPlayer);

        }

    }
}



