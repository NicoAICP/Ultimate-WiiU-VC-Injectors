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

namespace N64_Injector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\CKEY");
            string ckeycheck = "D7B0";
            string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\PMEUTK");
            string tkeycheck = "a694";
            if (File.Exists(ckeylocation))
            {
                string ckey = File.ReadAllText(ckeylocation);
                if (ckey.Contains(ckeycheck))
                {
                    textBox1.Text = ckey;
                }
                else
                {
                    textBox1.Text = "";
                }
            }
            else
            {
                File.Create(ckeylocation);
                textBox1.Text = "";
            }
            if (File.Exists(tklocation))

            {
                string tkey = File.ReadAllText(tklocation);
                if (tkey.Contains(tkeycheck))
                {
                    textBox2.Text = tkey;
                }
                else
                {
                    textBox2.Text = "";
                }
            }
            else
            {
                File.Create(tklocation);
                textBox2.Text = "";
            }
            button1.Enabled = false;
            button1.Visible = false;
            label1.Enabled = true;
            label2.Enabled = false;
            label3.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Enabled = true;
            button4.Visible = true;
            label6.Enabled = true;
            label6.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
            button9.Visible = true;
            button9.Enabled = true;
            label4.Enabled = true;
            label4.Visible = true;
            button5.Enabled = true;
            button5.Visible = true;
            label5.Enabled = true;
            label5.Visible = true;
            button6.Enabled = true;
            button6.Visible = true;
            button7.Enabled = true;
            button7.Visible = true;
            label7.Enabled = true;
            label7.Visible = true;
            label8.Enabled = true;
            label8.Visible = true;
            textBox3.Enabled = true;
            textBox3.Visible = true;
            button10.Enabled = true;
            button10.Visible = true;
            label9.Enabled = true;
            button11.Enabled = true;
            label9.Visible = true;
            button11.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = "D7B0";
            string txt = textBox1.Text;
            if (txt.Contains(c))
            {
                string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\CKEY");
                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(ckeylocation))
                {
                    writetext.WriteLine(txt);
                }

                MessageBox.Show("The commonkey is correct");
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("The commonkey is incorrect");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = "a694";
            string txt = textBox2.Text;
            if (txt.Contains(c))
            {
                string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\PMEUTK");

                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(tklocation))
                {
                    writetext.WriteLine(txt);
                }
                MessageBox.Show("The Titlekey is correct");
                textBox2.Enabled = false;

            }
            else
            {
                MessageBox.Show("The Titlekey is incorrect");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL\config");
            string TK = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\Tools\Storage\PMEUTK");
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string word = "<ckey>";
            if (File.ReadAllText(cfg).Contains(word))
            {
                string text = File.ReadAllText(cfg);
                text = text.Replace(word, textBox1.Text);
                File.WriteAllText(cfg, text);
            }
            Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL"));
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 0005000010199800 " + textBox2.Text + " -file .*";
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        { FolderBrowserDialog browser = new FolderBrowserDialog();

            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
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
                    label4.Enabled = false;
                    button5.Enabled = false;
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
                    label4.Enabled = false;
                    button5.Enabled = false;
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
                    label4.Enabled = false;
                    button5.Enabled = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string tempPath = "";
            MessageBox.Show("Please choose bootDrcTex.png/tga (PNG is recommended)");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string drc = openFileDialog1.FileName;
                string png2tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga");
                string png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootDrcTex.png");
                string convertedpng = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootDrcTex.tga");
                string tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootDrcTex.tga");
                string tga2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootDrcTex.tga");
                if (openFileDialog1.FileName.EndsWith(png)) {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(png2tga);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
                    clientProcess.StartInfo.Arguments = "-i bootDrcTex.png -o meta --width=854 --height=480 --tga-bpp=24 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);
                    File.Move(convertedpng, convertedpng);
                }
                else
                {
                    File.Copy(tempPath, tga2);
                    File.Delete(tga);
                    File.Move(convertedpng, tga);
                }
               
            }
            MessageBox.Show("Please choose bootTvTex.png/tga (PNG is recommended)");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string drc = openFileDialog1.FileName;
                string png2tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga");
                string png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootTvTex.png");
                string convertedpng = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootTvTex.tga");
                string tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootTvTex.tga");
                string tga2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootTvTex.tga");
                if (openFileDialog1.FileName.EndsWith(png))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(png2tga);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
                    clientProcess.StartInfo.Arguments = "-i bootTvTex.png -o meta --width=1280 --height=720 --tga-bpp=24 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);
                    File.Move(convertedpng, convertedpng);
                }
                else
                {
                    File.Copy(tempPath, tga2);
                    File.Delete(tga);
                    File.Move(convertedpng, tga);
                }

            }
            MessageBox.Show("Please choose iconTex.png/tga (PNG is recommended)");
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string drc = openFileDialog1.FileName;
                string png2tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga");
                string png = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\iconTex.png");
                string convertedpng = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\iconTex.tga");
                string tga = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\iconTex.tga");
                string tga2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\png2tga\bootTvTex.tga");
                if (openFileDialog1.FileName.EndsWith(png))
                {
                    File.Copy(tempPath, png);

                    Directory.SetCurrentDirectory(png2tga);
                    System.Diagnostics.Process clientProcess = new Process();
                    clientProcess.StartInfo.FileName = "png2tga.exe";
                    clientProcess.StartInfo.Arguments = "-i iconTex.png -o meta --width=128 --height=128 --tga-bpp=32 --tga-compression=none";
                    clientProcess.Start();
                    clientProcess.WaitForExit();
                    Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete(png);
                    File.Move(convertedpng, convertedpng);
                }
                else
                {
                    File.Copy(tempPath, tga2);
                    File.Delete(tga);
                    File.Move(convertedpng, tga);
                }

            }
            string tgabootimage = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootLogoTex.tga");
            string tgabootimage2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\bootLogoTex.tga");
            label6.Enabled = false;
            label6.Visible = false;
            button9.Enabled = false;
            button9.Visible = false;
            button8.Enabled = false;
            button8.Visible = false;
            label10.Enabled = true;
            label10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\EDIT\meta.xml");
            string Newloc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\meta.xml");
            string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\EDIT\app.xml");
            string Newloc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\code\app.xml");
            File.Move(Newloc, xmlFile);
            File.Move(Newloc2, xmlFile2);
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
            node.InnerText = textBox3.Text;
            node2.InnerText = textBox3.Text;
            node3.InnerText = textBox3.Text;
            node4.InnerText = textBox3.Text;
            node5.InnerText = textBox3.Text;
            node6.InnerText = textBox3.Text;
            node7.InnerText = textBox3.Text;
            node8.InnerText = textBox3.Text;
            node9.InnerText = textBox3.Text;
            node10.InnerText = textBox3.Text;
            node11.InnerText = textBox3.Text;
            node12.InnerText = textBox3.Text;
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
            mode.InnerText = textBox3.Text;
            mode2.InnerText = textBox3.Text;
            mode3.InnerText = textBox3.Text;
            mode4.InnerText = textBox3.Text;
            mode5.InnerText = textBox3.Text;
            mode6.InnerText = textBox3.Text;
            mode7.InnerText = textBox3.Text;
            mode8.InnerText = textBox3.Text;
            mode9.InnerText = textBox3.Text;
            mode10.InnerText = textBox3.Text;
            mode11.InnerText = textBox3.Text;
            mode12.InnerText = textBox3.Text;
            doc.Save(xmlFile);
            File.Move(xmlFile, Newloc);
            XmlDocument doc2 = new XmlDocument();
            doc.Load(xmlFile2);
            XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
            node14.InnerText = "0005000010" + ID + "00";
            doc.Save(xmlFile2);
            File.Move(xmlFile2, Newloc2);
            label7.Enabled = false;
            label8.Enabled = false;
            textBox3.Enabled = false;
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label11.Enabled = true;
            label11.Visible = true;
            label6.Enabled = false;
            label6.Visible = false;
            button8.Visible = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button9.Visible = false;
            button12.Enabled = true;
            button12.Visible = true;
            button13.Visible = true;
            button13.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string tgabootimage = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootLogoTex.tga");
            string tgabootimage2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\bootLogoTex.tga");
            string tgabootimagedrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootDrcTex.tga");
            string tgabootimagedrc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\bootDrcTex.tga");
            string tgabootimagetv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootTvTex.tga");
            string tgabootimagetv2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\bootTvTex.tga");
            string tgabootimageicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\iconTex.tga");
            string tgabootimageicon2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\iconTex.tga");
            File.Delete(tgabootimage2);
            File.Delete(tgabootimagedrc2);
            File.Delete(tgabootimagetv2);
            File.Delete(tgabootimageicon2);
            File.Copy(tgabootimage, tgabootimage2);
            File.Copy(tgabootimagedrc, tgabootimagedrc2);
            File.Copy(tgabootimageicon, tgabootimageicon2);
            File.Copy(tgabootimagetv, tgabootimagetv2);
            button12.Enabled = false;
            button12.Visible = false;
            button13.Visible = false;
            button13.Enabled = false;
            label11.Enabled = false;
            label11.Visible = false;
            label10.Enabled = true;
            label10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tgabootimage = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootLogoTex.tga");
            string tgabootimage2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\bootLogoTex.tga");
            string tgabootimagedrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootDrcTex.tga");
            string tgabootimagedrc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\bootDrcTex.tga");
            string tgabootimagetv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\bootTvTex.tga");
            string tgabootimagetv2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\bootTvTex.tga");
            string tgabootimageicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\meta\iconTex.tga");
            string tgabootimageicon2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\iconTex.tga");
            File.Delete(tgabootimage2);
            File.Delete(tgabootimagedrc2);
            File.Delete(tgabootimagetv2);
            File.Delete(tgabootimageicon2);
            File.Copy(tgabootimage, tgabootimage2);
            File.Copy(tgabootimagedrc, tgabootimagedrc2);
            File.Copy(tgabootimageicon, tgabootimageicon2);
            File.Copy(tgabootimagetv, tgabootimagetv2);
            button12.Enabled = false;
            button12.Visible = false;
            button13.Visible = false;
            button13.Enabled = false;
            label11.Enabled = false;
            label11.Visible = false;
            label10.Enabled = true;
            label10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button6.Enabled = false;
            button14.Enabled = true;
            button15.Visible = true;
            button7.Visible = false;
            button6.Visible = false;
            button15.Enabled = true;
            button14.Visible = true;
            button16.Enabled = true;
            button16.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string oldini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
            string newini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\EU\UNMQP0.810.ini");
            File.Delete(oldini);
            File.Copy(newini, oldini);
            label12.Enabled = true;
            label12.Visible = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button14.Visible = false;
            button15.Visible = false;
            label5.Enabled = false;
            label5.Visible = false;
            button16.Enabled = false;
            button16.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string oldini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
            string newini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\BK\US\UNMQP0.810.ini");
            File.Delete(oldini);
            File.Copy(newini, oldini);
            label12.Enabled = true;
            label12.Visible = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button14.Visible = false;
            button15.Visible = false;
            label5.Enabled = false;
            label5.Visible = false;
            button16.Enabled = false;
            button16.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string oldini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
            string newini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\GAME_FILES\UNMQP0.810.ini");
            File.Delete(oldini);
            File.Copy(newini, oldini);
            label12.Enabled = true;
            label12.Visible = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button14.Visible = false;
            button15.Visible = false;
            label5.Enabled = false;
            label5.Visible = false;
            button16.Enabled = false;
            button16.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string temppath = "";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                temppath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string oldini = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTool\Paper Mario [NACP01]\content\config\UNMQP0.810.ini");
                File.Delete(oldini);
                File.Copy(temppath, oldini);
                label12.Enabled = true;
                label12.Visible = true;
                button7.Enabled = false;
                button7.Visible = false;
                button6.Visible = false;
                button6.Enabled = false;
                label5.Enabled = false;
                label5.Visible = false;
            }

            }

        private void button11_Click(object sender, EventArgs e)
        {
            var oldpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL\Paper Mario [NACP01]\meta");
            var oldpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL\Paper Mario [NACP01]\code");
            var oldpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL\Paper Mario [NACP01]\content");
            var wwus = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\JNUSTOOL\Paper Mario [NACP01]");
            var newpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\input\meta");
            var newpathpacker = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\Packer.bat");
            var newpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\input\code");
            var newpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\input\content");
            Directory.Move(oldpathcode, newpathcode);
            Directory.Move(oldpathcontent, newpathcontent);
            Directory.Move(oldpathmeta, newpathmeta);
            var nuspacker = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER");
            var input = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\input");
            var input2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\input");
            var output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\output");
            var appname = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NUSPACKER\NUSPacker.jar");
            var atb = " -in " + input + " -out " + output + " -encryptKeyWith ";
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\Storage\CKEY");
            string ckey = textBox1.Text;
            string fullpath = appname + atb + ckey;

            Directory.SetCurrentDirectory(nuspacker);
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "Packer.bat";
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var injected_game = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Injected_Games\Injected_N64_Game");
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            label13.Enabled = true;
            label13.Visible = true;
            button17.Enabled = true;
            button17.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
