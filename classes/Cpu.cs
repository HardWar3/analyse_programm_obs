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
        private ManagementObjectSearcher information = new ManagementObjectSearcher("select * from Win32_Processor");
        private PerformanceCounter usage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private List<int> usage_list = new List<int>();

        public int get_usage()
        { 
            float first_cpu_usage_value = usage.NextValue();

            System.Threading.Thread.Sleep(200);

            return Convert.ToInt32(usage.NextValue());
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

        public void add_peak(int peak = -1)
        {
            if (peak < 0)
            {
                int _peak = get_usage();

                usage_list.Add(_peak);
            } else
            {
                usage_list.Add(peak);
            }

        }

        public List<int> get_usage_list()
        {
            return usage_list;
        }

        public int get_last_peak() 
        {
            if (usage_list.Count == 0)
            {
                return 0;
            }
            int last_peak = usage_list.Last();

            return last_peak;
        }
    }
}
