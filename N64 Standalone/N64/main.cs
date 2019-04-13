using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace N64
{
    public partial class main : Form
    {
        public static byte baserom = 0, done = 0;

        public static bool tkey = false, ckey = false;
        public static string ckey_strg = "", result_name = "", base_id = "", tkey_strg = "", folder = "";
        
        public main()
        {
           /* Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(6000);
            while(updater.update == 0)
            {

            }*/
            InitializeComponent();
            /*trd.Abort();
           
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;*/
            
        }
        
        private void formRun()
        {
            Application.Run(new updater());
        }
        private void formRunCust()
        {
            Application.Run(new cust_ckey());
        }
        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(baserom != 0)
            {
                bunifuFlatButton15.Enabled = true;
            }
            if(baserom == 7)
            {
                bunifuFlatButton3.Enabled = false;
            }
            else
            {
                bunifuFlatButton3.Enabled = true;
                bunifuFlatButton3.Cursor = Cursors.Hand;
            }
            if (tkey == true && ckey == true)
            {
                bunifuFlatButton16.Enabled = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           

            if (Usefull.IsDirectoryEmpty(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\")))
            {
                Environment.Exit(0);
            }
            else
            {
                foreach (var subDir in new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\")).GetDirectories())
                {
                    subDir.Delete(true);
                }
                Environment.Exit(0);
            }
                
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            tabControll1.SelectTab(0);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            tabControll1.SelectTab(1);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if(done != 0)
            {
                tabControll1.SelectTab(2);
            }
            else
            {
                MessageBox.Show("Download a Base or add an custom Base by yourself first! ");
            }
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            if (done != 0)
            {
                tabControll1.SelectTab(3);
            }
            else
            {
                MessageBox.Show("Download a Base or add an custom Base by yourself first! ");
            }

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

            tabControll1.SelectTab(4);
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Download\");
            MessageBox.Show("Note, if the download freezes, you have to wait for a bit.\nIf it didn't change progress till then, you have to restart the download by pressing this button again.\nYou also have to do that if it doesn't download anything (you notice it when it shows <game> connection failed).");
            Usefull.Download(path, base_id, tkey_strg);
            done = 1;
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            bunifuFlatButton19.Enabled = true;
            bunifuFlatButton20.Enabled = true;
            bunifuFlatButton19.Visible = true;
            bunifuFlatButton20.Visible = true;

            bunifuFlatButton18.Enabled = false;
            bunifuFlatButton18.Visible = false;
        }

        private void bunifuFlatButton28_Click(object sender, EventArgs e)
        {
            bunifuFlatButton21.Enabled = true;
            bunifuFlatButton23.Enabled = true;
            bunifuFlatButton21.Visible = true;
            bunifuFlatButton23.Visible = true;
            bunifuFlatButton24.Enabled = false;
            bunifuFlatButton24.Visible = false;

            bunifuFlatButton25.Enabled = false;
            bunifuFlatButton25.Visible = false;

            bunifuFlatButton26.Enabled = false;
            bunifuFlatButton26.Visible = false;

            Back_Cust.Enabled = false;
            Back_Cust.Visible = false;
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            Back_pre.Visible = true;

            Back_pre.Enabled = true;

            bunifuFlatButton21.Enabled = false;
            bunifuFlatButton23.Enabled = false;
            bunifuFlatButton21.Visible = false;
            bunifuFlatButton23.Visible = false;
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            bunifuFlatButton21.Enabled = false;
            bunifuFlatButton23.Enabled = false;
            bunifuFlatButton21.Visible = false;
            bunifuFlatButton23.Visible = false;

            //24-26
            bunifuFlatButton24.Enabled = true;
            bunifuFlatButton24.Visible = true;

            bunifuFlatButton25.Enabled = true;
            bunifuFlatButton25.Visible = true;

            bunifuFlatButton26.Enabled = true;
            bunifuFlatButton26.Visible = true;
            Back_Cust.Enabled = true;
            Back_Cust.Visible = true;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            baserom = 1;
            bunifuCustomLabel5.Text = "Enter the Titlekey for Donkey Kong 64 [EU]";
            base_id = "0005000010199300";
            folder = "Donkey Kong 64 [NAAP01]";
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            baserom = 2;
            bunifuCustomLabel5.Text = "Enter the Titlekey for Paper Mario [EU]";
            base_id = "0005000010199800";
            folder = "Paper Mario [NACP01]";
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            baserom = 3;
            bunifuCustomLabel5.Text = "Enter the Titlekey for F-Zero X [US]";
            base_id = "00050000101ebc00";
            folder = "F-Zero X [NAWE01]";
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            baserom = 4;
            bunifuCustomLabel5.Text = "Enter the Titlekey for Super Mario 64 [US]";
            base_id = "0005000010199500";
            folder = "Super Mario 64 [NABE01]";
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            baserom = 5;
            bunifuCustomLabel5.Text = "Enter the Titlekey for Mario Golf [US]";
            base_id = "00050000101a5900";
            folder = "Mario Golf [NAGE01]";
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            baserom = 6;
            bunifuCustomLabel5.Text = "Enter the Titlekey for Mario Party 2 [US]";
            base_id = "00050000101c5d00";
            folder = "Mario Party 2 [NAQE01]";
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            Usefull.EditXML(baserom, bunifuMaterialTextbox3.Text);
            if(radioButton1.Checked == true)
            {
                Usefull.RemoveFilter(baserom);
            }
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            var ini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\blank.ini");

            var ini2 = "";
            if(baserom == 1)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Undop0.599.ini");
            }
            else if (baserom == 2)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder+@"\content\config\UNMQP0.810.ini");

            }
            else if (baserom == 3)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Ucfze0.242.ini");
            }

            else if (baserom == 4)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unsme0.005.ini");
            }

            else if (baserom == 5)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unmfe0.443.ini");
            }

            else if (baserom == 6)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unmwe0.621.ini");
            }

            else if (baserom == 7)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\content\config\"+result_name+".ini");
            }
            File.Delete(ini2);
            File.Copy(ini, ini2);
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            var ini = "";

            var ini2 = "";
            if (baserom == 1)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Undop0.599.ini");
            }
            else if (baserom == 2)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\UNMQP0.810.ini");

            }
            else if (baserom == 3)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Ucfze0.242.ini");
            }

            else if (baserom == 4)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unsme0.005.ini");
            }

            else if (baserom == 5)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unmfe0.443.ini");
            }

            else if (baserom == 6)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\config\Unmwe0.621.ini");
            }

            else if (baserom == 7)
            {
                ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\content\config\" + result_name + ".ini");
            }
            FolderBrowserDialog browser = new FolderBrowserDialog();


            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ini = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                File.Delete(ini2);
                File.Copy(ini, ini2);
            }

        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to choose an empty folder that is existing on the Drive where you have this Injector running. \n (As example, if you have this running on C:\\Users\\<your username>\\Desktop you can choose any folder on C: but not on D:)");
            selectbrowser:
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "", filesmeta = "", filescontent = "", filescode = "";
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = folderBrowserDialog1.SelectedPath;
                if(Usefull.IsDirectoryEmpty(tempPath))
                {


                    if (baserom == 1)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 2)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 3)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 4)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 5)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 6)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\code");

                    }
                    else if (baserom == 7)
                    {
                        filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\meta");
                        filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\content");
                        filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\code");
                    }


                    var Newmeta = Path.Combine(tempPath, @"meta");
                    var Newcon = Path.Combine(tempPath, @"content");
                    var Newcode = Path.Combine(tempPath, @"code");
                    Directory.Move(filesmeta, Newmeta);
                    Directory.Move(filescontent, Newcon);
                    Directory.Move(filescode, Newcode);
                }
                else
                {
                    MessageBox.Show("Select an empty folder!");
                    goto selectbrowser;
                }
            }
            else
            {
                MessageBox.Show("Select a folder!");
                goto selectbrowser;
            }
            bunifuCustomLabel21.Visible = true;
            bunifuFlatButton27.Enabled = false;
            bunifuFlatButton27.Visible = false;
            bunifuFlatButton28.Enabled = false;
            bunifuFlatButton28.Visible = false;
            bunifuFlatButton2.Enabled = false;
            
            bunifuFlatButton3.Enabled = false;
            
            bunifuFlatButton4.Enabled = false;
            
        }

        private void bunifuFlatButton28_Click_1(object sender, EventArgs e)
        {
            if (baserom == 1)
            {
                Usefull.packing(@"Tools\Download\"+folder);
            }
            else if (baserom == 2)
            {
                Usefull.packing(@"Tools\Download\" + folder);
            }
            else if (baserom == 3)
            {
                Usefull.packing(@"Tools\Download\" + folder);
            }
            else if (baserom == 4)
            {
                Usefull.packing(@"Tools\Download\" + folder);
            }
            else if (baserom == 5)
            {
                Usefull.packing(@"Tools\Download\" + folder);
            }
            else if (baserom == 6)
            {
                Usefull.packing(@"Tools\Download\" + folder);
            }
            else if (baserom == 7)
            {
                Usefull.packing(@"Tools\Custom");
            }
            bunifuCustomLabel21.Visible = true;
            bunifuFlatButton27.Enabled = false;
            bunifuFlatButton27.Visible = false;
            bunifuFlatButton28.Enabled = false;
            bunifuFlatButton28.Visible = false;
            bunifuFlatButton2.Enabled = false;

            bunifuFlatButton3.Enabled = false;

            bunifuFlatButton4.Enabled = false;
            
        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only input files with an resolution of 128x128 and with the extension .png or .tga. If you decided to use .tga please note it might not work, since it could be made wrong.");
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\iconTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\output\iconTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tgacmd.exe";
                    clientProcess.StartInfo.Arguments = "-i iconTex.png -o output --width=128 --height=128 --tga-bpp=32 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);

                }
                else
                {
                    File.Copy(tempPath, halfinject);
                }
                if(baserom != 7)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\"+folder+@"\meta\iconTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\meta\iconTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
            }
            }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only input files with an resolution of 1280x720 and with the extension .png or .tga. If you decided to use .tga please note it might not work, since it could be made wrong.");

            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\bootTvTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\output\bootTvTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tgacmd.exe";
                    clientProcess.StartInfo.Arguments = "-i bootTvTex.png -o output --width=1280 --height=720 --tga-bpp=24 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);

                }
                else
                {
                    File.Copy(tempPath, halfinject);
                }
                if (baserom != 7)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta\bootTvTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\meta\bootTvTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
            }
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only input files with an resolution of 854x480 and with the extension .png or .tga. If you decided to use .tga please note it might not work, since it could be made wrong.");
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\bootDrcTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\image\output\bootDrcTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tgacmd.exe";
                    clientProcess.StartInfo.Arguments = "-i bootDrcTex.png -o output --width=854 --height=480 --tga-bpp=24 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);

                }
                else
                {
                    File.Copy(tempPath, halfinject);
                }
                if (baserom != 7)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\meta\bootDrcTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\meta\bootDrcTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
            }
        }

        private void bunifuFlatButton31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/WiiUInjectorWebsite");
        }

        private void bunifuFlatButton30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/UWUVCI");
        }

        private void bunifuFlatButton29_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text.GetHashCode() != 487391367)
            {

                MessageBox.Show(this, "The entered CommonKey is invalid", "Wrong CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.ckey_strg = bunifuMaterialTextbox4.Text;
                string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Download\config");
                string word = "<ckey>";
                if (File.ReadAllText(cfg).Contains(word))
                {
                    string text = File.ReadAllText(cfg);
                    text = text.Replace(word, main.ckey_strg);
                    File.WriteAllText(cfg, text);
                }
                MessageBox.Show(this, "The entered CommonKey is valid", "Right CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Information);

                done = 1;
            }
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string rom = openFileDialog1.FileName;
                string converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Convert");
                Usefull.Convert(rom, converter);
               
                string rompath ="";
                if (baserom == 1)
                {
                 rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder+ @"\content\rom\Undop0.599");

                }
                else if (baserom == 2)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\rom\UNMQP0.810");

                }

                else if (baserom == 3)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\rom\Ucfze0.242");

                }

                else if (baserom == 4)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\rom\Unsme0.005");

                }

                else if (baserom == 5)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\rom\Unmfe0.443");

                }

                else if (baserom == 6)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Download\" + folder + @"\content\rom\Unmwe0.621");

                }

                else if (baserom == 7)
                {
                    rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Custom\content\rom\"+result_name);

                }
                File.Delete(rompath);
                File.Move("rom.z64", rompath);
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.GetHashCode() != 487391367)
            {

                MessageBox.Show(this, "The entered CommonKey is invalid", "Wrong CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ckey_strg = bunifuMaterialTextbox1.Text;
                string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Download\config");
                string word = "<ckey>";
                if (File.ReadAllText(cfg).Contains(word))
                {
                    string text = File.ReadAllText(cfg);
                    text = text.Replace(word, ckey_strg);
                    File.WriteAllText(cfg, text);
                }
                MessageBox.Show(this, "The entered CommonKey is valid", "Right CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuMaterialTextbox1.Enabled = false;
                ckey = true;
            }
            
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            int hash = 0;
            if(baserom == 1)
            {
                hash = -206720283;
            }
            else if(baserom == 2)
            {
                hash = -551238474;
            }
            else if (baserom == 3)
            {
                hash = -1036835128;
            }
            else if (baserom == 4)
            {
                hash = -1272541618;
            }
            else if (baserom == 5)
            {
                hash = 241403104;
            }
            else if (baserom == 6)
            {
                hash = 289504955;
            }






            if (bunifuMaterialTextbox2.Text.GetHashCode() != hash)
            {

                MessageBox.Show(this, "The entered TitleKey is invalid", "Wrong TitleKey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tkey_strg = bunifuMaterialTextbox2.Text;
                MessageBox.Show(this, "The entered TitleKey is valid", "Right TitleKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuMaterialTextbox2.Enabled = false;
                bunifuFlatButton2.Enabled = false;
                
                tkey = true;
            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            
            baserom = 7;
            MessageBox.Show("You have to choose a Directory which includes the directories code content and meta in it, otherwise this will not work.");
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Usefull.CopyFolder(fbd.SelectedPath, Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools/Custom"));
                MessageBox.Show("Please enter the commonkey too before continuing!");


                string[] files = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools/Custom/content/rom/"));
                foreach (var item in files)
                {
                    result_name = Path.GetFileName(item);
                }
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton29.Visible = true;
                bunifuCustomLabel20.Visible = true;
                bunifuMaterialTextbox4.Visible = true;
                bunifuFlatButton29.Enabled = true;
                bunifuCustomLabel20.Enabled = true;
                bunifuMaterialTextbox4.Enabled = true;
                bunifuFlatButton13.Enabled = false;
                bunifuFlatButton13.Visible = false;
                bunifuCustomLabel3.Enabled = false;
                bunifuCustomLabel3.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a Folder!");
            }
           
        }

        private void Back_pre_Click(object sender, EventArgs e)
        {
            bunifuFlatButton21.Enabled = true;
            bunifuFlatButton23.Enabled = true;
            bunifuFlatButton21.Visible = true;
            bunifuFlatButton23.Visible = true;

            Back_pre.Visible = false;

            Back_pre.Enabled = false;

        }
    }
}
