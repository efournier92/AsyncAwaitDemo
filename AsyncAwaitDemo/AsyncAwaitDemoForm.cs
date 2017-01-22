using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitDemo
{
    public partial class AsyncAwaitDemoForm : Form
    {
        public AsyncAwaitDemoForm()
        {
            InitializeComponent();
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = TimeoutMethod("Synchronous");
        }

        private static string TimeoutMethod(string strategy)
        {
            Thread.Sleep(5000);
            return strategy + " Complete";
        }

        private void Async_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => TimeoutMethod("Async")).ContinueWith(t => StatusLabel.Text = )
        }


        private void AsyncAwaitDemoForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
