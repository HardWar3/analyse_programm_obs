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
        /*
         * name
         * usage
         * 
         * get_usage
         * get_name
         */

        private ManagementObjectSearcher information = new ManagementObjectSearcher("select * from Win32_VideoController");
        private ManagementObjectSearcher usage = new ManagementObjectSearcher("select * from " +
            "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine where Name LIKE '%engtype_3D'");

        private List<double> usage_list = new List<double>();

        public double get_usage ()
        {
            double gpu_counter = 0;

            System.Threading.Thread.Sleep(1000);

            foreach (ManagementObject item in usage.Get())
            {
                gpu_counter += Convert.ToDouble(item["UtilizationPercentage"]);
            }

            return gpu_counter;
        }

        public string get_name ()
        {
            string gpu_name = null;

            foreach (ManagementObject item in information.Get())
            {
                gpu_name = item["Name"].ToString();
            }

            return gpu_name;
        }

        public void add_peak()
        {
            double peak = get_usage();

            usage_list.Add(peak);
        }

        public List<double> get_peak_in_list()
        {
            return usage_list;
        }
    }
}
