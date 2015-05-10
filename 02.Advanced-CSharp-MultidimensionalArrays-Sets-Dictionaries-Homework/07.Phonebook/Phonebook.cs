using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string number = "";
            string name = "";
            string search = "";
            var phonebook = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split('-');

            do
            {
                name = input[0];
                number = input[1];
                if (phonebook.ContainsKey(name))
                {
                    if (!CheckNumbers(number, phonebook[name]))
                    {
                        phonebook[name].Add(number);
                    }
                }
                else
                {
                    phonebook.Add(name, new List<string>());
                    phonebook[name].Add(number);
                }
                input = Console.ReadLine().Split('-');

            } while (input[0] != "search");

            search = Console.ReadLine();

            do
            {
                if (phonebook.ContainsKey(search))
                {
                    Console.WriteLine(search + " -> " + string.Join("; ", phonebook[search]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", search);
                }

                search = Console.ReadLine();

            } while (search != String.Empty);

        }

        static bool CheckNumbers(string s, List<string> l)
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
