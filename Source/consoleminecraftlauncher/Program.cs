// ===== Syntax, 2018 =====\\

using System;
using System.IO;
using System.Diagnostics;
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
                Write("Введите ваш никнейм: ");
                string nick = ReadLine();

                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string mcPath = appData + "\\.minecraft";
                string javapath = "C:\\Program Files\\Java";
                string javapath64 = "C:\\Program Files (x86)\\Java";

                if (Environment.Is64BitOperatingSystem == true) javapath = javapath64;

                if (Directory.Exists(mcPath) && Directory.Exists(javapath))
                {
                    ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw", "-Xms1G -Xmx1G -cp \""
                   + appData + "\\.minecraft\\bin\\minecraft.jar;"
                   + appData + "\\.minecraft\\bin\\jinput.jar;"
                   + appData + "\\.minecraft\\bin\\lwjgl.jar;"
                   + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\""
                   + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft"
                   + " "
                   + nick);
                    Process.Start(mcStartInfo);
                    Environment.Exit(0);
                }
                else
                {
                    /*MessageBox.Show("Minecraft Launcher не обнаружил или не смог запустить Minecraft! Пожалуйста, установите игру или проверьте ее наличие. " +
                    "Также, если вы используете х64-битную систему, убедитесь, что у вас установлены как х64-bit, так и х32-bit версии Java. " +
                    "В скором времени программа сама будет предлагать скачать и установить игру в таких ситуациях.", "Не удалось запустить Minecraft!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Скачивание с FTP: сервера настроенной версии Minecraft 1.5.2 от GameFuN     */        
                }
            }

            else if ((multi == "2") || (multi == "info"))
            {
                WriteLine("Console Minecraft Launcher");
                WriteLine("ver. 0.0.2");
                WriteLine("Syntax, 2018");
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
