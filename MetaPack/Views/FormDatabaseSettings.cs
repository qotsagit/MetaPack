
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetaPack.Common;

namespace MetaPack
{
    public partial class FormDatabaseSettings : Form
    {
        public FormDatabaseSettings()
        {
            InitializeComponent();
            buttonOk.Enabled = false;
            Read();
        }

        private void Read()
        {
            Host.Text = Settings.Host;
            DatabaseName.Text = Settings.DatabaseName;
            User.Text = Settings.User;
            Password.Text = Settings.Password;
            Port.Text = Settings.Port.ToString();

        }

        public void Write()
        {
            Settings.Host = Host.Text;
            Settings.DatabaseName = DatabaseName.Text;
            Settings.User = User.Text;
            Settings.Password = Password.Text;
            Settings.Port = Convert.ToInt32(Port.Text);

            Settings.Save();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Database Database = new Database();
            Database.Host = Host.Text;
            Database.DatabaseName = DatabaseName.Text;
            Database.User = User.Text;
            Database.Password = Password.Text;
            Database.Port = Convert.ToInt32(Port.Text);

            if (Database.TestConnection())
            {
                buttonOk.Enabled = true;
            }
            else
            {
                buttonOk.Enabled = false;
            }

            Database.Close();
        }
    }
}
