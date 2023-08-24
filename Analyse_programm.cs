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

        private static Cpu cpu = new Cpu();
        private static Gpu gpu = new Gpu();
        private static Ram ram = new Ram();
        private static int count_on_start = 0;
        private static int count_on_stop = 0;
        public Analyse_programm()
        {
            InitializeComponent();
        }

        private void Analyse_programm_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Task task_all_add_peak = new Task(() => all_add_peak());
            task_all_add_peak.Start();

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
                start_stop_button.BackColor = Color.DarkRed;

                count_on_start = cpu.get_usage_list().Count;
            } else if(start_stop_button.Text == "Stop")
            {
                start_stop_button.Text = "Start";
                start_stop_button.BackColor = Color.DarkGreen;

                count_on_stop = cpu.get_usage_list().Count;
                Console.WriteLine("CPU AVG: " + cpu.get_usage_average(count_on_start,count_on_stop));
                Console.WriteLine("RAM AVG: " + ram.get_usage_average(count_on_start,count_on_stop));
                Console.WriteLine("GPU AVG: " + gpu.get_usage_average(count_on_start,count_on_stop));
            }
        }

        public void all_add_peak()
        {
            cpu.add_peak();
            ram.add_peak();
            gpu.add_peak();
        }
    }
}
