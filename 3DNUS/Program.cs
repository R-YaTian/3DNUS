using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _3DNUS
{
    static class Program
    {
        static string server = "http://nus.cdn.c.shop.nintendowifi.net/ccs/download/";

        private static void log(int nl, string msg)
        {
            Console.WriteLine(msg);
        }

        private static void singledownload(string title, string version, bool create_cia = false)
        {
            log(2, "Downloading " + title + " v" + version);
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            string ftmp = cd + "\\tmp";
            string downloadtmd = server + title + "/" + "tmd." + version;
            string downloadcetk = server + title + "/cetk";

            try
            {
                Directory.Delete(ftmp, true);
            }
            catch { }
            Directory.CreateDirectory(ftmp);

            try
            {
                WebClient dtmd = new WebClient();
                dtmd.DownloadFile(downloadtmd, @ftmp + "\\tmd");
                dtmd.DownloadFile(downloadcetk, @ftmp + "\\cetk");
            }
            catch
            {
                log(2, "Error downloading title " + title + " v" + version + " make sure the entered title ID and versions are correct.");
                return;
            }

            //  amount of contents
            FileStream tmd = File.Open(ftmp + "\\tmd", FileMode.Open, FileAccess.ReadWrite);
            tmd.Seek(518, SeekOrigin.Begin);
            byte[] cc = new byte[2];
            tmd.Read(cc, 0, 2);
            Array.Reverse(cc);
            int contentcounter = BitConverter.ToInt16(cc, 0);
            log(1, "Title has " + contentcounter + " contents.");

            // download files           
            WebClient contd = new WebClient();
            for (int i = 1; i <= contentcounter; i++)
            {
                log(1, "Downloading file" + i.ToString() + "...");
                int contentoffset = 2820 + (48 * (i - 1));
                tmd.Seek(contentoffset, SeekOrigin.Begin);
                byte[] cid = new byte[4];
                tmd.Read(cid, 0, 4);
                string contentid = BitConverter.ToString(cid).Replace("-", "");
                string downname = ftmp + "\\" + contentid;
                try
                {
                    contd.DownloadFile(server + title + "/" + contentid, @downname);
                }
                catch (WebException e)
                {
                    log(0, "Error " + ((HttpWebResponse)e.Response).StatusCode + " when downloading " + title + "/" + contentid + ". SKIPPING");
                    tmd.Close();
                    return;
                }
                log(0, "complete.");
            }

            tmd.Close();
            if (create_cia)
            {
                // create cia
                log(1, "Packing as .cia.");
                string command = " " + "tmp" + " " + title + ".cia";
                Process create = new Process();
                create.StartInfo.FileName = "make_cdn_cia.exe";
                create.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                create.StartInfo.Arguments = command;
                create.Start();
                create.WaitForExit();
                Directory.Delete(ftmp, true);
            }
            else
            {
                if (Directory.Exists(cd + "\\" + title + "v" + version))
                {
                    Directory.Delete(cd + "\\" + title + "v" + version, true);
                }
                Directory.Move(ftmp, cd + "\\" + title + "v" + version);
            }
            log(1, "Done.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HomeMenuDownloader V1.0");

            if (args.Length < 1)
            {
                Console.WriteLine("Usage: hmd.exe <Region>\nRegion could be 'JPN', 'USA' or 'EUS'.");
                return;
            }

            string region = args[0];

            if (region.ToUpper() == "JPN")
                singledownload("0004003000008202", "31745", File.Exists("make_cdn_cia.exe"));
            else if (region.ToUpper() == "USA")
                singledownload("0004003000008F02", "30720", File.Exists("make_cdn_cia.exe"));
            else if (region.ToUpper() == "EUS")
                singledownload("0004003000009802", "29696", File.Exists("make_cdn_cia.exe"));
            else if (region.ToUpper() == "GUI")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            } else
                Console.WriteLine("Usage: hmd.exe <Region>\nRegion could be 'JPN', 'USA' or 'EUS'.");
        }
    }
}
