using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13.ActivityTracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            int lines = int.Parse(Console.ReadLine());
            var months = new Dictionary<int, Dictionary<string, double>>();
            

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int month = DateTime.Parse(input[0]).Month;
                string user = input[1];
                double distance = Double.Parse(input[2]);

                if (months.ContainsKey(month))
                {
                    if (months[month].ContainsKey(user))
                    {
                        months[month][user] += distance;
                    }
                    else
                    {
                        months[month].Add(user, distance);
                    }
                }
                else
                {
                    Dictionary<string,double> temp = new Dictionary<string, double>(){{user, distance}};
                    months.Add(month, temp);
                }
            }

            var sortedMonths = months.Keys.ToList();
            sortedMonths.Sort();
            foreach (var month in sortedMonths)
            {
                Console.Write(month + ": ");
                var sortedUsers = months[month].Keys.ToList();
                sortedUsers.Sort();
                for (int i = 0; i < sortedUsers.Count; i++)
                {
                    if (i == sortedUsers.Count - 1)
                    {
                        Console.WriteLine(sortedUsers[i] + "(" + months[month][sortedUsers[i]] + ")");
                    }
                    else
                    {
                        Console.Write(sortedUsers[i] + "(" + months[month][sortedUsers[i]] + "), ");
                    }
                }
            }
        }
    }
}
