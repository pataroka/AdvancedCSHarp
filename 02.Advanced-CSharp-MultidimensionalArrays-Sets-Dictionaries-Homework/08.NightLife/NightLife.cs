using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            var nightClubs = new Dictionary<string, Dictionary<string, List<string>>>();
            string[] input = Console.ReadLine().Split(';');

            do
            {
                string city = input[0];
                string venue = input[1];
                string performer = input[2];
                if (nightClubs.ContainsKey(city))
                {
                    if (nightClubs[city].ContainsKey(venue))
                    {
                        if (!CheckPerformers(performer, nightClubs[city][venue]))
                        {
                            nightClubs[city][venue].Add(performer);
                            nightClubs[city][venue].Sort();
                        }
                    }
                    else
                    {
                        nightClubs[city].Add(venue, new List<string>());
                        nightClubs[city][venue].Add(performer);
                    }
                }
                else
                {
                    nightClubs.Add(city, new Dictionary<string, List<string>>());
                    nightClubs[city].Add(venue, new List<string>());
                    nightClubs[city][venue].Add(performer);
                }

                input = Console.ReadLine().Split(';');

            } while (input[0] != "END");

            foreach (string city in nightClubs.Keys)
            {
                Console.WriteLine(city);
                var venueList = nightClubs[city].Keys.ToList();
                venueList.Sort();
                foreach (string venue in venueList)
                {
                    Console.WriteLine("->{0}: {1}", venue, string.Join(", ", nightClubs[city][venue]));
                }
            }

        }

        static bool CheckPerformers(string s, List<string> l)
        {
            bool check = false;
            for (int i = 0; i < l.Count; i++)
            {
                if (s == l[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        
    }
}
