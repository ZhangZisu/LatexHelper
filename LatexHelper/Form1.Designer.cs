namespace LatexHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Preview = new System.Windows.Forms.GroupBox();
            this.webpreview = new System.Windows.Forms.WebBrowser();
            this.MemoryScanner = new System.Windows.Forms.GroupBox();
            this.latex = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settings = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Preview.SuspendLayout();
            this.MemoryScanner.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview.Controls.Add(this.webpreview);
            this.Preview.Location = new System.Drawing.Point(14, 17);
            this.Preview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Preview.Name = "Preview";
            this.Preview.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Preview.Size = new System.Drawing.Size(491, 124);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            // 
            // webpreview
            // 
            this.webpreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webpreview.Location = new System.Drawing.Point(3, 20);
            this.webpreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webpreview.MinimumSize = new System.Drawing.Size(23, 28);
            this.webpreview.Name = "webpreview";
            this.webpreview.Size = new System.Drawing.Size(485, 100);
            this.webpreview.TabIndex = 0;
            // 
            // MemoryScanner
            // 
            this.MemoryScanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryScanner.Controls.Add(this.button1);
            this.MemoryScanner.Controls.Add(this.source);
            this.MemoryScanner.Controls.Add(this.latex);
            this.MemoryScanner.Location = new System.Drawing.Point(14, 149);
            this.MemoryScanner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemoryScanner.Name = "MemoryScanner";
            this.MemoryScanner.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemoryScanner.Size = new System.Drawing.Size(491, 254);
            this.MemoryScanner.TabIndex = 1;
            this.MemoryScanner.TabStop = false;
            this.MemoryScanner.Text = "Memory monitoring";
            // 
            // latex
            // 
            this.latex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latex.Location = new System.Drawing.Point(7, 28);
            this.latex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.latex.Multiline = true;
            this.latex.Name = "latex";
            this.latex.Size = new System.Drawing.Size(476, 83);
            this.latex.TabIndex = 0;
            // 
            // source
            // 
            this.source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source.Location = new System.Drawing.Point(7, 122);
            this.source.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.source.Multiline = true;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(476, 80);
            this.source.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(7, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(477, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Controls.Add(this.checkBox2);
            this.settings.Controls.Add(this.checkBox1);
            this.settings.Location = new System.Drawing.Point(14, 410);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(491, 51);
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            this.settings.Text = "settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(122, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Auto preview";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 473);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.MemoryScanner);
            this.Controls.Add(this.Preview);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "LatexHelper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Preview.ResumeLayout(false);
            this.MemoryScanner.ResumeLayout(false);
            this.MemoryScanner.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Preview;
        private System.Windows.Forms.WebBrowser webpreview;
        private System.Windows.Forms.GroupBox MemoryScanner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox latex;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer timer2;
    }
}

