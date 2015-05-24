using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("//===== Console Minecraft Launcher =====\\");
                Console.WriteLine("");
                Console.WriteLine("Вы можете запустить Minecraft, введя ----->");
                Console.WriteLine("в строку ниже (1) или (minecraft)");
                Console.WriteLine("Чтобы узнать информацию о программе, введите (2) или (info)");
                string multi;
                multi = Console.ReadLine();
                if (multi == "1")
                {
                    Console.WriteLine("Soon!");
                    /*Process.Start();*/
                }
                if (multi == "minecraft")
                {
                    Console.WriteLine("Soon!");
                    /*Process.Start();*/
                }
                if (multi == "2")
                {
                    Console.WriteLine("Console Minecraft Launcher");
                    Console.WriteLine("ver. 0.0.1");
                    Console.WriteLine("GameFuN, 2011-2015");
                }
                if (multi == "info")
                {
                    Console.WriteLine("Console Minecraft Launcher");
                    Console.WriteLine("ver. 0.0.1");
                    Console.WriteLine("GameFuN, 2011-2015");
                }
                /*else
                {
                    Console.WriteLine("Не удалось выполнить операцию! Проверьте =====>");
                    Console.WriteLine("верность введенных вами данных.");
                }*/

                Console.WriteLine("Желаете продолжить работу с программой? yes/no");
                string choose = Console.ReadLine();
                if (choose == "no")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
