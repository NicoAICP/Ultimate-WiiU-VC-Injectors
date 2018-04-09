namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ndsinjector = new System.Windows.Forms.Button();
            this.gbainjector = new System.Windows.Forms.Button();
            this.n64injector = new System.Windows.Forms.Button();
            this.snesinjector = new System.Windows.Forms.Button();
            this.wiiinjector = new System.Windows.Forms.Button();
            this.nesinjector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ndsinjector
            // 
            this.ndsinjector.Location = new System.Drawing.Point(12, 12);
            this.ndsinjector.Name = "ndsinjector";
            this.ndsinjector.Size = new System.Drawing.Size(101, 23);
            this.ndsinjector.TabIndex = 0;
            this.ndsinjector.Text = "NDS VC Injector";
            this.ndsinjector.UseVisualStyleBackColor = true;
            this.ndsinjector.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbainjector
            // 
            this.gbainjector.Location = new System.Drawing.Point(137, 12);
            this.gbainjector.Name = "gbainjector";
            this.gbainjector.Size = new System.Drawing.Size(101, 23);
            this.gbainjector.TabIndex = 1;
            this.gbainjector.Text = "GBA VC Injector";
            this.gbainjector.UseVisualStyleBackColor = true;
            this.gbainjector.Click += new System.EventHandler(this.gbainjector_Click);
            // 
            // n64injector
            // 
            this.n64injector.Location = new System.Drawing.Point(12, 41);
            this.n64injector.Name = "n64injector";
            this.n64injector.Size = new System.Drawing.Size(101, 23);
            this.n64injector.TabIndex = 2;
            this.n64injector.Text = "N64 VC Injector";
            this.n64injector.UseVisualStyleBackColor = true;
            this.n64injector.Click += new System.EventHandler(this.n64injector_Click);
            // 
            // snesinjector
            // 
            this.snesinjector.Location = new System.Drawing.Point(137, 41);
            this.snesinjector.Name = "snesinjector";
            this.snesinjector.Size = new System.Drawing.Size(101, 23);
            this.snesinjector.TabIndex = 3;
            this.snesinjector.Text = "SNES VC Injector";
            this.snesinjector.UseVisualStyleBackColor = true;
            this.snesinjector.Click += new System.EventHandler(this.snesinjector_Click);
            // 
            // wiiinjector
            // 
            this.wiiinjector.Location = new System.Drawing.Point(137, 70);
            this.wiiinjector.Name = "wiiinjector";
            this.wiiinjector.Size = new System.Drawing.Size(101, 23);
            this.wiiinjector.TabIndex = 4;
            this.wiiinjector.Text = "Wii VC Injector";
            this.wiiinjector.UseVisualStyleBackColor = true;
            this.wiiinjector.Click += new System.EventHandler(this.wiiinjector_Click);
            // 
            // nesinjector
            // 
            this.nesinjector.Location = new System.Drawing.Point(13, 71);
            this.nesinjector.Name = "nesinjector";
            this.nesinjector.Size = new System.Drawing.Size(100, 23);
            this.nesinjector.TabIndex = 5;
            this.nesinjector.Text = "NES VC Injector";
            this.nesinjector.UseVisualStyleBackColor = true;
            this.nesinjector.Click += new System.EventHandler(this.nesinjector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 104);
            this.Controls.Add(this.nesinjector);
            this.Controls.Add(this.wiiinjector);
            this.Controls.Add(this.snesinjector);
            this.Controls.Add(this.n64injector);
            this.Controls.Add(this.gbainjector);
            this.Controls.Add(this.ndsinjector);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ultimate WiiU VC Injector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ndsinjector;
        private System.Windows.Forms.Button gbainjector;
        private System.Windows.Forms.Button n64injector;
        private System.Windows.Forms.Button snesinjector;
        private System.Windows.Forms.Button wiiinjector;
        private System.Windows.Forms.Button nesinjector;
    }
}

