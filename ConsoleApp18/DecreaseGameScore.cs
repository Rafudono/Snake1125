using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool DecreaseGameScore()
        {
            gameScore--;
            Console.Title = $"Current score {gameScore}";
            if (gameScore < 1) 
            { 
            Console.WriteLine("Вы умерли от отравления");
                gameRunning = false;
                graphics.Clear(Color.Black);
                return false;
            }
            return true;
        }
    }
}
