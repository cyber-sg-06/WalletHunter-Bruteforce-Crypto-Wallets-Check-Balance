namespace WalletHunter
{
    partial class Form1
    {
 
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.api = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.walletGenerator1 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.foundBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addressCountLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.addressCountLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.addressCountLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.addressCountLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.walletGenerator2 = new System.ComponentModel.BackgroundWorker();
            this.addressBox1 = new System.Windows.Forms.ListBox();
            this.privatekeyBox1 = new System.Windows.Forms.ListBox();
            this.mnemonicBox1 = new System.Windows.Forms.ListBox();
            this.addressBox2 = new System.Windows.Forms.ListBox();
            this.privatekeyBox2 = new System.Windows.Forms.ListBox();
            this.mnemonicBox2 = new System.Windows.Forms.ListBox();
            this.addressBox3 = new System.Windows.Forms.ListBox();
            this.privatekeyBox3 = new System.Windows.Forms.ListBox();
            this.mnemonicBox3 = new System.Windows.Forms.ListBox();
            this.addressBox = new System.Windows.Forms.ListBox();
            this.privatekeyBox = new System.Windows.Forms.ListBox();
            this.mnemonicBox = new System.Windows.Forms.ListBox();
            this.walletGenerator3 = new System.ComponentModel.BackgroundWorker();
            this.walletGenerator4 = new System.ComponentModel.BackgroundWorker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 130;
            // 
            // url
            // 
            this.url.Text = "URL";
            this.url.Width = 206;
            // 
            // api
            // 
            this.api.Text = "Api Key";
            this.api.Width = 145;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.url,
            this.api});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 97);
            this.listView1.TabIndex = 157;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(489, 23);
            this.button1.TabIndex = 158;
            this.button1.Text = "Load Explorer Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(10, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 23);
            this.button4.TabIndex = 156;
            this.button4.Text = "Run";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 23);
            this.button2.TabIndex = 159;
            this.button2.Text = "Add Chain Explorer Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 160;
            this.textBox1.Text = "BSCScan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 161;
            this.textBox2.Text = "https://api.bscscan.com/api";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 162;
            this.textBox3.Text = "yourapikey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 163;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 164;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 165;
            this.label3.Text = "Api";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(259, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 166;
            this.button3.Text = "Remove Selected Chain";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(10, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(489, 23);
            this.button5.TabIndex = 167;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // walletGenerator1
            // 
            this.walletGenerator1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.walletGenerator1_DoWork);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(256, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 23);
            this.button6.TabIndex = 168;
            this.button6.Text = "Background Run";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // foundBox
            // 
            this.foundBox.FormattingEnabled = true;
            this.foundBox.Location = new System.Drawing.Point(13, 462);
            this.foundBox.Margin = new System.Windows.Forms.Padding(2);
            this.foundBox.Name = "foundBox";
            this.foundBox.Size = new System.Drawing.Size(978, 69);
            this.foundBox.TabIndex = 171;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressCountLabel1,
            this.addressCountLabel2,
            this.addressCountLabel3,
            this.addressCountLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 25);
            this.toolStrip1.TabIndex = 173;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addressCountLabel1
            // 
            this.addressCountLabel1.Name = "addressCountLabel1";
            this.addressCountLabel1.Size = new System.Drawing.Size(138, 22);
            this.addressCountLabel1.Text = "Worker1 Address Count: ";
            // 
            // addressCountLabel2
            // 
            this.addressCountLabel2.Name = "addressCountLabel2";
            this.addressCountLabel2.Size = new System.Drawing.Size(138, 22);
            this.addressCountLabel2.Text = "Worker2 Address Count: ";
            // 
            // addressCountLabel3
            // 
            this.addressCountLabel3.Name = "addressCountLabel3";
            this.addressCountLabel3.Size = new System.Drawing.Size(138, 22);
            this.addressCountLabel3.Text = "Worker3 Address Count: ";
            // 
            // addressCountLabel4
            // 
            this.addressCountLabel4.Name = "addressCountLabel4";
            this.addressCountLabel4.Size = new System.Drawing.Size(138, 22);
            this.addressCountLabel4.Text = "Worker4 Address Count: ";
            // 
            // walletGenerator2
            // 
            this.walletGenerator2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.walletGenerator2_DoWork);
            // 
            // addressBox1
            // 
            this.addressBox1.FormattingEnabled = true;
            this.addressBox1.Location = new System.Drawing.Point(504, 133);
            this.addressBox1.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(487, 43);
            this.addressBox1.TabIndex = 176;
            // 
            // privatekeyBox1
            // 
            this.privatekeyBox1.Location = new System.Drawing.Point(504, 86);
            this.privatekeyBox1.Margin = new System.Windows.Forms.Padding(2);
            this.privatekeyBox1.Name = "privatekeyBox1";
            this.privatekeyBox1.Size = new System.Drawing.Size(487, 43);
            this.privatekeyBox1.TabIndex = 175;
            // 
            // mnemonicBox1
            // 
            this.mnemonicBox1.FormattingEnabled = true;
            this.mnemonicBox1.Location = new System.Drawing.Point(504, 39);
            this.mnemonicBox1.Margin = new System.Windows.Forms.Padding(2);
            this.mnemonicBox1.Name = "mnemonicBox1";
            this.mnemonicBox1.Size = new System.Drawing.Size(487, 43);
            this.mnemonicBox1.TabIndex = 174;
            // 
            // addressBox2
            // 
            this.addressBox2.FormattingEnabled = true;
            this.addressBox2.Location = new System.Drawing.Point(504, 274);
            this.addressBox2.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox2.Name = "addressBox2";
            this.addressBox2.Size = new System.Drawing.Size(487, 43);
            this.addressBox2.TabIndex = 179;
            // 
            // privatekeyBox2
            // 
            this.privatekeyBox2.Location = new System.Drawing.Point(504, 227);
            this.privatekeyBox2.Margin = new System.Windows.Forms.Padding(2);
            this.privatekeyBox2.Name = "privatekeyBox2";
            this.privatekeyBox2.Size = new System.Drawing.Size(487, 43);
            this.privatekeyBox2.TabIndex = 178;
            // 
            // mnemonicBox2
            // 
            this.mnemonicBox2.FormattingEnabled = true;
            this.mnemonicBox2.Location = new System.Drawing.Point(504, 180);
            this.mnemonicBox2.Margin = new System.Windows.Forms.Padding(2);
            this.mnemonicBox2.Name = "mnemonicBox2";
            this.mnemonicBox2.Size = new System.Drawing.Size(487, 43);
            this.mnemonicBox2.TabIndex = 177;
            // 
            // addressBox3
            // 
            this.addressBox3.FormattingEnabled = true;
            this.addressBox3.Location = new System.Drawing.Point(504, 415);
            this.addressBox3.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox3.Name = "addressBox3";
            this.addressBox3.Size = new System.Drawing.Size(487, 43);
            this.addressBox3.TabIndex = 182;
            // 
            // privatekeyBox3
            // 
            this.privatekeyBox3.Location = new System.Drawing.Point(504, 368);
            this.privatekeyBox3.Margin = new System.Windows.Forms.Padding(2);
            this.privatekeyBox3.Name = "privatekeyBox3";
            this.privatekeyBox3.Size = new System.Drawing.Size(487, 43);
            this.privatekeyBox3.TabIndex = 181;
            // 
            // mnemonicBox3
            // 
            this.mnemonicBox3.FormattingEnabled = true;
            this.mnemonicBox3.Location = new System.Drawing.Point(504, 321);
            this.mnemonicBox3.Margin = new System.Windows.Forms.Padding(2);
            this.mnemonicBox3.Name = "mnemonicBox3";
            this.mnemonicBox3.Size = new System.Drawing.Size(487, 43);
            this.mnemonicBox3.TabIndex = 180;
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(13, 415);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(487, 43);
            this.addressBox.TabIndex = 185;
            // 
            // privatekeyBox
            // 
            this.privatekeyBox.Location = new System.Drawing.Point(13, 368);
            this.privatekeyBox.Margin = new System.Windows.Forms.Padding(2);
            this.privatekeyBox.Name = "privatekeyBox";
            this.privatekeyBox.Size = new System.Drawing.Size(487, 43);
            this.privatekeyBox.TabIndex = 184;
            // 
            // mnemonicBox
            // 
            this.mnemonicBox.FormattingEnabled = true;
            this.mnemonicBox.Location = new System.Drawing.Point(13, 321);
            this.mnemonicBox.Margin = new System.Windows.Forms.Padding(2);
            this.mnemonicBox.Name = "mnemonicBox";
            this.mnemonicBox.Size = new System.Drawing.Size(487, 43);
            this.mnemonicBox.TabIndex = 183;
            // 
            // walletGenerator3
            // 
            this.walletGenerator3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.walletGenerator3_DoWork);
            // 
            // walletGenerator4
            // 
            this.walletGenerator4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.walletGenerator4_DoWork);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(488, 20);
            this.textBox4.TabIndex = 186;
            this.textBox4.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 541);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.privatekeyBox);
            this.Controls.Add(this.mnemonicBox);
            this.Controls.Add(this.addressBox3);
            this.Controls.Add(this.privatekeyBox3);
            this.Controls.Add(this.mnemonicBox3);
            this.Controls.Add(this.addressBox2);
            this.Controls.Add(this.privatekeyBox2);
            this.Controls.Add(this.mnemonicBox2);
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.privatekeyBox1);
            this.Controls.Add(this.mnemonicBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.foundBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WalletHunter: Bulk Wallet Generator & Wallet Balance Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.ColumnHeader api;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker walletGenerator1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox foundBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.ComponentModel.BackgroundWorker walletGenerator2;
        private System.Windows.Forms.ListBox addressBox1;
        private System.Windows.Forms.ListBox privatekeyBox1;
        private System.Windows.Forms.ListBox mnemonicBox1;
        private System.Windows.Forms.ListBox addressBox2;
        private System.Windows.Forms.ListBox privatekeyBox2;
        private System.Windows.Forms.ListBox mnemonicBox2;
        private System.Windows.Forms.ListBox addressBox3;
        private System.Windows.Forms.ListBox privatekeyBox3;
        private System.Windows.Forms.ListBox mnemonicBox3;
        private System.Windows.Forms.ListBox addressBox;
        private System.Windows.Forms.ListBox privatekeyBox;
        private System.Windows.Forms.ListBox mnemonicBox;
        private System.ComponentModel.BackgroundWorker walletGenerator3;
        private System.Windows.Forms.ToolStripLabel addressCountLabel1;
        private System.Windows.Forms.ToolStripLabel addressCountLabel4;
        private System.ComponentModel.BackgroundWorker walletGenerator4;
        private System.Windows.Forms.ToolStripLabel addressCountLabel2;
        private System.Windows.Forms.ToolStripLabel addressCountLabel3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

