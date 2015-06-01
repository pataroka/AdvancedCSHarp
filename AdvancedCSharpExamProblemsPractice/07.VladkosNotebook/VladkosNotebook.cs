using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.VladkosNotebook
{
    class Player
    {
        public string Age;
        public string Name;
        public List<string> Opponents;
        public int Wins;
        public int Losses;
        public decimal Rank;

        public Player()
        {
            Age = String.Empty;
            Name = String.Empty;
            Opponents = new List<string>();
            Wins = 0;
            Losses = 0;
            Rank = 0;
        }

        public void CalcRank()
        {
            Rank = (decimal)(Wins + 1) / (Losses + 1);
        }
    }

    class VladkosNotebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Player> notebook = new SortedDictionary<string, Player>();
            string line = Console.ReadLine().Trim();

            while (line != "END")
            {
                string[] input = line.Split('|');
                if (!notebook.ContainsKey(input[0]))
                {
                    notebook.Add(input[0], new Player());
                    AddValues(input, notebook);
                }
                else
                {
                    AddValues(input, notebook);
                }
                line = Console.ReadLine().Trim();
            }

            int emptyEntries = 0;

            foreach (var pair in notebook)
            {
                if (pair.Value.Name != String.Empty && pair.Value.Age != String.Empty)
                {
                    pair.Value.CalcRank();
                    Console.WriteLine("Color: {0}", pair.Key);
                    Console.WriteLine("-age: {0}", pair.Value.Age);
                    Console.WriteLine("-name: {0}", pair.Value.Name);
                    if (pair.Value.Opponents.Count > 0)
                    {
                        pair.Value.Opponents.Sort(StringComparer.Ordinal);
                        Console.WriteLine("-opponents: {0}", string.Join(", ", pair.Value.Opponents));
                    }
                    else
                    {
                        Console.WriteLine("-opponents: (empty)");
                    }
                    
                    Console.WriteLine("-rank: {0:F2}", pair.Value.Rank);
                }
                else
                {
                    emptyEntries++;
                }
            }
            if (emptyEntries == notebook.Count)
            {
                Console.WriteLine("No data recovered.");
            }
        }

        private static void AddValues(string[] input, SortedDictionary<string, Player> notebook)
        {
            switch (input[1])
            {
                case "win":
                    notebook[input[0]].Wins += 1;
                    notebook[input[0]].Opponents.Add(input[2]);
                    break;
                case "loss":
                    notebook[input[0]].Losses += 1;
                    notebook[input[0]].Opponents.Add(input[2]);
                    break;
                case "age":
                    notebook[input[0]].Age = input[2];
                    break;
                default:
                    notebook[input[0]].Name = input[2];
                    break;
            }
        }
    }
}
