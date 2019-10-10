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
        }
        static void PrintGame()
        {
        }
        static void Get1Group(int[] game , out int g)
        {
            g = 0;
            if (game[1] > 0 && game[2] == 0 && game[3] == 0)
                g = 1;
            if (game[1] == 0 && game[2] > 0 && game[3] == 0)
                g = 2;
            if (game[1] == 0 && game[2] == 0 && game[3] > 0)
                g = 3;
        }
        static bool Has3Group(int[] game )
        {
            return 
        }

    }
}
