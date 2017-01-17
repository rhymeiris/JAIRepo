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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            IntPtr hWnd = new IntPtr(AppScreenCapture.AppScreenCapture.FindWindow(null, "카카오톡"));
            AppScreenCapture.AppScreenCapture.PrintW(hWnd);

            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString() + "ms");
        }
    }
}
