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

        ManagementObjectSearcher gpu_information = new ManagementObjectSearcher("select * from Win32_VideoController");
        ManagementObjectSearcher gpu_usage = new ManagementObjectSearcher("select * from " +
            "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine where Name LIKE '%engtype_3D'");

        public double get_usage ()
        {
            double gpu_counter = 0;

            System.Threading.Thread.Sleep(1000);

            foreach (ManagementObject item in gpu_usage.Get())
            {
                gpu_counter += Convert.ToDouble(item["UtilizationPercentage"]);
            }

            return gpu_counter;
        }

        public string get_name ()
        {
            string gpu_name = null;

            foreach (ManagementObject item in gpu_information.Get())
            {
                gpu_name = item["Name"].ToString();
            }

            return gpu_name;
        }
    }
}
