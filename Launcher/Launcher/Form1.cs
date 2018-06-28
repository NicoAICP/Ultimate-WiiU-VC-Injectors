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

namespace Launcher
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string NDS = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NDS\NDSinjector.exe");
            ProcessStartInfo NDSInjector = new ProcessStartInfo();
            NDSInjector.FileName = NDS;
            Process.Start(NDSInjector);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string N64 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\N64\N64INJECTOR.exe");
            Process N64Injector = new Process();
            N64Injector.StartInfo.FileName = N64;
            N64Injector.Start();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            string GBA = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\GBA\GBAINJECTOR.bat");
            Process GBAInjector = new Process();
            GBAInjector.StartInfo.FileName = GBA;
            GBAInjector.Start();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string SNESNES = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NESSNES\SNESNESINJECTOR.bat");
            Process SNESNESInjector = new Process();
            SNESNESInjector.StartInfo.FileName = SNESNES;
            SNESNESInjector.Start();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string WII = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\WII\WIIINJECTOR.exe");
            Process WIIInjector = new Process();
            WIIInjector.StartInfo.FileName = WII;
            WIIInjector.Start();
        }
    }
}
