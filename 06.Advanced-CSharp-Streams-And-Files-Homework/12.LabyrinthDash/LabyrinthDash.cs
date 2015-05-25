using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _12.LabyrinthDash
{
    class LabyrinthDash
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char [][] labyrinth  = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                labyrinth[i] = Console.ReadLine().ToCharArray();
            }

            string moves = Console.ReadLine().Trim();
            int x = 0;
            int y = 0;
            int lives = 3;
            int totalMoves = 0;

            foreach (char move in moves)
            {
                int previousX = x;
                int previousY = y;

                switch (move)
                {
                    case '^':
                        y --;
                        break;
                    case '<':
                        x --;
                        break;
                    case'>':
                        x ++;
                        break;
                    case 'v':
                        y ++;
                        break;
                }

                if ((x >= labyrinth[y].Length) || (x < 0) || (y >= rows) || (y < 0) || (labyrinth[y][x] == ' '))
                {
                    totalMoves++;
                    Console.WriteLine("Fell off a cliff! Game Over!");
                    break;
                }
                if ((labyrinth[y][x] == '_') || (labyrinth[y][x] == '|'))
                {
                    Console.WriteLine("Bumped a wall.");
                    x = previousX;
                    y = previousY;

                }
                else if ((labyrinth[y][x] == '@') || (labyrinth[y][x] == '#') || (labyrinth[y][x] == '*'))
                {
                    totalMoves++;
                    lives--;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                    if (lives <= 0)
                    {
                        Console.WriteLine("No lives left! Game Over!");
                        break;
                    }
                    
                }
                else if (labyrinth[y][x] == '$')
                {
                    totalMoves++;
                    lives++;
                    Console.WriteLine("Awesome! Lives left: {0}", lives);
                    labyrinth[y][x] = '.';
                }
                else
                {
                    totalMoves++;
                    Console.WriteLine("Made a move!");
                }
            }
            Console.WriteLine("Total moves made: {0}", totalMoves);
        }
    }
}
