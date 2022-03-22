using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace OpenFrp.Lite
{

    public class work
    {

        string token = "";

        string exePath;

        public work()
        {
            printWelcome();
            exePath = Environment.CurrentDirectory;
            try
            {
                FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\OpenFrp");
            }
            catch { }
            while (true)
            {
                shell();
            }
        }

        void printWelcome()
        {
            Console.Write("Welcome! MarchOpenFrpLauncher.Lite (Version {0}, Windows Generic, .NET Framework {1})\n", Heading.Version, Heading.dotnetfxVersion);
            Console.Write("\n");
            Console.Write("  * Website:   https://www.openfrp.net \n");
            Console.Write("  * GitHub:    https://github.com/OldGodShen/OpenFrp \n");
            Console.Write("  * Powered by MarchStudio 仅限非商业使用 \n");
            Console.Write("\n");
            Console.Write("Type \"help\" to find more.\n");
            Console.Write("\n");
        }

        [DllImport("msvcrt.dll", SetLastError = false, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private extern static void system(string command);

        static void printHelp()
        {
            Console.Write("-----OpenFrp.Lite helper-----\n");
            Console.Write("exit               Quit.\n");
            Console.Write("lsfrps             List available frp servers, access token required.\n");
            Console.Write("start [serverid]   Start frpc on the specified frp server. | serverid: ID of the frp server\n");
            Console.Write("token              Print the token you set.\n");
            Console.Write("token [token]      Set your OpenFrp access token. | token: your OpenFrp access token\n");
        }

        void startfrpc(string nodeid, string actoken)
        {
            try
            {
                if (nodeid.Length < 1)
                {
                    Console.Write("Useage: start [serverid]\n");
                    Console.Write("Type \"help\" to find more.\n");
                    return;
                }
                Console.WriteLine("Starting frpc...");
                Console.WriteLine("To stop frpc, please press Ctrl+C");
                string iniPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\OpenFrp" + "\\frpc.ini";
                string iniurl = "https://api.openfrp.net/?action=getconf&token=" + actoken + "&node=" + nodeid;
                string iniContent = UI.Net.Get(iniurl);
                FileSystem.WriteAllText(iniPath, iniContent, false);
                string frpcsh = "cmd /c \"\"" + exePath + "\\frpc.exe\" -c \"" + iniPath + "\"\"";
                system(frpcsh);
                Console.Write("\nFrpc exit.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed when starting frpc.");
            }
        }

        void lsfrps()
        {
            try
            {
                string frpslist = UI.Net.Get("https://api.openfrp.net/?apitoken=LTW9yDKEfYJnzrqv&action=getnodestext&token=" + token);
                Console.WriteLine(frpslist);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed when loading frps list.");
            }
        }

        void shell()
        {
            Console.Write("OpenFrp> ");
            string script = Console.ReadLine();
            string cmd = "";
            {
                char t;
                for (int i = 0; i < script.Length; i++)
                {
                    t = script[i];
                    if (t == ' ')
                    {
                        break;
                    }
                    cmd += t;
                }
            }
            string args = "";
            for (int i = cmd.Length + 1; i < script.Length; i++)
            {
                args += script[i];
            }
            if (cmd == "exit")
            {
                Environment.Exit(0);
            }
            else if (cmd == "help")
            {
                printHelp();
            }
            else if (cmd == "token")
            {
                if (args == "")
                {
                    Console.Write("The token you set is {0}.\n", token);
                }
                else
                {
                    if (args.Length == 16)
                    {
                        token = args;
                        Console.Write("Token set.\n");
                    }
                    else
                    {
                        Console.Write("The token you entered does not seem to be correct.\nYour frp service may not work properly.\nAre you sure to continue?[y/N]");
                        string judge = "";
                        judge = Console.ReadLine();
                        if (judge == "y")
                        {
                            token = args;
                            Console.Write("Token set.\n");
                        }
                        else
                        {
                            Console.Write("Token not set.\n");
                        }
                    }
                }
            }
            else if (cmd == "start")
            {
                startfrpc(args, token);
            }
            else if (cmd == "lsfrps")
            {
                lsfrps();
            }
            else if (cmd != "")
            {
                Console.Write("{0}: Command not found.\n", cmd);
            }
            else
            {
            }
        }
    };
}
