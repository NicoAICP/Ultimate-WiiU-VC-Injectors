namespace NDS_VC_Injector_Rewrite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Choose_Baserom = new System.Windows.Forms.Label();
            this.WWEU = new System.Windows.Forms.Button();
            this.EUR = new System.Windows.Forms.Label();
            this.WWTEUSIZE = new System.Windows.Forms.Label();
            this.CKEY = new System.Windows.Forms.Label();
            this.ckeytxt = new System.Windows.Forms.TextBox();
            this.WWEUTXT = new System.Windows.Forms.Label();
            this.WWEUKEY = new System.Windows.Forms.TextBox();
            this.Download_WWEU = new System.Windows.Forms.Button();
            this.KCHECK = new System.Windows.Forms.Button();
            this.CR1 = new System.Windows.Forms.Label();
            this.CR2 = new System.Windows.Forms.Label();
            this.CR3 = new System.Windows.Forms.Label();
            this.CR4 = new System.Windows.Forms.Label();
            this.CRBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Choose_Baserom
            // 
            this.Choose_Baserom.AutoSize = true;
            this.Choose_Baserom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Baserom.ForeColor = System.Drawing.Color.Black;
            this.Choose_Baserom.Location = new System.Drawing.Point(11, 9);
            this.Choose_Baserom.Name = "Choose_Baserom";
            this.Choose_Baserom.Size = new System.Drawing.Size(294, 24);
            this.Choose_Baserom.TabIndex = 0;
            this.Choose_Baserom.Text = "Choose a baserom of your choice";
            // 
            // WWEU
            // 
            this.WWEU.Location = new System.Drawing.Point(15, 60);
            this.WWEU.Name = "WWEU";
            this.WWEU.Size = new System.Drawing.Size(131, 23);
            this.WWEU.TabIndex = 1;
            this.WWEU.Text = "Wario Ware: Touched!";
            this.WWEU.UseVisualStyleBackColor = true;
            this.WWEU.Click += new System.EventHandler(this.button1_Click);
            // 
            // EUR
            // 
            this.EUR.AutoSize = true;
            this.EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUR.ForeColor = System.Drawing.Color.Black;
            this.EUR.Location = new System.Drawing.Point(12, 40);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(37, 16);
            this.EUR.TabIndex = 2;
            this.EUR.Text = "EUR";
            // 
            // WWTEUSIZE
            // 
            this.WWTEUSIZE.AutoSize = true;
            this.WWTEUSIZE.ForeColor = System.Drawing.Color.Black;
            this.WWTEUSIZE.Location = new System.Drawing.Point(33, 84);
            this.WWTEUSIZE.Name = "WWTEUSIZE";
            this.WWTEUSIZE.Size = new System.Drawing.Size(89, 13);
            this.WWTEUSIZE.TabIndex = 3;
            this.WWTEUSIZE.Text = "Rom Size: 32 MB";
            this.WWTEUSIZE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CKEY
            // 
            this.CKEY.AutoSize = true;
            this.CKEY.Enabled = false;
            this.CKEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKEY.ForeColor = System.Drawing.Color.Black;
            this.CKEY.Location = new System.Drawing.Point(12, 12);
            this.CKEY.Name = "CKEY";
            this.CKEY.Size = new System.Drawing.Size(214, 20);
            this.CKEY.TabIndex = 4;
            this.CKEY.Text = "Enter the Wii U Common Key";
            this.CKEY.Visible = false;
            // 
            // ckeytxt
            // 
            this.ckeytxt.Enabled = false;
            this.ckeytxt.Location = new System.Drawing.Point(15, 34);
            this.ckeytxt.MaxLength = 32;
            this.ckeytxt.Name = "ckeytxt";
            this.ckeytxt.Size = new System.Drawing.Size(289, 20);
            this.ckeytxt.TabIndex = 5;
            this.ckeytxt.Visible = false;
            // 
            // WWEUTXT
            // 
            this.WWEUTXT.AutoSize = true;
            this.WWEUTXT.Enabled = false;
            this.WWEUTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WWEUTXT.ForeColor = System.Drawing.Color.Black;
            this.WWEUTXT.Location = new System.Drawing.Point(12, 61);
            this.WWEUTXT.Name = "WWEUTXT";
            this.WWEUTXT.Size = new System.Drawing.Size(346, 20);
            this.WWEUTXT.TabIndex = 6;
            this.WWEUTXT.Text = "Enter the Titlekey of Wario Ware: Touched! [EU]";
            this.WWEUTXT.Visible = false;
            // 
            // WWEUKEY
            // 
            this.WWEUKEY.Enabled = false;
            this.WWEUKEY.Location = new System.Drawing.Point(15, 84);
            this.WWEUKEY.MaxLength = 32;
            this.WWEUKEY.Name = "WWEUKEY";
            this.WWEUKEY.PasswordChar = '*';
            this.WWEUKEY.Size = new System.Drawing.Size(289, 20);
            this.WWEUKEY.TabIndex = 7;
            this.WWEUKEY.Visible = false;
            // 
            // Download_WWEU
            // 
            this.Download_WWEU.Enabled = false;
            this.Download_WWEU.Location = new System.Drawing.Point(186, 113);
            this.Download_WWEU.Name = "Download_WWEU";
            this.Download_WWEU.Size = new System.Drawing.Size(75, 23);
            this.Download_WWEU.TabIndex = 8;
            this.Download_WWEU.Text = "Download";
            this.Download_WWEU.UseVisualStyleBackColor = true;
            this.Download_WWEU.Visible = false;
            this.Download_WWEU.Click += new System.EventHandler(this.Download_WWEU_Click);
            // 
            // KCHECK
            // 
            this.KCHECK.Enabled = false;
            this.KCHECK.Location = new System.Drawing.Point(62, 113);
            this.KCHECK.Name = "KCHECK";
            this.KCHECK.Size = new System.Drawing.Size(75, 23);
            this.KCHECK.TabIndex = 9;
            this.KCHECK.Text = "Check Keys";
            this.KCHECK.UseVisualStyleBackColor = true;
            this.KCHECK.Visible = false;
            this.KCHECK.Click += new System.EventHandler(this.KCHECK_Click);
            // 
            // CR1
            // 
            this.CR1.AutoSize = true;
            this.CR1.Enabled = false;
            this.CR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CR1.ForeColor = System.Drawing.Color.Black;
            this.CR1.Location = new System.Drawing.Point(560, 12);
            this.CR1.Name = "CR1";
            this.CR1.Size = new System.Drawing.Size(250, 20);
            this.CR1.TabIndex = 10;
            this.CR1.Text = "Choose the rom you want to Inject";
            this.CR1.Visible = false;
            // 
            // CR2
            // 
            this.CR2.AutoSize = true;
            this.CR2.Location = new System.Drawing.Point(605, 34);
            this.CR2.Name = "CR2";
            this.CR2.Size = new System.Drawing.Size(151, 13);
            this.CR2.TabIndex = 11;
            this.CR2.Text = "Rom has to be named rom.nds";
            this.CR2.Visible = false;
            // 
            // CR3
            // 
            this.CR3.AutoSize = true;
            this.CR3.Location = new System.Drawing.Point(602, 51);
            this.CR3.Name = "CR3";
            this.CR3.Size = new System.Drawing.Size(157, 13);
            this.CR3.TabIndex = 12;
            this.CR3.Text = "Rom has to be 32 MB or smaller";
            this.CR3.Visible = false;
            // 
            // CR4
            // 
            this.CR4.AutoSize = true;
            this.CR4.Location = new System.Drawing.Point(570, 68);
            this.CR4.Name = "CR4";
            this.CR4.Size = new System.Drawing.Size(227, 13);
            this.CR4.TabIndex = 13;
            this.CR4.Text = "Injection of the rom will start after you choose it";
            this.CR4.Visible = false;
            // 
            // CRBTN
            // 
            this.CRBTN.Enabled = false;
            this.CRBTN.Location = new System.Drawing.Point(632, 86);
            this.CRBTN.Name = "CRBTN";
            this.CRBTN.Size = new System.Drawing.Size(97, 23);
            this.CRBTN.TabIndex = 14;
            this.CRBTN.Text = "Choose ROM";
            this.CRBTN.UseVisualStyleBackColor = true;
            this.CRBTN.Visible = false;
            this.CRBTN.Click += new System.EventHandler(this.CRBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(643, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = ".xml edits";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Game Name";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(622, 152);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Location = new System.Drawing.Point(640, 187);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 18;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Visible = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Boot images";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "The bootimage feature will be added after the images are made";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(402, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Packaging";
            this.label5.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(406, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Pack";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 34);
            this.textBox2.MaxLength = 32;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 284);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CRBTN);
            this.Controls.Add(this.CR4);
            this.Controls.Add(this.CR3);
            this.Controls.Add(this.CR2);
            this.Controls.Add(this.CR1);
            this.Controls.Add(this.KCHECK);
            this.Controls.Add(this.Download_WWEU);
            this.Controls.Add(this.WWEUKEY);
            this.Controls.Add(this.WWEUTXT);
            this.Controls.Add(this.ckeytxt);
            this.Controls.Add(this.CKEY);
            this.Controls.Add(this.WWTEUSIZE);
            this.Controls.Add(this.EUR);
            this.Controls.Add(this.WWEU);
            this.Controls.Add(this.Choose_Baserom);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Choose_Baserom;
        private System.Windows.Forms.Button WWEU;
        private System.Windows.Forms.Label EUR;
        private System.Windows.Forms.Label WWTEUSIZE;
        private System.Windows.Forms.Label CKEY;
        private System.Windows.Forms.TextBox ckeytxt;
        private System.Windows.Forms.Label WWEUTXT;
        private System.Windows.Forms.TextBox WWEUKEY;
        private System.Windows.Forms.Button Download_WWEU;
        private System.Windows.Forms.Button KCHECK;
        private System.Windows.Forms.Label CR1;
        private System.Windows.Forms.Label CR2;
        private System.Windows.Forms.Label CR3;
        private System.Windows.Forms.Label CR4;
        private System.Windows.Forms.Button CRBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

