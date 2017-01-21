using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => BigLongMethod("George")).ContinueWith(t => label1.Text = t.Result);
            //label1.Text = BigLongMethod("Ringo");
        }

        private string BigLongMethod(string name)
        {
            Thread.Sleep(2000);
            return "Hello " + name;
        }
    }
}
