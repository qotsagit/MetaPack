using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetaPack.Models;
using MetaPack.Views;

namespace MetaPack
{
    public partial class UserControl1 : UserControl
    {

        //private FormMain FormMain = null;
        public Item Item = null;
        public FormMain FormMain = null;

        public bool Exists;
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.BorderStyle = IsSelected ? BorderStyle.Fixed3D : BorderStyle.None;
            }
        }


        public UserControl1()
        {
            InitializeComponent();
            Enabled = true;
        }

        public void UpdateControls()
        {
            UpdateData();
        }

        void UpdateData()
        {
            buttonName.Text = Item.Name;
            labelPrice.Text = string.Format("{0:N}", Item.Price);
            this.labelPrice.Cursor = Cursors.Hand;

            //Price is 0 then you can not order this item
            if (Item.Price == 0)
            {
                labelPrice.Text = "";
                labelPrice.Click -= labelPrice_Click;
                this.labelPrice.Cursor = Cursors.Arrow;
            }
           
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            FormMain.SetSelectedItem(Item);
            FormMain.UpdateDataAndControls(); 
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {
            FormMain.AddToOrder(Item);
        }

    }
}
