using empty_folder_deleter.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace empty_folder_deleter
{
    public static class ProcessExtensions
    {
        private static string FindIndexedProcessName(int pid)
        {
            var processName = Process.GetProcessById(pid).ProcessName;
            var processesByName = Process.GetProcessesByName(processName);
            string processIndexdName = null;

            for (var index = 0; index < processesByName.Length; index++)
            {
                processIndexdName = index == 0 ? processName : processName + "#" + index;
                var processId = new PerformanceCounter("Process", "ID Process", processIndexdName);
                if ((int)processId.NextValue() == pid)
                {
                    return processIndexdName;
                }
            }

            return processIndexdName;
        }

        private static Process FindPidFromIndexedProcessName(string indexedProcessName)
        {
            var parentId = new PerformanceCounter("Process", "Creating Process ID", indexedProcessName);
            return Process.GetProcessById((int)parentId.NextValue());
        }

        public static Process Parent(this Process process)
        {
            return FindPidFromIndexedProcessName(FindIndexedProcessName(process.Id));
        }
    }

    public class Program
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public static string OutputFolderPath { get; set; }
        public static string MainGameFolder { get; set; }


        static List<string> ParseCommandline(string[] args)
        {
            string modeID;
            string outFormat;
            string gameFolder = "";
            string outFolder = "";

            if (args.Length >= 2)
            {

                if (int.Parse(args[0]) > -1 && int.Parse(args[0]) <= 3)
                {
                    modeID = args[0];
                }
                else
                {
                    return null;
                }


                if (args[1] == "l" || args[1] == "j" || args[1] == "b")
                {
                    outFormat = args[1];
                }
                else
                {
                    return null;
                }

                if (args.Length == 3)
                {
                    outFolder = args[2];
                }

                if (args.Length == 4)
                {
                    gameFolder = args[3];
                }
            }
            else
            {
                return null;
            }

            return new List<string>() { modeID, outFormat, outFolder, gameFolder };
        }
        private static string helpString = "***** USAGE *****\r\n1.\"Select\": Select a folder, or just enter on the textbox.\r\n" +
                    "2.\"Print\" : Show all the empty folders recursively, but no delete anything.\r\n" +
                    "3.\"Clear\" : Clean the screen.\r\n" +
                    "4.\"STOP\"  : Stop the search process.\r\n" +
                    "5.\"Clean\" : Recursively delete empty subfolders under target folder.\r\n***** USAGE *****";
        [STAThread]
        static void Main(string[] args)
        {
            OutputFolderPath = "";
            MainGameFolder = "";

            string parentName = ProcessExtensions.Parent(Process.GetCurrentProcess()).ProcessName;

            
            DeleteOldFilesAndDirs();

           
            if (parentName != "cmd")
            {
                // MainWindow mainWindow = new MainWindow();
                _mainWindow = new MainWindow();
                Application.EnableVisualStyles();
                Console.SetOut(new MultiTextWriter(new ControlWriter(_mainWindow.tbConsole), Console.Out));
                Console.Out.WriteLine(helpString);
                Application.Run(_mainWindow);
                /*
                Console.Out.WriteLine("Usage:1.Select a folder.\r\n" +
                    "2.\"Print\":show all the empty folder, but no delete anything.\r\n" +
                    "3. \"Clear\":clean the screen.\r\n" +
                    "4.\"STOP\":Stop the searching process."
                );*/
                return;
            }
            else
            {
                AllocConsole();
                List<string> cmds = ParseCommandline(args);

                if (cmds == null)
                {
                    Console.Out.WriteLine("\nPress Any Key to Quit");
                    Console.ReadKey();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmds[2]))
                    cmds[2] = Directory.GetCurrentDirectory();

                OutputFolderPath = cmds[2];

                if (string.IsNullOrWhiteSpace(cmds[1]) || string.IsNullOrWhiteSpace(cmds[0]))
                {
                    Console.Out.WriteLine("\nPress Any Key to Quit");
                    Console.ReadKey();
                    return;
                }

                if (int.Parse(cmds[0]) > 4 || int.Parse(cmds[0]) < 0)
                    return;                          
            }

            Console.Out.WriteLine("\nPress Any Key to Quit");
            Console.ReadKey();
        }

        public static void RunClean()
        {
            Console.Out.WriteLine("");
            Console.Out.WriteLine("#---- Started  Clean Operation ----#\n");
            Console.Out.WriteLine("");
            var startingPath = Program.OutputFolderPath;
            i = 1;
            if (Directory.Exists(startingPath))
            {
                Console.Out.WriteLine("The following folders have been deleted:");
                RecurseDirectory(startingPath);
                if (i == 1)
                {
                    Console.Out.WriteLine("[NOTHING]");
                }
            }
            else
            {
                Console.Out.WriteLine("Invalid directory path: {0}", startingPath);
            }
            Console.Out.WriteLine("");
            Console.Out.WriteLine("#---- Finished Clean Operation ----#");
        }
        private static void RecurseDirectory(string path)
        {
            try
            {
                var folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

                foreach (var folder in folders)
                {
                    RecurseDirectory(folder);
                }

                var results = Directory.GetDirectories(path).Any() || Directory.GetFiles(path).Any();

                if (!results && GetDirectorySize(path) == 0)
                {
                    Directory.Delete(path, false);
                    Console.WriteLine("[{0}]: {1}", i, path);
                    i++;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void RunPrint()
        {
            Console.Out.WriteLine("#---- Started  Print Operation ----#");
            Console.Out.WriteLine();
            var startingPath = Program.OutputFolderPath;
            i = 1;
            if (Directory.Exists(startingPath))
            {
                Console.Out.WriteLine("The following folders will be deleted:");
                RecurseDirectoryPrint(startingPath);
                if (i == 1)
                {
                    Console.Out.WriteLine("[NOTHING]");
                    Console.Out.WriteLine();
                    Console.Out.WriteLine("The folder is clean.");
                }
            } else {
                Console.Out.WriteLine("Invalid directory path: {0}", startingPath);
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine("\n#---- Finished Print Operation ----#");
        }        
        public static void InvokeStop()
        {
            Console.Out.WriteLine("#---- You have canceled the delete operation. ----#");
            //throw new ArgumentException("Artificial interruption!");
            // throw new Exception("Artificial interruption!");

        }

        private static void RecurseDirectoryPrint(string path)
        {
            try
            {
                
                var folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                               
                foreach (var folder in folders)
                {
                    RecurseDirectoryPrint(folder);
                }

                var results = Directory.GetDirectories(path).Any() || Directory.GetFiles(path).Any();

                if (!results && GetDirectorySize(path) == 0)
                {
                    Console.WriteLine("[{0}]: {1}", i, path);
                    i++;
                }
            }
            catch (Exception)
            {
            }
        }
        private static long GetDirectorySize(string path)
        {
            var fileNames = Directory.GetFiles(path, "*.*");
            long size = 0;

            foreach (var fileName in fileNames)
            {
                var info = new FileInfo(fileName);

                size += info.Length;
            }
            return size;
        }
        public static void RunClear()
        {
            _mainWindow.tbConsole.Clear();
            // Console.Out.WriteLine(helpString);
        }
        static void DeleteOldFilesAndDirs()
        {
            DirectoryInfo baseDir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            if (baseDir.Exists)
            {
                //delete sub directories:
                foreach (var dir in baseDir.EnumerateDirectories())
                {
                    System.IO.Directory.Delete(dir.FullName, true);
                }

                string name = Process.GetCurrentProcess().MainModule.FileName;
                string app = System.IO.Path.GetFileName(name);

                //delete files:
                foreach (var file in baseDir.GetFiles())
                {
                    if (file.Extension != ".exe" && file.Extension != ".md" && file.Extension != ".pdb" && file.Extension != ".bat")
                        file.Delete();
                }
            }
        }
        private static MainWindow _mainWindow;
        private static int i;
    }
}
