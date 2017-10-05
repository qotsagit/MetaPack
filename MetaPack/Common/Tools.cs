using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace MetaPack.Common
{
    class Tools
    {
        
            public static string GetHardwareId()
            {

                //var mbs = new ManagementObjectSearcher("SELECT * FROM Win32_processor");
                //var mbs = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_OperatingSystem");

                //ManagementObjectCollection mbsList = mbs.Get();
                //foreach (ManagementObject mo in mbsList)
                //{
                  //  return mo["SerialNumber"].ToString();
                    //foreach (PropertyData pd in mo.Properties)
                      //  Console.WriteLine(pd.Name + '-' + pd.Value);
               // }

                return null;
            }
        
    }
}
