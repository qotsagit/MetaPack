
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetaPack.Common;
using System.Net.Mail;

namespace MetaPack
{
    public partial class FormSMTPSettings : Form
    {
        public FormSMTPSettings()
        {
            InitializeComponent();
            buttonOk.Enabled = false;
            Read();
        }

        private void Read()
        {
            textEmailFrom.Text = Settings.SMTPEmailFrom;
            textEmailTo.Text = Settings.SMTPEmailTo;
            textHost.Text = Settings.SMTPHost;
            textUser.Text = Settings.SMTPUser;
            textPassword.Text = Settings.SMTPPassword;
            textPort.Text = Settings.SMTPPort.ToString();

        }

        public void Write()
        {
            Settings.SMTPEmailFrom = textEmailFrom.Text;
            Settings.SMTPEmailTo = textEmailTo.Text;
            Settings.SMTPHost = textHost.Text;
            Settings.SMTPUser = textUser.Text;
            Settings.SMTPPassword = textPassword.Text;
            Settings.SMTPPort = Convert.ToInt32(textPort.Text);

            Settings.Save();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SMTP Smtp = new SMTP();
            Smtp.Host = textHost.Text;
            Smtp.Credentials = new System.Net.NetworkCredential(textUser.Text,textPassword.Text);
            Smtp.Port = int.Parse(textPort.Text);
            
            try 
            {
        
                Smtp.SendTestEmail(textEmailFrom.Text, textEmailTo.Text);
                buttonOk.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonOk.Enabled = false;
            }
            
            
        }

    }
}
