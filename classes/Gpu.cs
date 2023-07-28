using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace analyse_programm_obs
{
    internal class Gpu
    {
        private ManagementObjectSearcher information = new ManagementObjectSearcher("select * from Win32_VideoController");
        private ManagementObjectSearcher usage = new ManagementObjectSearcher("select * from " +
            "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine where Name LIKE '%engtype_3D'");

        private List<double> usage_list = new List<double>();

        public int get_usage()
        {
            int gpu_counter = 0;

            //System.Threading.Thread.Sleep(100);

           foreach (ManagementObject item in usage.Get())
            {
                gpu_counter += Convert.ToInt32(item["UtilizationPercentage"]);
            }

            return gpu_counter;
        }

        public string get_name()
        {
            string gpu_name = null;

            foreach (ManagementObject item in information.Get())
            {
                gpu_name = item["Name"].ToString();
            }

            return gpu_name;
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

        public List<double> get_peak_in_list()
        {
            return usage_list;
        }

        public int get_last_peak()
        {
            if (usage_list.Count == 0)
            {
                return 0;
            }
            double last_peak = usage_list.Last();

            return (int)last_peak;
        }
    }
}
