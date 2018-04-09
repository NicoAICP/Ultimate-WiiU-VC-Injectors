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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NDS_VC_Injector_Rewrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose_Baserom.Visible = false;
            WWTEUSIZE.Visible = false;
            EUR.Visible = false;
            WWEU.Visible = false;
            WWEU.Enabled = false;
            CKEY.Visible = true;
            CKEY.Enabled = true;
            ckeytxt.Enabled = true;
            WWEUKEY.Enabled = true;
            WWEUKEY.Visible = true;
            WWEUTXT.Visible = true;
            WWEUTXT.Enabled = true;
            ckeytxt.Visible = true;
            KCHECK.Visible = true;
            KCHECK.Enabled = true;
            Download_WWEU.Visible = true;
            CR1.Visible = true;
            CR2.Visible = true;
            CR3.Visible = true;
            CR4.Visible = true;
            CRBTN.Visible = true;
            CR1.Enabled = true;
            CR2.Enabled = true;
            CR3.Enabled = true;
            CR4.Enabled = true;
            CRBTN.Enabled = true;
            label1.Enabled = true;
            label1.Visible = true;
            label2.Enabled = true;
            label2.Visible = true;
            label3.Enabled = true;
            label3.Visible = true;
            label4.Enabled = true;
            label4.Visible = true;
            label5.Enabled = true;
            label5.Visible = true;
            change.Enabled = true;
            change.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            string word = "D7B0";
            if (File.ReadAllText(cfg).Contains(word))
            {
                ckeytxt.Enabled = false;
                ckeytxt.Text = "The Commonkey got added automatically";
                textBox2.Visible = true;
                string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
                string ckey = File.ReadAllText(ckeylocation);
                textBox2.Text = ckey;
            }
            else
            {
                ckeytxt.PasswordChar = '*';
            }
           
        }

        private void Download_WWEU_Click(object sender, EventArgs e)
        {
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            string word = "<ckey>";
            if (File.ReadAllText(cfg).Contains(word))
            {
                 string text = File.ReadAllText(cfg);
                text = text.Replace(word, ckeytxt.Text);
                File.WriteAllText(cfg, text);
            }
            Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 00050000101a2000 " + WWEUKEY.Text + " -file .*";
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        private void KCHECK_Click(object sender, EventArgs e)
        {
            string WW = "no";
            string WC = "no";
            string c = "D7B0";
            string txt = ckeytxt.Text;
            string ckey = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            if (ckeytxt.Text.Contains(c))
            {
                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(ckey))
                {
                    writetext.WriteLine(txt);
                }

            }
            else
            {
                WC = "yes";
                
            }
            string id = "1337";
            string txt2 = WWEUKEY.Text;
            if (WWEUKEY.Text.Contains(id))
            {
               
            }
            else
            {
                WW = "yes";
                MessageBox.Show("The Titlekey is incorrect");
            }
            if(WC == "no")
            {
                MessageBox.Show("The Commonkey is correct");
                if(WW == "no")
                {
                    MessageBox.Show("The Titlekey is correct");
                    Download_WWEU.Enabled = true;
                } else
                {
                    MessageBox.Show("The Titlekey is incorrect");
                }
            } else
            {
                MessageBox.Show("The Commonkey is incorrect");
                if (WW == "no")
                {
                    MessageBox.Show("The Titlekey is correct");
                }
                else
                {
                    MessageBox.Show("The Titlekey is incorrect");
                }
            }
        }

        private void CRBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string sourcefile = tempPath;
                string newfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WUP-N-DAGP.srl");

                string oldromzip = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\rom.zip");
                string desfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\rom.nds");
                string rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\");
                System.IO.File.Copy(sourcefile, desfile);
                string olddir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]");
                File.Move(desfile, newfile);
                File.Delete(oldromzip);
                string zip = "7za.exe";
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\7zip\");
                proc.StartInfo.FileName = zip;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = "a ../JNUSTOOL/rom.zip ../JNUSTOOL/WUP-N-DAGP.srl";
                proc.Start();
                proc.WaitForExit();
                int exitCode = proc.ExitCode;
                proc.Close();
                string injctdrom = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\rom.zip");
                File.Move(injctdrom, oldromzip);
                string newnewfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WUP-N-DAGP.srl");
                File.Delete(newnewfile);

            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\meta.xml");
            string Newloc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\meta\meta.xml");
            string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\app.xml");
            string Newloc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\code\app.xml");
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
            node.InnerText = textBox1.Text;
            node2.InnerText = textBox1.Text;
            node3.InnerText = textBox1.Text;
            node4.InnerText = textBox1.Text;
            node5.InnerText = textBox1.Text;
            node6.InnerText = textBox1.Text;
            node7.InnerText = textBox1.Text;
            node8.InnerText = textBox1.Text;
            node9.InnerText = textBox1.Text;
            node10.InnerText = textBox1.Text;
            node11.InnerText = textBox1.Text;
            node12.InnerText = textBox1.Text;
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
            mode.InnerText = textBox1.Text;
            mode2.InnerText = textBox1.Text;
            mode3.InnerText = textBox1.Text;
            mode4.InnerText = textBox1.Text;
            mode5.InnerText = textBox1.Text;
            mode6.InnerText = textBox1.Text;
            mode7.InnerText = textBox1.Text;
            mode8.InnerText = textBox1.Text;
            mode9.InnerText = textBox1.Text;
            mode10.InnerText = textBox1.Text;
            mode11.InnerText = textBox1.Text;
            mode12.InnerText = textBox1.Text;
            doc.Save(xmlFile);
            File.Move(xmlFile, Newloc);
            XmlDocument doc2 = new XmlDocument();
            doc.Load(xmlFile2);
            XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
            node14.InnerText = "0005000010" + ID + "00";
            doc.Save(xmlFile2);
            File.Move(xmlFile2, Newloc2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var wweu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]");
            var output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\output");
            var appname = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\NUSPacker.jar");
            var atb = " -in " + wweu + " -out " + output + " -encryptKeyWith ";
            if(textBox2.Visible == true)
            {
                string fullpath = appname + atb + textBox2.Text;
                MessageBox.Show(fullpath);
                var processInfo = new ProcessStartInfo("java.exe", "-jar " + appname + atb + textBox2.Text)
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process proc;

                if ((proc = Process.Start(processInfo)) == null)
                {
                    throw new InvalidOperationException("??");
                }

                proc.WaitForExit();
                int exitCode = proc.ExitCode;
                proc.Close();
                var packedinstall = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\Injected_VC_Game");
                var endpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Injected_Games\Injected_VC_Game");
                Directory.Move(output, packedinstall);
                Directory.Move(packedinstall, endpath);
            } else
            {
                string fullpath = appname + atb + ckeytxt.Text;
                MessageBox.Show(fullpath);
                var processInfo = new ProcessStartInfo("java.exe", "-jar " + appname + atb + ckeytxt.Text)
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process proc;

                if ((proc = Process.Start(processInfo)) == null)
                {
                    throw new InvalidOperationException("??");
                }

                proc.WaitForExit();
                int exitCode = proc.ExitCode;
                proc.Close();
                var packedinstall = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\Injected_VC_Game");
                var endpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Injected_Games\Injected_VC_Game");
                Directory.Move(output, packedinstall);
                Directory.Move(packedinstall, endpath);
            }

           
            
        }
    }
}
