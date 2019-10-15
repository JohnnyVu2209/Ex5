using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PickBallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] game = new int[] { 0, 3, 5, 6 };

            PrintGame(game);
            while (true)
            {
                HumanMove(game);
                PrintGame(game);
                if (Has0Ball(game))
                {
                    Console.WriteLine("You Lose!!!");
                    break;
                }
                Console.WriteLine("Computer turn:  ");
                ComputerMove(game);
                PrintGame(game);
                if (Has0Ball(game))
                {
                    Console.WriteLine("You Win!!!");
                    break;
                }
            }


        }
        static void HumanMove(int[] game)
        {
            Console.WriteLine("Which group do you choose: ");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("How many balls will you pick : ");
            int n = int.Parse(Console.ReadLine());
            PickBall(game, g, n);
        }
        static void ComputerMove(int[] game)
        {
            if (Has1Group(game))
            {
                int g = 0;
                Get1Group(game, out g);
                if (game[g] > 1)
                    PickBall(game, g, game[g] - 1);
                else
                    PickBall(game, g, 1);

            }
            else if (Has2Group(game))
            {
                Random rand = new Random();
                int a, b = 0;
                Get2Group(game, out a, out b);
                if (game[a] == 1)
                    PickBall(game, b, game[b]);
                else if (game[b] == 1)
                    PickBall(game, a, game[a]);
                else if (game[a] > game[b])
                    PickBall(game, a, game[a] - game[b]);
                else if (game[b] > game[a])
                    PickBall(game, b, game[b] - game[a]);
                else
                {
                    if (a == 3 && b == 3)
                    { PickBall(game, a, game[rand.Next(1, 2)]); }
                    else
                        PickBall(game, a, 1);
                }




            }
            else
            {
                Random rand = new Random();
                int g = rand.Next(1, 3);
                int balls = rand.Next(1, game[g]);

                int gr = 0;
                FindMax(game, out gr);

                if (game[1] > 1 && game[2] == 1 && game[3] == 1)
                    PickBall(game, 1, game[1] - 1);
                else if (game[1] == 1 && game[2] > 1 && game[3] == 1)
                    PickBall(game, 2, game[2] - 1);
                else if (game[1] == 1 && game[2] == 1 && game[3] > 1)
                    PickBall(game, 3, game[3] - 1);
                else if (game[1] > 1 && game[2] > 1 && game[3] == 1)
                {
                    if (game[1] > game[2])
                        PickBall(game, 1, game[1] - 2);
                    else if (game[1] < game[2])
                        PickBall(game, 2, game[2] - 2);
                    else
                        PickBall(game, 3, game[3]);
                }
                else if (game[1] > 1 && game[2] == 1 && game[3] > 1)
                {
                    if (game[1] > game[3])
                        PickBall(game, 1, game[1] - 2);
                    else if (game[1] < game[3])
                        PickBall(game, 3, game[3] - 2);
                    else
                        PickBall(game, 2, game[2]);
                }
                else if (game[1] == 1 && game[2] > 1 && game[3] > 1)
                {
                    if (game[2] > game[3])
                        PickBall(game, 2, game[2] - 2);
                    else if (game[2] < game[3])
                        PickBall(game, 3, game[3] - 2);
                    else
                        PickBall(game, 1, game[1]);
                }
                else
                //PickBall(game, g, balls);
                {
                    if (game[1] == game[2])
                        PickBall(game, 3, game[3]);
                    else if (game[1] == game[3])
                        PickBall(game, 2, game[2]);
                    else if (game[3] == game[2])
                        PickBall(game, 1, game[1]);
                    else if (game[1] != game[2] && game[1] != game[3] && game[3] != game[2])
                    {
                        PickBall(game, gr, game[gr] - 1);
                    }

                }
            }

        }
        static void PrintGame(int[] group)
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < group[1]; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Group 2: ");
            for (int i = 0; i < group[2]; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Group 3: ");
            for (int i = 0; i < group[3]; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
        }
        static void PickBall(int[] group, int g, int n)
        {
            group[g] -= n;
        }
        static bool Has0Ball(int[] group)
        {
            return (group[1] == 0 && group[2] == 0 && group[3] == 0);
        }
        static bool Has1Group(int[] group)
        {
            if (group[1] > 0 && group[2] == 0 && group[3] == 0)
                return true;
            if (group[1] == 0 && group[2] > 0 && group[3] == 0)
                return true;
            if (group[1] == 0 && group[2] == 0 && group[3] > 0)
                return true;
            return false;
        }
        static bool Has2Group(int[] group)
        {
            if (group[1] > 0 && group[2] > 0 && group[3] == 0)
                return true;
            if (group[1] > 0 && group[2] == 0 && group[3] > 0)
                return true;
            if (group[1] == 0 && group[2] > 0 && group[3] > 0)
                return true;
            return false;
        }
        static bool Has3Group(int[] group)
        {

            return (group[1] > 0 && group[2] > 0 && group[3] > 0);
        }
        static void Get1Group(int[] group, out int g)
        {
            g = 0;
            if (group[1] > 0 && group[2] == 0 && group[3] == 0)
                g = 1;
            if (group[1] == 0 && group[2] > 0 && group[3] == 0)
                g = 2;
            if (group[1] == 0 && group[2] == 0 && group[3] > 0)
                g = 3;

        }
        static void Get2Group(int[] group, out int a, out int b)
        {
            a = b = 0;
            if (group[1] > 0 && group[2] > 0 && group[3] == 0)
            { a = 1; b = 2; }
            if (group[1] > 0 && group[2] == 0 && group[3] > 0)
            { a = 1; b = 3; }
            if (group[1] == 0 && group[2] > 0 && group[3] > 0)
            { a = 2; b = 3; }

        }
        static void FindMax(int[] game, out int g)
        {
            g = 0;
            int max = game[g];

            for (int i = 1; i < game.Length; i++)
            {
                if (max < game[i])
                {
                    g = i;

                }
            }



        }
    }

}

