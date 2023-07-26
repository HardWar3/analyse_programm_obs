using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace analyse_programm_obs
{
    internal class Cpu
    {

        /*
         * name
         * usage
         * 
         * get_usage
         * get_name
         */

        private ManagementObjectSearcher information = new ManagementObjectSearcher("select * from Win32_Processor");
        private PerformanceCounter usage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private List<double> usage_list = new List<double>();

        public double get_usage()
        {
            float first_cpu_usage_value = usage.NextValue();

            System.Threading.Thread.Sleep(1000);

            return usage.NextValue();
        }

        public string get_name()
        {
            string cpu_name = null;

            foreach (ManagementObject item in information.Get())
            {
                cpu_name = item["Name"].ToString();
            }

            return cpu_name;
        }

        public void add_peak()
        {
            double peak = get_usage();

            usage_list.Add(peak);
        }

        public List<double> get_usage_list()
        {
            return usage_list;
        }
    }
}
