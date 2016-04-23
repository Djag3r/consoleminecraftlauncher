using System;
using static System.Console;

namespace consoleminecraftlauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            WriteLine("//==== Console Minecraft Launcher ====\\");
            WriteLine("");
            WriteLine("Вы можете запустить Minecraft, введя ----->");
            WriteLine("в строку ниже (1) или (minecraft)");
            WriteLine("Чтобы узнать информацию о программе, введите (2) или (info)");

            string multi;

            multi = ReadLine();

            if ((multi == "1") || (multi == "minecraft"))
            {
                WriteLine("Soon!");
                /*Process.Start();*/
            }

            else if ((multi == "2") || (multi == "info"))
            {
                WriteLine("Console Minecraft Launcher");
                WriteLine("ver. 0.0.1");
                WriteLine("GameFuN, 2011-2016");
            }

            else
            {
                WriteLine("Не удалось выполнить операцию! Проверьте =====>");
                WriteLine("верность введенных вами данных.");
            }

            WriteLine("Желаете продолжить работу с программой? (yes) или (no)");

            string choose = ReadLine();

            if(choose == "yes")
            {
                Clear();
                goto start;
            }

            else
            {
                Environment.Exit(0);
            }
        }
    }
}
