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
            this.Preview = new System.Windows.Forms.GroupBox();
            this.webpreview = new System.Windows.Forms.WebBrowser();
            this.Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview.Controls.Add(this.webpreview);
            this.Preview.Location = new System.Drawing.Point(12, 12);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(260, 100);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            // 
            // webpreview
            // 
            this.webpreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webpreview.Location = new System.Drawing.Point(3, 17);
            this.webpreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webpreview.Name = "webpreview";
            this.webpreview.Size = new System.Drawing.Size(254, 80);
            this.webpreview.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Preview);
            this.Name = "MainForm";
            this.Text = "LatexHelper";
            this.Preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Preview;
        private System.Windows.Forms.WebBrowser webpreview;
    }
}

