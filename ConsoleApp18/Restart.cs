using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void Restart()
        {
            if (gameRunning)
                threadSnake.Abort();
            else
            {
                gameRunning = true;
                RunConrol();
            }
            gameScore = 0;
            Console.Title = $"Current score {gameScore}";


            Console.Clear();
            InitSnake();
            GenerateApple();
            GeneratePoisonedApple();
            threadSnake = new Thread(RunSnake);
            threadSnake.Start();
        }
    }
}
