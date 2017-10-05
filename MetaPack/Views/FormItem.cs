using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetaPack.Views
{
    public partial class FormItem : Form
    {

        public string ItemName 
        {
            get { return textBoxName.Text; }
        }

        public string Price
        {
            get { return textBoxPrice.Text; }
        }


        public FormItem()
        {
            InitializeComponent();
        }
    }
}
