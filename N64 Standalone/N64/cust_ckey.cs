using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N64
{
    public partial class cust_ckey : Form
    {

        public static bool check = false;
        public cust_ckey()
        {

            InitializeComponent();
            bunifuMaterialTextbox1.ForeColor = Color.White;
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.GetHashCode() != 487391367)
            {
                
                MessageBox.Show(this, "The entered CommonKey is invalid", "Wrong CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.ckey_strg = bunifuMaterialTextbox1.Text;
                string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Download\config");
                string word = "<ckey>";
                if (File.ReadAllText(cfg).Contains(word))
                {
                    string text = File.ReadAllText(cfg);
                    text = text.Replace(word, main.ckey_strg);
                    File.WriteAllText(cfg, text);
                }
                MessageBox.Show(this, "The entered CommonKey is valid", "Right CommonKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                check = true;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
