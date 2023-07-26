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
            Point label_safe = label2.Parent.PointToScreen(label2.Location);
            // Point label_safe = label2.PointToScreen(Point.Empty);
            label2.Parent = cpu_prozessbar;
            label2.Location = cpu_prozessbar.PointToClient(label_safe);
            label2.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cpu_prozessbar.Value = Convert.ToInt32(cpu.get_usage());
            Console.WriteLine(cpu_prozessbar.Value);
            label2.Text = String.Format("{0:00}%", cpu_prozessbar.Value);
            label2.BackColor = Color.Transparent;
        }
    }
}
