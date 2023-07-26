using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace analyse_programm_obs
{
    internal class Ram
    {
        /*
         * name
         * usage
         * 
         * get_usage
         * get_available
         * get_total
         * get_name
         */

        private ManagementObjectSearcher ram_information = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
        private PerformanceCounter ram_usage = new PerformanceCounter("Memory", "Available MBeytes");

        public double get_usage()
        {
            double total = get_total();
            double available = get_available();

            double result = Math.Round(total - available,2);

            return result;
        }

        public double get_available ()
        {
            float first_ram_usage_value = ram_usage.NextValue();

            System.Threading.Thread.Sleep(1000);

            double ram_available = Convert.ToUInt32(ram_usage.NextValue()) / 1000.0; // 1000.0 führt zur korrekten kommerstelle

            ram_available = Math.Round(ram_available / 1.074,2); // Gigabyte zu Gibibyte Umrechnung

            return ram_available;
        }

        public double get_available_prozent ()
        {
            double total = get_total();
            double available = get_available();

            double result = Math.Round(available / (total / 100),2);

            return result;
        }
        
        public double get_total ()
        {
            double total = 0;

            foreach (ManagementObject item in ram_information.Get())
            {
                total += Convert.ToDouble(item["Capacity"]) / 1000000000; // 1000000000 führt zur korrekten kommerstelle
            }

            total = Math.Round(total / 1.074,2); // Gigabyte zu Gibibyte Umrechnung

            return total;
        }

        public string get_name()
        {
            string ram_name = null;

            foreach (ManagementObject item in ram_information.Get())
            {
                ram_name = item["ManuFacturer"].ToString();
            }

            return ram_name;
        }
    }
}
