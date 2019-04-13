using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace N64
{
    class Usefull
    {
        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }
        static public void RemoveFilter(byte baserom)
        {
            string Filter = "";
            if (baserom == 1)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Donkey Kong 64 [NAAP01]\content\FrameLayout.arc");
            }
            else if( baserom == 2)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Paper Mario [NACP01]\content\FrameLayout.arc");
            }
            else if (baserom == 3)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\F-Zero X [NAWE01]\content\FrameLayout.arc");
            }
            else if (baserom == 4)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Super Mario 64 [NABE01]\content\FrameLayout.arc");
            }
            else if (baserom == 5)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Golf [NAGE01]\content\FrameLayout.arc");
            }
            else if (baserom == 6)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Party 2 [NAQE01]\content\FrameLayout.arc");
            }
            else if (baserom == 7)
            {
                Filter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\content\FrameLayout.arc");
            }
            BinaryWriter writer = new BinaryWriter(new FileStream(Filter, FileMode.Open));
            writer.BaseStream.Position = 0x1AD8;
            writer.Write(0x00);
            writer.Close();
            BinaryWriter writer1 = new BinaryWriter(new FileStream(Filter, FileMode.Open));
            writer1.BaseStream.Position = 0x1ADC;
            writer1.Write(0x00);
            writer1.Close();
        }
        public static void EditXML(byte baserom, string name)
        {
            string xmlFile = "", xmlFile2 = "";
            if (baserom == 1)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Donkey Kong 64 [NAAP01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Donkey Kong 64 [NAAP01]\code\app.xml");

            }
            else if (baserom == 2)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Paper Mario [NACP01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Paper Mario [NACP01]\code\app.xml");

            }
            else if (baserom == 3)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\F-Zero X [NAWE01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\F-Zero X [NAWE01]\code\app.xml");

            }
            else if (baserom == 4)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Super Mario 64 [NABE01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Super Mario 64 [NABE01]\code\app.xml");

            }
            else if (baserom == 5)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Golf [NAGE01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Golf [NAGE01]\code\app.xml");

            }
            else if (baserom == 6)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Party 2 [NAQE01]\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\Mario Party 2 [NAQE01]\code\app.xml");

            }
            else if (baserom == 7)
            {
                xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\meta\meta.xml");
                xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\code\app.xml");

            }
            var random = new Random();
            var ID = String.Format("{0:X4}", random.Next(0x10000));
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode node = doc.SelectSingleNode("menu/longname_ja");
            XmlNode node2 = doc.SelectSingleNode("menu/longname_en");
            XmlNode node3 = doc.SelectSingleNode("menu/longname_fr");
            XmlNode node4 = doc.SelectSingleNode("menu/longname_de");
            XmlNode node5 = doc.SelectSingleNode("menu/longname_it");
            XmlNode node6 = doc.SelectSingleNode("menu/longname_es");
            XmlNode node7 = doc.SelectSingleNode("menu/longname_zhs");
            XmlNode node8 = doc.SelectSingleNode("menu/longname_ko");
            XmlNode node9 = doc.SelectSingleNode("menu/longname_nl");
            XmlNode node10 = doc.SelectSingleNode("menu/longname_pt");
            XmlNode node11 = doc.SelectSingleNode("menu/longname_ru");
            XmlNode node12 = doc.SelectSingleNode("menu/longname_zht");
            XmlNode node13 = doc.SelectSingleNode("menu/product_code");
            XmlNode node14 = doc.SelectSingleNode("menu/title_id");
            node13.InnerText = "WUP-N-" + ID;
            node14.InnerText = "0005000010" + ID + "00";
            node.InnerText = name;
            node2.InnerText = name;
            node3.InnerText = name;
            node4.InnerText = name;
            node5.InnerText = name;
            node6.InnerText = name;
            node7.InnerText = name;
            node8.InnerText = name;
            node9.InnerText = name;
            node10.InnerText = name;
            node11.InnerText = name;
            node12.InnerText = name;
            XmlNode mode = doc.SelectSingleNode("menu/shortname_ja");
            XmlNode mode2 = doc.SelectSingleNode("menu/shortname_en");
            XmlNode mode3 = doc.SelectSingleNode("menu/shortname_fr");
            XmlNode mode4 = doc.SelectSingleNode("menu/shortname_de");
            XmlNode mode5 = doc.SelectSingleNode("menu/shortname_it");
            XmlNode mode6 = doc.SelectSingleNode("menu/shortname_es");
            XmlNode mode7 = doc.SelectSingleNode("menu/shortname_zhs");
            XmlNode mode8 = doc.SelectSingleNode("menu/shortname_ko");
            XmlNode mode9 = doc.SelectSingleNode("menu/shortname_nl");
            XmlNode mode10 = doc.SelectSingleNode("menu/shortname_pt");
            XmlNode mode11 = doc.SelectSingleNode("menu/shortname_ru");
            XmlNode mode12 = doc.SelectSingleNode("menu/shortname_zht");
            mode.InnerText = name;
            mode2.InnerText = name;
            mode3.InnerText = name;
            mode4.InnerText = name;
            mode5.InnerText = name;
            mode6.InnerText = name;
            mode7.InnerText = name;
            mode8.InnerText = name;
            mode9.InnerText = name;
            mode10.InnerText = name;
            mode11.InnerText = name;
            mode12.InnerText = name;
            doc.Save(xmlFile);
            XmlDocument doc2 = new XmlDocument();
            doc.Load(xmlFile2);
            XmlNode n2ode = doc.SelectSingleNode("app/title_id");
            n2ode.InnerText = "0005000010" + ID + "00";
            doc.Save(xmlFile2);
        }
        public static void Download(string JNUSPATH, string tid, string tkey)
        {
            Directory.SetCurrentDirectory(JNUSPATH);
            Process Download = new Process();
            Download.StartInfo.FileName = "java";
            Download.StartInfo.Arguments = "-jar JNUStool.jar " + tid + " " + tkey + " -file .*";
            Download.Start();
            Download.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }
        public static void Convert (string rom, string path)
        {
            string ndir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Convert\rom.n64");
            string vdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Convert\rom.v64");
            string zdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Convert\rom.z64");
            string pattern = @"n64";
            string pattern2 = @"v64";
            string pattern3 = @"z64";
            bool n = Regex.IsMatch(rom, pattern);
            if (n == true)
            {
                File.Copy(rom, ndir);
                
                Directory.SetCurrentDirectory(path);
                System.Diagnostics.Process clientProcess = new Process();
                clientProcess.StartInfo.FileName = "java";
                clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.n64 -o rom.z64";
                clientProcess.Start();
                clientProcess.WaitForExit();
                string[] files = Directory.GetFiles(path, "*.n64");

                foreach (string file in files)
                {
                    File.Delete(file);
                }

               
                

            }
            bool v = Regex.IsMatch(rom, pattern2);
            if (v == true)
            {
                Directory.SetCurrentDirectory(path);
                System.Diagnostics.Process clientProcess = new Process();
                clientProcess.StartInfo.FileName = "java";
                clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.v64 -o rom.z64";
                clientProcess.Start();
                clientProcess.WaitForExit();
                File.Delete("*.v64");
                string[] files = Directory.GetFiles(path, "*.v64");

                foreach (string file in files)
                {
                    File.Delete(file);
                }


            }
            bool z = Regex.IsMatch(rom, pattern3);
            if (z == true)
            {
                File.Copy(rom, zdir);
                Directory.SetCurrentDirectory(path);
            }
            
        }
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
        public static void packing(string folder)
        {

            var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), folder + "\\meta");
            var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), folder + "\\content");
            var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), folder + "\\code");
            

            var Newmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Packing\input\meta");
            var Newcon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Packing\input\content");
            var Newcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Packing\input\code");
            var temp = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Packing\tmp");
            var delfolder2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Packing\output");
            CopyFolder(filesmeta, Newmeta);
            CopyFolder(filescontent, Newcon);
            CopyFolder(filescode, Newcode);
            Directory.Delete(filesmeta, true);
            Directory.Delete(filescontent, true);
            Directory.Delete(filescode, true);
            Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Packing"));
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = "-jar NUSPacker.jar -in input -out output -encryptKeyWith " + main.ckey_strg;
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            MessageBox.Show("You have to choose an empty folder that is existing on the Drive where you have this Injector running. \n (As example, if you have this running on C:\\Users\\<your username>\\Desktop you can choose any folder on C: but not on D:)");
            selectbrowser:
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
               
                if (IsDirectoryEmpty(tempPath))
                {
               
                    string fileExtension = "*.app";

                    string[] txtFiles = Directory.GetFiles(delfolder2, fileExtension);

                    foreach (var item in txtFiles)
                    {
                        File.Move(item, Path.Combine(tempPath, Path.GetFileName(item)));
                    }
                    string fileExtension2 = "*.h3";

                    string[] txtFiles2 = Directory.GetFiles(delfolder2, fileExtension2);

                    foreach (var item in txtFiles2)
                    {
                        File.Move(item, Path.Combine(tempPath, Path.GetFileName(item)));
                    }
                    string fileExtension3 = "*.tik";

                    string[] txtFiles3 = Directory.GetFiles(delfolder2, fileExtension3);

                    foreach (var item in txtFiles3)
                    {
                        File.Move(item, Path.Combine(tempPath, Path.GetFileName(item)));
                    }
                    string fileExtension4 = "*.tmd";

                    string[] txtFiles4 = Directory.GetFiles(delfolder2, fileExtension4);

                    foreach (var item in txtFiles4)
                    {
                        File.Move(item, Path.Combine(tempPath, Path.GetFileName(item)));
                    }
                    string fileExtension5 = "*.cert";

                    string[] txtFiles5 = Directory.GetFiles(delfolder2, fileExtension5);

                    foreach (var item in txtFiles5)
                    {
                        File.Move(item, Path.Combine(tempPath, Path.GetFileName(item)));
                    }

                    Directory.Delete(delfolder2);
                    Directory.Delete(temp);
                    Directory.Delete(Newmeta, true);
                    Directory.Delete(Newcon, true);
                    Directory.Delete(Newcode, true);
                }
                else
                {
                    MessageBox.Show("Select an empty Folder!");
                    goto selectbrowser;
                }
            }
            else
            {
                MessageBox.Show("Select a Folder!");
                goto selectbrowser;
            }
        }
    }
    
}
