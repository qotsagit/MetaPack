using System;
using System.Data;
using MetaPack.Common;
using MetaPack.Views;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace MetaPack.Common
{
    public class Database
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public string Charset { get; set; }
        public string LastErrorMessage { get; set; }
        private string connectionString { get; set; }
        public static string StaticConnectionString { get; set; }

        
        SqlCeConnection SqlConnection;
        SqlCeCommand SqlCommand;
        SqlCeDataReader SqlDataReader;

        public Database()
        {
            //SetSettings();
            ReadSettings();

            // Bardzo ważna linijka kodu
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Bez niej nie działa sterownik bazy
            // Występują wyjątki o kodowaniu itp... 
            SqlConnection = new SqlCeConnection();
            SqlCommand = new SqlCeCommand();
            SqlCommand.Connection = SqlConnection;

        }

        public void ReadSettings()
        {
            Host = Settings.Host;
            DatabaseName = Settings.DatabaseName;
            User = Settings.User;
            Password = Settings.Password;
            Port = Settings.Port;
        }

        public bool TestConnection()
        {
            return Connect();
        }

        private bool Connect()
        {

            if (SqlConnection.State == ConnectionState.Closed)
            {
                try
                {

                    string connectionString = "Data Source=Data\\MyDatabase.sdf";
                    SqlConnection.ConnectionString = connectionString;
                    SqlConnection.Open();

                }
                catch (SqlCeException ex)
                {
                    LastErrorMessage = ex.Message;
                    ShowErrorMessage();
                    return false;
                }
            }
            
           

            return true;
        }

        private bool CommandQuery(string sql)
        {

            try
            {
                //MySqlCommand = new MySqlCommand(sql, MySqlConnection);     
                //MySqlCommand.   
                SqlCommand.CommandText = sql;
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                ShowErrorMessage();
                return false;
            }

            return true;

        }

        private bool CommandNonQuery(string sql)
        {
            try
            {
                SqlCommand.CommandText = sql;
                SqlCommand.ExecuteNonQuery();       
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                ShowErrorMessage();
                return false;
            }

            return true;
        }

        private void ShowErrorMessage()
        {
            
            FormMain MainPage = FormMain.MainForm;
            if (MainPage == null)
            {
                MessageBox.Show("Error\n" + LastErrorMessage);
                //dlg.Options = MessageDialogOptions.
                //await dlg.ShowAsync();
            }
            else
            {
                MainPage.NotifyUser("Error\n" + LastErrorMessage, NotifyType.ErrorMessage);
            }

            //MessageDialog dlg = new MessageDialog("Error\n" + LastErrorMessage);
            //dlg.Options = MessageDialogOptions.
            //await dlg.ShowAsync();

             
        }

        public bool Read()
        {
            return SqlDataReader.Read();
        }

        public SqlCeDataReader GetRow()
        {
            return SqlDataReader;
        }

        public void FreeResult()
        {
            SqlDataReader.Close();
        }

        public void Close()
        {
            SqlConnection.Close();
            if (SqlDataReader != null)
            {
                this.FreeResult();
            }
        }

        public void AddParameter(SqlCeParameter param)
        {
            SqlCommand.Parameters.Add(param);
        }

        public void ClearParameter()
        {
            SqlCommand.Parameters.Clear();
        }

        public bool NonQuery(string sql)
        {
            if (Connect() == false)
                return false;
            
            if (CommandNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Query(string sql)
        {

            if (Connect() == false)
                return false;

            if (CommandQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
