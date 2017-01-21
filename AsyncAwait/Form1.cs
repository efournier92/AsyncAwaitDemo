using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CallBigMethod();
            label1.Text = @"Executing...";
        }

        private async void CallBigMethod()
        {
            var result = await BigLongMethodAsync("John");
            label1.Text = result;
        }

        private static Task<string> BigLongMethodAsync(string name)
        {
            return Task.Factory.StartNew(() => BigLongMethod(name));
        }

        private static string BigLongMethod(string name)
        {
            Thread.Sleep(5000);
            return "Hello " + name;
        }
    }
}
