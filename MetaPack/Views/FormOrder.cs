using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetaPack.Models;
using MetaPack.Common;

namespace MetaPack.Views
{
    public partial class FormOrder : Form
    {
        private Order Order{get; set;}
        public FormOrder(Order order)
        {
            Order = order;
            InitializeComponent();
            Init();
           
        }

        public void Init() 
        {
            textOrderName.Text = Order.Name;
            listOrderItems.DataSource = Order.OrderItems;
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            string order = Order.Name + "\n";
 
            foreach(OrderItem OrderItem in Order.OrderItems)
            {
                order += OrderItem.Name + " " + OrderItem.Price + "\n";
            }

            SMTP Smtp = new SMTP();
            try
            {
                Smtp.SendOrderEmail(Order.Name, order);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Email was send");
        }
    }
}
