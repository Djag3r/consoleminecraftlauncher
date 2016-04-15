using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("");
            Console.WriteLine("//==== Console Minecraft Launcher ====\\");
            Console.WriteLine("");
            Console.WriteLine("Вы можете запустить Minecraft, введя ----->");
            Console.WriteLine("в строку ниже (1) или (minecraft)");
            Console.WriteLine("Чтобы узнать информацию о программе, введите (2) или (info)");

            string multi;

            multi = Console.ReadLine();

            if ((multi == "1") || (multi == "minecraft"))
            {
                Console.WriteLine("Soon!");
                /*Process.Start();*/
            }

            else if ((multi == "2") || (multi == "info"))
            {
                Console.WriteLine("Console Minecraft Launcher");
                Console.WriteLine("ver. 0.0.1");
                Console.WriteLine("GameFuN, 2011-2015");
            }

            else
            {
                Console.WriteLine("Не удалось выполнить операцию! Проверьте =====>");
                Console.WriteLine("верность введенных вами данных.");
            }

            Console.WriteLine("Желаете продолжить работу с программой? (yes) или (no)");

            string choose = Console.ReadLine();

            if(choose == "yes")
            {
                Console.Clear();
                goto start;
            }

            else
            {
                Environment.Exit(0);
            }
        }
    }
}
