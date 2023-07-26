using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analyse_programm_obs
{
    public partial class Analyse_programm : Form
    {

        private Cpu cpu = new Cpu();

        public Analyse_programm()
        {
            InitializeComponent();
        }

        private void Analyse_programm_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cpu_prozessbar.Value = Convert.ToInt32(cpu.get_usage());
            Console.WriteLine(cpu_prozessbar.Value);
            cpu_usage.Text = String.Format("{0:00}%", cpu_prozessbar.Value);
            cpu_usage.BackColor = Color.Transparent;
        }
    }
}
