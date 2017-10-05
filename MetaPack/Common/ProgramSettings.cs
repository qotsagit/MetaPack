using MetaPack.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPack.Common
{

    static class ProgramSettings
    {
        static Configuration Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        static AppSettingsSection Section = Configuration.AppSettings;

        static object Value;

        public static string Host
        {
            get { return GetString("Host", Config.DefaultHost); }
            set { SetString("Host", value); }
        }

        public static string DatabaseName
        {
            get { return GetString("DatabaseName", Config.DefaultDatabaseName); }
            set { SetString("DatabaseName", value); }
        }

        public static string User
        {
            get { return GetString("User", Config.DefaultDatabaseName); }
            set { SetString("User", value); }
        }

        public static string Password
        {
            get { return GetString("Password", Config.DefaultDatabaseName); }
            set { SetString("Password", value); }
        }

        public static int Port
        {
            get { return GetInt("Port", Config.DefaultPort); }
            set { SetInt("Port", value); }
        }

        public static int FormMainWidth
        {
            get { return GetInt("FormMainWidth", Config.DefaultFormMainWidth); }
            set { SetInt("FormMainWidth", value); }
        }

        public static int FormMainHeight
        {
            get { return GetInt("FormMainHeight",Config.DefaultFormMainHeight); }
            set { SetInt("FormMainHeight", value); }
        }

        public static int FormMainWindowState
        {
            get { return GetInt("FormMainWindowState",Config.DefaultFormMainWindowState); }
            set { SetInt("FormMainWindowState",value); }
        }


        public static int FormMainLocationX
        {
            get { return GetInt("FormMainLocationX",Config.DefaultFormMainLocationX ); }
            set { SetInt("FormMainLocationX", value); }
        }

        public static int FormMainLocationY
        {
            get { return GetInt("FormMainLocationY",Config.DefaultFormMainLocationY); }
            set { SetInt("FormMainLocationY", value); }
        }

        public static int TechnologyStepId
        {
            get { return GetInt("TechnologyStepId",Config.DefaultTechnologyStepId); }
            set { SetInt("TechnologyStepId",value); }
        }

        public static string TechnologyStepName
        {
            get { return GetString("TechnologyStepName", Config.DefaultDatabaseName); }
            set { SetString("TechnologyStepName", value); }
        }


        public static void Save()
        {
            Configuration.Save();
        }


        #region Helper

        private static int GetInt(string v, int d)
        {
            Value = Section.Settings[v];
            if (Value == null)
            {
                return d;
            }
            else
            {
                return int.Parse(Section.Settings[v].Value);
            }

        }

        private static string GetString(string v, string d)
        {
            Value = Section.Settings[v];
            if (Value == null)
            {
                return d;
            }
            else
            {
                return Section.Settings[v].Value;
            }

        }

        private static void SetInt(string k, int v)
        {
            if (Section.Settings[k] == null)
                Section.Settings.Add(k, v.ToString());
            else
                Section.Settings[k].Value = v.ToString();
        }

        private static void SetString(string k, string v)
        {
            if (Section.Settings[k] == null)
                Section.Settings.Add(k, v);
            else
                Section.Settings[k].Value = v;
        }
               
        #endregion
    }

}
