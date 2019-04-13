using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N64
{
    public partial class updater : Form
    {
        public static byte update = 0;
        bool check = false, done = true;
        int move = 2, time = 0, save = 0, work = 0;
        public updater()
        {
            InitializeComponent();
        }
        WebClient client;
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void updater_Load(object sender, EventArgs e)
        {
            timer1.Start();
            client = new WebClient();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panelslide.Left += 2;
            if (panelslide.Left > 318)
            {
                panelslide.Left = -87;
            }
            if (panelslide.Left < 0)
            {
                move = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update = 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time++;
            
            if (time == 100)
            {
                bunifuLabel1.Text = "Can't connect to the server";
                bunifuLabel1.Location = new Point(28, 160);
            }
            if(time == 120)
            {
                bunifuLabel1.Text = "Starting...";
                bunifuLabel1.Location = new Point(85, 160);


            }
            if (time == 130)
            {
                update = 1;

                timer1.Enabled = false;

                timer3.Enabled = false;
                    
                
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        

       

        

    }
    
}
