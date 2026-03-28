using System;
using System.Collections.Generic;
using System.Text;

namespace MOD4_103022400143
{
    internal class MesinKopi
    {
        private string status;

        public MesinKopi() {

            status = "OFF";
        }

        public void PowerOn() {
            if (status == "OFF")
            {
                Console.WriteLine("Mesin Off Berubah Menjadi Stanby");
            }
            else {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "STANDBY";
        }

        public void StartBrewing() {
            if (status == "STANDBY")
            {
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                status = "BREWING";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "BREWING";
        }

        public void FinishBrewing() {
            if (status == "BREWING")
            {
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                status = "STANBY";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "STANDBY";
        }

        public void StartMaintenance() {
            if (status == "STANDBY")
            {
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                status = "MAINTENANCE";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "MAINTENANCE";
        }

        public void FinishMaintenance()
        {
            if (status == "MAINTENANCE")
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                status = "STANDBY";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "STANDBY";
        }

        public void PowerOff()
        {
            if (status == "STANDBY")
            {
                Console.WriteLine("Mesin Standby berubah menjadi Off");
                status = "OFF";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }

            status = "STANDBY";
        }

        public void gagal() {
            if (status == "B")
            {
                Console.WriteLine("Mesin Standby berubah menjadi Off");
                status = "OFF";
            }
            else
            {
                Console.WriteLine("Perubahan Status Tidak Valid");
            }
        }
    }
}
