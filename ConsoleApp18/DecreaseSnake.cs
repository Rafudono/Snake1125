using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        public static void DecreaseSnake()
        {
            CleanTail();
            snake.Remove(snake.Last());
        }
           
    }
}
