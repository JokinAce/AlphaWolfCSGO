using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Menu {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            if (CheckIDS()) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Menu());
            } else {
                DialogResult result = MessageBox.Show("Go fuck yourself.", "Unknown User", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes) {
                    Process.Start("https://www.google.com/search?&q=how+to+fuck+myself&oq=how+to+fuck+myself");
                }
            }
        }


        // DO DO LIST
        //Let User choose CPU to thread or not

        private static bool CheckIDS() {
            //Processor ID
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string CPUID = "None";
            foreach (ManagementObject mo in mbsList) {
                CPUID = mo["ProcessorID"].ToString();
            }

            ////HardDisk
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            string HardDiskID = dsk["VolumeSerialNumber"].ToString();

            string[] AllowedCPUs = { "BFEBFBFF000506E3", "178BFBFF00800F82", "BFEBFBFF000306A9" };
            string[] AllowedHDIDs = { "5AF74EB9", "82A11A0D", "2C4F2A70" };
            // ME, TwoSnecc, Alex

            bool CPUCheck = false;
            bool HDIDCheck = false;

            for (int i = 0; i < AllowedCPUs.Length; i++) {
                if (CPUID == AllowedCPUs[i]) {
                    CPUCheck = true;
                }

                if (HardDiskID == AllowedHDIDs[i]) {
                    HDIDCheck = true;
                }
            }
            return CPUCheck & HDIDCheck;
        }
    }
}