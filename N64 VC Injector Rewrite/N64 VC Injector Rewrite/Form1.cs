using MetroFramework;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace N64_VC_Injector_Rewrite
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static int BR = 0;
        static int ID = 0;
        static int Hint = 0;
        static int TK = 0;
        static int CK = 0;
        static int Folder = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BR = 1;
            ID = 1;
            Hint = 1;
            Folder = 1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            BR = 2;
            ID = 2;
            Hint = 2;
            Folder = 2;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            BR = 3;
            ID = 3;
            Hint = 3;
            Folder = 3;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            string word = "<ckey>";
            if (File.ReadAllText(cfg).Contains(word))
            {
                string text = File.ReadAllText(cfg);
                text = text.Replace(word, metroTextBox1.Text);
                File.WriteAllText(cfg, text);
            }
            if (ID == 1)
            {
                Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
                System.Diagnostics.Process clientProcess = new Process();
                clientProcess.StartInfo.FileName = "java";
                clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 0005000010199800 " + metroTextBox2.Text + " -file .*";
                clientProcess.Start();
                clientProcess.WaitForExit();
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                metroButton4.Enabled = false;
            }
            else
            {
                if (ID == 2)
                {
                    Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "java";
                    clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 00050000101ebc00 " + metroTextBox2.Text + " -file .*";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    metroButton4.Enabled = false;
                }
                else
                {
                    if (ID == 3)
                    {
                        Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
                        System.Diagnostics.Process clientProcess = new Process();
                        clientProcess.StartInfo.FileName = "java";
                        clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 0005000010199300 " + metroTextBox2.Text + " -file .*";
                        clientProcess.Start();
                        clientProcess.WaitForExit();
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        metroButton4.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BR == 0)
            {
                metroLabel7.Text = "Choose a BaseRom or use your own BaseRom";
                metroButton6.Enabled = false;
                metroTextBox2.Enabled = false;
            }
            else
            {
                if (BR == 1)
                {
                    metroLabel7.Text = "Insert the TitleKey for Paper Mario [EUR]";
                    metroButton6.Enabled = true;
                    metroTextBox2.Enabled = true;
                }
                else
                {
                    if (BR == 2)
                    {
                        metroLabel7.Text = "Insert the TitleKey for F-Zero X [US]";
                        metroButton6.Enabled = true;
                        metroTextBox2.Enabled = true;
                    }
                    else
                    {
                        if (BR == 3)
                        {
                            metroLabel7.Text = "Insert the TitleKey for Donkey Kong 64 [EUR]";
                            metroButton6.Enabled = true;
                            metroTextBox2.Enabled = true;
                        }
                        else


                        {
                            metroLabel7.Text = "Using Custom BaseRom";
                            metroButton6.Enabled = false;
                            metroTextBox2.Enabled = false;
                        }
                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            if (Hint == 1)
            {
                var TKEYHINT = "a694";
                if (metroTextBox2.Text.StartsWith(TKEYHINT))
                {


                    MessageBox.Show("The TitleKey is correct");
                    TK = 1;
                    metroTextBox2.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("The TitleKey is incorrect");
                    TK = 0;
                    metroTextBox2.ReadOnly = false;
                }
            }
            else
            {
                if (Hint == 2)
                {
                    var TKEYHINT = "bfdb";
                    if (metroTextBox2.Text.StartsWith(TKEYHINT))
                    {
                        MessageBox.Show("The TitleKey is correct");
                        TK = 1;
                        metroTextBox2.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("The TitleKey is incorrect");
                        TK = 0;
                        metroTextBox2.ReadOnly = false;
                    }
                }
                else
                {
                    if (Hint == 3)
                    {
                        var TKEYHINT = "3229";
                        if (metroTextBox2.Text.StartsWith(TKEYHINT))
                        {
                            MessageBox.Show("The TitleKey is correct");
                            TK = 1;
                            metroTextBox2.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("The TitleKey is incorrect");
                            TK = 0;
                            metroTextBox2.ReadOnly = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }


        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            var CKEYHINT = "D7B0";
            if (metroTextBox1.Text.StartsWith(CKEYHINT))
            {
                MessageBox.Show("The CommonKey is correct");
                CK = 1;
                metroTextBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("The CommonKey is incorrect");
                CK = 0;
                metroTextBox1.ReadOnly = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TK == 1)
            {
                if (CK == 1)
                {
                    metroButton4.Enabled = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TK == 1)
            {
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
                metroButton3.Enabled = false;

            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (Folder == 1)
                {
                    tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                    string rom = openFileDialog1.FileName;
                    string ndir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\rom.n64");
                    string vdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\rom.v64");
                    string zdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\rom.z64");
                    string converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter");
                    string rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\rom\UNMQP0.810");
                    string injectedrom = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\UNMQP0.810");
                    string pattern = @"n64";
                    string pattern2 = @"v64";
                    string pattern3 = @"z64";
                    bool n = Regex.IsMatch(rom, pattern);
                    if (n == true)
                    {
                        File.Copy(tempPath, ndir);
                        Directory.SetCurrentDirectory(converter);
                        System.Diagnostics.Process clientProcess = new Process();
                        clientProcess.StartInfo.FileName = "java";
                        clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.n64 -o rom.z64";
                        clientProcess.Start();
                        clientProcess.WaitForExit();
                        File.Move("rom.z64", "UNMQP0.810");
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        File.Delete(rompath);
                        File.Move(injectedrom, rompath);

                    }
                    bool v = Regex.IsMatch(rom, pattern2);
                    if (v == true)
                    {
                        File.Copy(tempPath, vdir);
                        Directory.SetCurrentDirectory(converter);
                        System.Diagnostics.Process clientProcess = new Process();
                        clientProcess.StartInfo.FileName = "java";
                        clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.v64 -o rom.z64";
                        clientProcess.Start();
                        clientProcess.WaitForExit();
                        File.Move("rom.z64", "UNMQP0.810");
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        File.Delete(rompath);
                        File.Move(injectedrom, rompath);

                    }
                    bool z = Regex.IsMatch(rom, pattern3);
                    if (z == true)
                    {
                        File.Copy(tempPath, zdir);
                        Directory.SetCurrentDirectory(converter);
                        File.Move("rom.z64", "UNMQP0.810");
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        File.Delete(rompath);
                        File.Move(injectedrom, rompath);
                    }
                    else
                    {
                        if (Folder == 2)
                        {
                            tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                            string rompath2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\content\rom\Ucfze0.242");
                            string injectedrom2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\Ucfze0.242");
                            bool n2 = Regex.IsMatch(rom, pattern);
                            if (n2 == true)
                            {
                                File.Copy(tempPath, ndir);
                                Directory.SetCurrentDirectory(converter);
                                System.Diagnostics.Process clientProcess = new Process();
                                clientProcess.StartInfo.FileName = "java";
                                clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.n64 -o rom.z64";
                                clientProcess.Start();
                                clientProcess.WaitForExit();
                                File.Move("rom.z64", "Ucfze0.242");
                                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                File.Delete(rompath);
                                File.Move(injectedrom2, rompath2);

                            }
                            bool v2 = Regex.IsMatch(rom, pattern2);
                            if (v2 == true)
                            {
                                File.Copy(tempPath, vdir);
                                Directory.SetCurrentDirectory(converter);
                                System.Diagnostics.Process clientProcess = new Process();
                                clientProcess.StartInfo.FileName = "java";
                                clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.v64 -o rom.z64";
                                clientProcess.Start();
                                clientProcess.WaitForExit();
                                File.Move("rom.z64", "Ucfze0.242");
                                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                File.Delete(rompath);
                                File.Move(injectedrom2, rompath2);

                            }
                            bool z2 = Regex.IsMatch(rom, pattern3);
                            if (z2 == true)
                            {
                                File.Copy(tempPath, zdir);
                                Directory.SetCurrentDirectory(converter);
                                File.Move("rom.z64", "Ucfze0.242");
                                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                File.Delete(rompath);
                                File.Move(injectedrom2, rompath2);
                            }
                            else
                            {
                                if (Folder == 3)
                                {
                                    tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                                    string rompath3 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\content\rom\Undop0.599");
                                    string injectedrom3 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\Undop0.599");
                                    bool n3 = Regex.IsMatch(rom, pattern);
                                    if (n3 == true)
                                    {
                                        File.Copy(tempPath, ndir);
                                        Directory.SetCurrentDirectory(converter);
                                        System.Diagnostics.Process clientProcess = new Process();
                                        clientProcess.StartInfo.FileName = "java";
                                        clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.n64 -o rom.z64";
                                        clientProcess.Start();
                                        clientProcess.WaitForExit();
                                        File.Move("rom.z64", "Undop0.599");
                                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                        File.Delete(rompath);
                                        File.Move(injectedrom3, rompath3);

                                    }
                                    bool v3 = Regex.IsMatch(rom, pattern2);
                                    if (v3 == true)
                                    {
                                        File.Copy(tempPath, vdir);
                                        Directory.SetCurrentDirectory(converter);
                                        System.Diagnostics.Process clientProcess = new Process();
                                        clientProcess.StartInfo.FileName = "java";
                                        clientProcess.StartInfo.Arguments = "-jar N64Converter.jar -i *.v64 -o rom.z64";
                                        clientProcess.Start();
                                        clientProcess.WaitForExit();
                                        File.Move("rom.z64", "Undop0.599");
                                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                        File.Delete(rompath);
                                        File.Move(injectedrom3, rompath3);

                                    }
                                    bool z3 = Regex.IsMatch(rom, pattern3);
                                    if (z3 == true)
                                    {
                                        File.Copy(tempPath, zdir);
                                        Directory.SetCurrentDirectory(converter);
                                        File.Move("rom.z64", "Undop0.599");
                                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                        File.Delete(rompath);
                                        File.Move(injectedrom3, rompath3);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Unexpected Error");
                                }
                            }


                        }
                    }
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://wiki.gbatemp.net/wiki/WiiU_VC_N64_inject_compatibility_list");
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (Folder == 1)
            {
                var ini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\blank.ini");
                var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
                File.Delete(ini2);
                File.Copy(ini, ini2);
            }
            else
            {
                if (Folder == 2)
                {
                    var ini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\blank.ini");
                    var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\content\config\Ucfze0.242.ini");
                    File.Delete(ini2);
                    File.Copy(ini, ini2);
                }
                else
                {
                    if (Folder == 3)
                    {
                        var ini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\blank.ini");
                        var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\content\config\Undop0.599.ini");
                        File.Delete(ini2);
                        File.Copy(ini, ini2);
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (Folder == 1)
                {
                    var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
                    File.Delete(ini2);
                    File.Copy(tempPath, ini2);
                }
                else
                {
                    if (Folder == 2)
                    {
                        var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\content\config\Ucfze0.242.ini");
                        File.Delete(ini2);
                        File.Copy(tempPath, ini2);
                    }
                    else
                    {
                        if (Folder == 3)
                        {
                            var ini2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\content\config\Undop0.599.ini");
                            File.Delete(ini2);
                            File.Copy(tempPath, ini2);
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error");
                        }
                    }
                }
            }
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            metroButton5.Enabled = false;
            metroButton5.Visible = false;
            metroButton11.Visible = false;
            metroButton11.Enabled = false;
            metroButton12.Enabled = true;
            metroButton12.Visible = true;
            metroButton13.Enabled = true;
            metroButton13.Visible = true;
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            metroButton5.Enabled = true;
            metroButton5.Visible = true;
            metroButton11.Visible = true;
            metroButton11.Enabled = true;
            metroButton12.Enabled = false;
            metroButton12.Visible = false;
            metroButton13.Enabled = false;
            metroButton13.Visible = false;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/cucholix/wiivc-bis/tree/master/n64/image");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            metroButton5.Enabled = false;
            metroButton5.Visible = false;
            metroButton11.Visible = false;
            metroButton11.Enabled = false;
            metroButton14.Enabled = true;
            metroButton14.Visible = true;
            metroButton15.Enabled = true;
            metroButton15.Visible = true;
            metroButton16.Enabled = true;
            metroButton16.Visible = true;
            metroButton17.Enabled = true;
            metroButton17.Visible = true;
            metroButton18.Visible = true;
            metroButton18.Enabled = true;
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            metroButton5.Enabled = true;
            metroButton5.Visible = true;
            metroButton11.Visible = true;
            metroButton11.Enabled = true;
            metroButton14.Enabled = false;
            metroButton14.Visible = false;
            metroButton15.Enabled = false;
            metroButton15.Visible = false;
            metroButton16.Enabled = false;
            metroButton16.Visible = false;
            metroButton17.Enabled = false;
            metroButton17.Visible = false;
            metroButton18.Visible = false;
            metroButton18.Enabled = false;
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            var ptv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\bootTvTex.tga");
            var pdrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\bootDrcTex.tga");
            var picon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\iconTex.tga");
            var plogo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Files\bootLogoTex.tga");
            if (Folder == 1)
            {
                var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootTvTex.tga");
                var odrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootDrcTex.tga");
                var oicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\iconTex.tga");
                var ologo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootLogoTex.tga");
                File.Delete(otv);
                File.Delete(odrc);
                File.Delete(oicon);
                File.Delete(ologo);
                File.Copy(ptv, otv);
                File.Copy(pdrc, odrc);
                File.Copy(picon, oicon);
                File.Copy(plogo, ologo);
            }
            else
            {
                if (Folder == 2)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootTvTex.tga");
                    var odrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootDrcTex.tga");
                    var oicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\iconTex.tga");
                    var ologo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootLogoTex.tga");
                    File.Delete(otv);
                    File.Delete(odrc);
                    File.Delete(oicon);
                    File.Delete(ologo);
                    File.Copy(ptv, otv);
                    File.Copy(pdrc, odrc);
                    File.Copy(picon, oicon);
                    File.Copy(plogo, ologo);
                }
                else
                {
                    if (Folder == 3)
                    {
                        var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootTvTex.tga");
                        var odrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootDrcTex.tga");
                        var oicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\iconTex.tga");
                        var ologo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootLogoTex.tga");
                        File.Delete(otv);
                        File.Delete(odrc);
                        File.Delete(oicon);
                        File.Delete(ologo);
                        File.Copy(ptv, otv);
                        File.Copy(pdrc, odrc);
                        File.Copy(picon, oicon);
                        File.Copy(plogo, ologo);
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\bootTvTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\output\bootTvTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
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
                if (Folder == 1)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootTvTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    if (Folder == 2)
                    {
                        var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootTvTex.tga");
                        File.Delete(otv);
                        File.Move(halfinject, otv);
                    }
                    else
                    {
                        if (Folder == 3)
                        {
                            var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootTvTex.tga");
                            File.Delete(otv);
                            File.Move(halfinject, otv);
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error");
                        }

                    }
                }
            }
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\bootDrcTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\output\bootDrcTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
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
                if (Folder == 1)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootDrcTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    if (Folder == 2)
                    {
                        var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootDrcTex.tga");
                        File.Delete(otv);
                        File.Move(halfinject, otv);
                    }
                    else
                    {
                        if (Folder == 3)
                        {
                            var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootDrcTex.tga");
                            File.Delete(otv);
                            File.Move(halfinject, otv);
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error");
                        }

                    }
                }
            }
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\bootLogoTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\output\bootLogoTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
                    clientProcess.StartInfo.Arguments = "-i bootLogoTex.png -o output --width=170 --height=42 --tga-bpp=32 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);

                }
                else
                {
                    File.Copy(tempPath, halfinject);
                }
                if (Folder == 1)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootLogoTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    if (Folder == 2)
                    {
                        var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\bootLogoTex.tga");
                        File.Delete(otv);
                        File.Move(halfinject, otv);
                    }
                    else
                    {
                        if (Folder == 3)
                        {
                            var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\bootLogoTex.tga");
                            File.Delete(otv);
                            File.Move(halfinject, otv);
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error");
                        }

                    }
                }
            }
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";
            var png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\iconTex.png");
            var converter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter");
            var halfinject = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Converter\output\iconTex.tga");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith("png"))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(converter);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
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
                if (Folder == 1)
                {
                    var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\iconTex.tga");
                    File.Delete(otv);
                    File.Move(halfinject, otv);
                }
                else
                {
                    if (Folder == 2)
                    {
                        var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\iconTex.tga");
                        File.Delete(otv);
                        File.Move(halfinject, otv);
                    }
                    else
                    {
                        if (Folder == 3)
                        {
                            var otv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\iconTex.tga");
                            File.Delete(otv);
                            File.Move(halfinject, otv);
                        }
                        else
                        {
                            MessageBox.Show("Unexpected Error");
                        }

                    }
                }
            }
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            if (Folder == 1)
            {
                string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\meta.xml");
                string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\code\app.xml");
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
                node.InnerText = metroTextBox3.Text;
                node2.InnerText = metroTextBox3.Text;
                node3.InnerText = metroTextBox3.Text;
                node4.InnerText = metroTextBox3.Text;
                node5.InnerText = metroTextBox3.Text;
                node6.InnerText = metroTextBox3.Text;
                node7.InnerText = metroTextBox3.Text;
                node8.InnerText = metroTextBox3.Text;
                node9.InnerText = metroTextBox3.Text;
                node10.InnerText = metroTextBox3.Text;
                node11.InnerText = metroTextBox3.Text;
                node12.InnerText = metroTextBox3.Text;
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
                mode.InnerText = metroTextBox3.Text;
                mode2.InnerText = metroTextBox3.Text;
                mode3.InnerText = metroTextBox3.Text;
                mode4.InnerText = metroTextBox3.Text;
                mode5.InnerText = metroTextBox3.Text;
                mode6.InnerText = metroTextBox3.Text;
                mode7.InnerText = metroTextBox3.Text;
                mode8.InnerText = metroTextBox3.Text;
                mode9.InnerText = metroTextBox3.Text;
                mode10.InnerText = metroTextBox3.Text;
                mode11.InnerText = metroTextBox3.Text;
                mode12.InnerText = metroTextBox3.Text;
                doc.Save(xmlFile);
                XmlDocument doc2 = new XmlDocument();
                doc.Load(xmlFile2);
                XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
                node14.InnerText = "0005000010" + ID + "00";
                doc.Save(xmlFile2);
            }
            else
            {
                if (Folder == 2)
                {
                    string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta\meta.xml");
                    string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\code\app.xml");
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
                    node.InnerText = metroTextBox3.Text;
                    node2.InnerText = metroTextBox3.Text;
                    node3.InnerText = metroTextBox3.Text;
                    node4.InnerText = metroTextBox3.Text;
                    node5.InnerText = metroTextBox3.Text;
                    node6.InnerText = metroTextBox3.Text;
                    node7.InnerText = metroTextBox3.Text;
                    node8.InnerText = metroTextBox3.Text;
                    node9.InnerText = metroTextBox3.Text;
                    node10.InnerText = metroTextBox3.Text;
                    node11.InnerText = metroTextBox3.Text;
                    node12.InnerText = metroTextBox3.Text;
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
                    mode.InnerText = metroTextBox3.Text;
                    mode2.InnerText = metroTextBox3.Text;
                    mode3.InnerText = metroTextBox3.Text;
                    mode4.InnerText = metroTextBox3.Text;
                    mode5.InnerText = metroTextBox3.Text;
                    mode6.InnerText = metroTextBox3.Text;
                    mode7.InnerText = metroTextBox3.Text;
                    mode8.InnerText = metroTextBox3.Text;
                    mode9.InnerText = metroTextBox3.Text;
                    mode10.InnerText = metroTextBox3.Text;
                    mode11.InnerText = metroTextBox3.Text;
                    mode12.InnerText = metroTextBox3.Text;
                    doc.Save(xmlFile);
                    XmlDocument doc2 = new XmlDocument();
                    doc.Load(xmlFile2);
                    XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
                    node14.InnerText = "0005000010" + ID + "00";
                    doc.Save(xmlFile2);
                }
                else
                {
                    if (Folder == 3)
                    {
                        string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta\meta.xml");
                        string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\code\app.xml");
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
                        node.InnerText = metroTextBox3.Text;
                        node2.InnerText = metroTextBox3.Text;
                        node3.InnerText = metroTextBox3.Text;
                        node4.InnerText = metroTextBox3.Text;
                        node5.InnerText = metroTextBox3.Text;
                        node6.InnerText = metroTextBox3.Text;
                        node7.InnerText = metroTextBox3.Text;
                        node8.InnerText = metroTextBox3.Text;
                        node9.InnerText = metroTextBox3.Text;
                        node10.InnerText = metroTextBox3.Text;
                        node11.InnerText = metroTextBox3.Text;
                        node12.InnerText = metroTextBox3.Text;
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
                        mode.InnerText = metroTextBox3.Text;
                        mode2.InnerText = metroTextBox3.Text;
                        mode3.InnerText = metroTextBox3.Text;
                        mode4.InnerText = metroTextBox3.Text;
                        mode5.InnerText = metroTextBox3.Text;
                        mode6.InnerText = metroTextBox3.Text;
                        mode7.InnerText = metroTextBox3.Text;
                        mode8.InnerText = metroTextBox3.Text;
                        mode9.InnerText = metroTextBox3.Text;
                        mode10.InnerText = metroTextBox3.Text;
                        mode11.InnerText = metroTextBox3.Text;
                        mode12.InnerText = metroTextBox3.Text;
                        doc.Save(xmlFile);
                        XmlDocument doc2 = new XmlDocument();
                        doc.Load(xmlFile2);
                        XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
                        node14.InnerText = "0005000010" + ID + "00";
                        doc.Save(xmlFile2);
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = folderBrowserDialog1.SelectedPath;
                if (Folder == 1)
                {
                    var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta");
                    var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content");
                    var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\code");
                    var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]");
                    var Newmeta = Path.Combine(tempPath, @"meta");
                    var Newcon = Path.Combine(tempPath, @"content");
                    var Newcode = Path.Combine(tempPath, @"code");
                    Directory.Move(filesmeta, Newmeta);
                    Directory.Move(filescontent, Newcon);
                    Directory.Move(filescode, Newcode);
                    Directory.Delete(delfolder);
                } else
                {
                    if(Folder == 2)
                    {
                        var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta");
                        var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\content");
                        var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\code");
                        var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]");
                        var Newmeta = Path.Combine(tempPath, @"meta");
                        var Newcon = Path.Combine(tempPath, @"content");
                        var Newcode = Path.Combine(tempPath, @"code");
                        Directory.Move(filesmeta, Newmeta);
                        Directory.Move(filescontent, Newcon);
                        Directory.Move(filescode, Newcode);
                        Directory.Delete(delfolder);
                    } else
                    {
                        if (Folder == 3)
                        {
                            var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta");
                            var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\content");
                            var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\code");
                            var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]");
                            var Newmeta = Path.Combine(tempPath, @"meta");
                            var Newcon = Path.Combine(tempPath, @"content");
                            var Newcode = Path.Combine(tempPath, @"code");
                            Directory.Move(filesmeta, Newmeta);
                            Directory.Move(filescontent, Newcon);
                            Directory.Move(filescode, Newcode);
                            Directory.Delete(delfolder);
                        } else
                        {
                            MessageBox.Show("Unexpected Error");
                        }
                    }
                }
            }
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            if (Folder == 1)
            {
                var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta");
                var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content");
                var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\code");
                var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]");
                var Newmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\meta");
                var Newcon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\content");
                var Newcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\code");
                var temp = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\tmp");
                var delfolder2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\output");
                Directory.Move(filesmeta, Newmeta);
                Directory.Move(filescontent, Newcon);
                Directory.Move(filescode, Newcode);
                Directory.Delete(delfolder);
                Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSpacker"));
                System.Diagnostics.Process clientProcess = new Process();
                clientProcess.StartInfo.FileName = "java";
                clientProcess.StartInfo.Arguments = "-jar NUSPacker.jar -in input -out output -encryptKey with " + metroTextBox1.Text;
                clientProcess.Start();
                clientProcess.WaitForExit();
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                FolderBrowserDialog browser = new FolderBrowserDialog();

                string tempPath = "";

                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    tempPath = folderBrowserDialog1.SelectedPath;
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
                    Directory.Delete(Newmeta, recursive: true);
                    Directory.Delete(Newcon, recursive: true);
                    Directory.Delete(Newcode, recursive: true);
                }
            }else {
                
                if(Folder == 2)
                {
                    var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\meta");
                    var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\content");
                    var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]\code");
                    var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\F-Zero X [NAWE01]");
                    var Newmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\meta");
                    var Newcon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\content");
                    var Newcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\code");
                    var temp = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\tmp");
                    var delfolder2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\output");
                    Directory.Move(filesmeta, Newmeta);
                    Directory.Move(filescontent, Newcon);
                    Directory.Move(filescode, Newcode);
                    Directory.Delete(delfolder);
                    Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSpacker"));
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "java";
                    clientProcess.StartInfo.Arguments = "-jar NUSPacker.jar -in input -out output -encryptKey with " + metroTextBox1.Text;
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    FolderBrowserDialog browser = new FolderBrowserDialog();

                    string tempPath = "";

                    if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        tempPath = folderBrowserDialog1.SelectedPath;
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
                        Directory.Delete(Newmeta, recursive: true);
                        Directory.Delete(Newcon, recursive: true);
                        Directory.Delete(Newcode, recursive: true);
                    }
                    } else
                {
                    if(Folder == 3)
                    {
                        var filesmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\meta");
                        var filescontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\content");
                        var filescode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]\code");
                        var delfolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Donkey Kong 64 [NAAP01]");
                        var Newmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\meta");
                        var Newcon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\content");
                        var Newcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\input\code");
                        var temp = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\tmp");
                        var delfolder2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSpacker\output");
                        Directory.Move(filesmeta, Newmeta);
                        Directory.Move(filescontent, Newcon);
                        Directory.Move(filescode, Newcode);
                        Directory.Delete(delfolder);
                        Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSpacker"));
                        System.Diagnostics.Process clientProcess = new Process();
                        clientProcess.StartInfo.FileName = "java";
                        clientProcess.StartInfo.Arguments = "-jar NUSPacker.jar -in input -out output -encryptKey with " + metroTextBox1.Text;
                        clientProcess.Start();
                        clientProcess.WaitForExit();
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        FolderBrowserDialog browser = new FolderBrowserDialog();

                        string tempPath = "";

                        if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                        {
                            tempPath = folderBrowserDialog1.SelectedPath;
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
                            Directory.Delete(Newmeta, recursive:true);
                            Directory.Delete(Newcon, recursive: true);
                            Directory.Delete(Newcode, recursive: true);
                        }
                    } else
                    {
                        MessageBox.Show("Unexpected Error");
                    }
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var check = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config.txt");
            var good = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            if (File.Exists(check))
            {
                File.Move(check, good);
            }
        }
    }
}