using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetaPack.Common
{
    public class Config
    {
        public enum Deleted { False = 0 , True = 1 }
        public enum Active { False = 0, True = 1 }
        public enum Status { Waiting = 0, During = 1, Completed = 2, Error = 3}
        
        //Form metrics
        public static int DefaultFormMainWidth = 500;
        public static int DefaultFormMainHeight = 400;
        public static int DefaultFormMainLocationX = 0;
        public static int DefaultFormMainLocationY = 0;
        public static int DefaultFormMainWindowState = 2;

        //MySQL Database defaults
        public static string DefaultHost = "127.0.0.1";
        public static string DefaultDatabaseName = "SAD";
        public static int DefaultPort = 3306;
            
        //SMTP defaults
        public static int DefaultSMTPPort = 587;
        public static string DefaultSMTPUser = "";
        public static string DefaultSMTPPassword ="";
        public static string DefaultSMTPHost = "";
        public static string DefaultSMTPEmailTo ="";
        public static string DefaultSMTPEmailFrom ="";
    }
}
