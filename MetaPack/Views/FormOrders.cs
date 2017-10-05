using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetaPack.Models;

namespace MetaPack.Views
{
    public partial class FormOrders : Form
    {
        private Orders Orders;
        public FormOrders()
        {
            InitializeComponent();
            Init();
        }

        private void Init() 
        {
            Orders = new Orders();
            Orders.Read();

            listOrders.DataSource = Orders;
        }
    }
}
