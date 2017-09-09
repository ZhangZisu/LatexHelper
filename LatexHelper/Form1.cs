using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace LatexHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var fs = new FileStream("latex_preview.html", FileMode.Create))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.Write("There is no Latex formula now...");
                }
            }
            string path = Application.StartupPath;
            webpreview.Url = new Uri("file://" + path + "/latex_preview.html");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            File.Delete("latex_preview.html");
            base.OnClosing(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                source.Text = Clipboard.GetText();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process_formula();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            process_formula();
        }

        private void process_formula()
        {
            string st = source.Text;
            if (st.StartsWith(@"\[") && st.EndsWith(@"\]"))
            {
                string tex = st.Substring(2, st.Length - 4);
                latex.Text = tex;
                using (var fs = new FileStream("latex_preview.html", FileMode.Create))
                {
                    using (var writer = new StreamWriter(fs))
                    {
                        writer.Write(Resource1.HTMLHead);
                        writer.Write(latex.Text);
                        writer.Write(Resource1.HTMLEnd);
                    }
                }
                webpreview.Refresh();
            }
            else
            {
                latex.Text = "The clipboard is empty or does not contain legal formulas.";
            }
        }
    }
}
