using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        public static bool SnakeEatPoisonedApple()
        {
            return Poisonedapple[0] == snake[0][0] && Poisonedapple[1] == snake[0][1];
        }
    }
}
