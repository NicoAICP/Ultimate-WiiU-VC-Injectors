using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NDS = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\NDS\NDSinjector.exe");
            ProcessStartInfo NDSInjector = new ProcessStartInfo();
            NDSInjector.FileName = NDS;
            Process.Start(NDSInjector);
        }

        private void gbainjector_Click(object sender, EventArgs e)
        {
            string GBA = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\GBA\GBAINJECTOR.bat");
            Process GBAInjector = new Process();
            GBAInjector.StartInfo.FileName = GBA;
            GBAInjector.Start();
        }

        private void n64injector_Click(object sender, EventArgs e)
        {
            string N64 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\N64\N64INJECTOR.bat");
            Process N64Injector = new Process();
            N64Injector.StartInfo.FileName = N64;
            N64Injector.Start();
        }

        private void snesinjector_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }

        private void nesinjector_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }

        private void wiiinjector_Click(object sender, EventArgs e)
        {
            string WII = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tools\WII\WIIINJECTOR.exe");
            Process WIIInjector = new Process();
            WIIInjector.StartInfo.FileName = WII;
            WIIInjector.Start();
        }
    }
}
