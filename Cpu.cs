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

        private ManagementObjectSearcher cpu_information = new ManagementObjectSearcher("select * from Win32_Processor");
        private PerformanceCounter cpu_usage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public double get_usage()
        {
            float first_cpu_usage_value = cpu_usage.NextValue();

            System.Threading.Thread.Sleep(1000);

            return cpu_usage.NextValue();
        }

        public string get_name()
        {
            string cpu_name = null;

            foreach (ManagementObject item in cpu_information.Get())
            {
                cpu_name = item["Name"].ToString();
            }

            return cpu_name;
        }
    }
}
