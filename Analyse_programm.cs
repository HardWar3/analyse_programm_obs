using Microsoft.SqlServer.Server;
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

namespace analyse_programm_obs
{
    public partial class Analyse_programm : Form
    {

        private Cpu cpu = new Cpu();
        private Gpu gpu = new Gpu();
        private Ram ram = new Ram();

        public Analyse_programm()
        {
            InitializeComponent();
        }

        private void Analyse_programm_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Thread keks_thread = new Thread(new ThreadStart(keks));
            keks_thread.Start();

            cpu_prozessbar.Value = cpu.get_last_peak();
            cpu_usage_label.Text = String.Format("{0:00} %", cpu_prozessbar.Value);

            ram_progressbar.Value = ram.get_last_usage_peak();
            ram_usage_label.Text = String.Format("{0:00} %", ram_progressbar.Value);

            gpu_progressbar.Value = gpu.get_last_peak();
            gpu_usage_label.Text = String.Format("{0:00} %", gpu_progressbar.Value);
        }

        private void start_stop_button_Click(object sender, EventArgs e)
        {
            if (start_stop_button.Text == "Start")
            {
                start_stop_button.Text = "Stop";
            } else if(start_stop_button.Text == "Stop")
            {
                start_stop_button.Text = "Start";
            }
        }

        public void keks()
        {
            cpu.add_peak();
            ram.add_peak();
            gpu.add_peak();
            Console.WriteLine("KRÜMMELN");
        }
    }
}
