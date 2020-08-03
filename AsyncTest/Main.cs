using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    public partial class Main : Form
    {
        private readonly int Delay = 1000;

        public Main()
        {
            InitializeComponent();
        }

        // ASYNC
        private async void button_runTaskAsync_Click(object sender, EventArgs e)
        {
            AsyncTask();

            MessageBox.Show("Completed");
        }
        
        private async Task AsyncTask()
        {
            Thread.Sleep(Delay);
        }

        // NORMAL
        private void button_runTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lmao");
            string res = NormalTask();

            MessageBox.Show(res);
        }

        private string NormalTask()
        {
            Thread.Sleep(Delay);
            return "Task Complete!";
        }
    }
}
