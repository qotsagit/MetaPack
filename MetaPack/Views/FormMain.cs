
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetaPack.Models;
using System.Drawing.Drawing2D;
using MetaPack.Common;

namespace MetaPack.Views
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        /// 
        public static FormMain MainForm;
        private Items Items { get; set;}
        private Order Order { get; set; }
        private Item SelectedItem   {get; set;}
        private const int ItemPadding = 5;

        public FormMain()
        {
            SelectedItem = new Item() { Id = 0, IdParent = 0 };
            MainForm = this;
            InitializeComponent();
            
            // init controls with start values
            InitControls();

            // Items View
            // init data model for items
            InitItemDataModel(); //before init listview
            //InitListItemView();

            ReadSettings();
            SetControls();
            //StartTicker();
            
        }
        //
        // Controls management
        //
        private void SetControls()
        {   
            SuspendLayout();
            AddParentControl();
            AddControls();
            ResumeLayout();
        }

        void AddParentControl() 
        {
            //Parent item
            // We are into subitem
            if (SelectedItem != null && SelectedItem.Id != 0)
            {
                UserControl1 UserControl = new UserControl1();
                UserControl.Exists = true;
                UserControl.Item = new Item() { Id = SelectedItem.IdParent, Name = "< Back" };
                UserControl.Margin = new Padding(ItemPadding);
                UserControl.UpdateControls();
                UserControl.FormMain = this;
                flowLayoutPanel.Controls.Add(UserControl);
            }
        }

        void AddControls() 
        {
            foreach (Item Item in Items)
            {
                UserControl1 UserControl = new UserControl1();
                //uc.Width = flowLayoutPanel.ClientSize.Width - ItemPadding * 2;
                UserControl.Margin = new Padding(ItemPadding);
                flowLayoutPanel.Controls.Add(UserControl);
              
                UserControl.Exists = true;
                UserControl.Item = Item;
                UserControl.FormMain = this;
                UserControl.UpdateControls();
            }
        }
        
        public void SetSelectedItem(Item item) 
        {
            SelectedItem = item;
        }
        
        public void UpdateDataAndControls()
        {
            ReadData();
            SetNotExists();
            SetControls();
            RemoveControls();
        }

        private void SetNotExists()
        {
            foreach (UserControl1 UserControl1 in flowLayoutPanel.Controls)
            {
                UserControl1.Exists = false;
            }
        }

        private void RemoveControls()
        {
            List<UserControl1> ToRemove = new List<UserControl1>();
            foreach (UserControl1 UserControl1 in flowLayoutPanel.Controls)
            {
                
                if (UserControl1.Exists == false)
                    ToRemove.Add(UserControl1);
                    
            }

            foreach(UserControl1 UserControl1 in ToRemove)
            {
                flowLayoutPanel.Controls.Remove(UserControl1);
            }

            ToRemove.Clear();
        }

        private UserControl1 ControlExists(Item step)
        {
            foreach (UserControl1 UserControl1 in flowLayoutPanel.Controls)
            {
                if (step.Id == UserControl1.Item.Id) //&& step.indx == UserControl1.ChartStepVM.indx)
                    return UserControl1;
            }

            return null;
        }


        private void InitControls() 
        {
            labelOrderPrice.Text = "0";
        }

        private void InitItemDataModel() 
        {
            Items = new Items();
            Items.Read();
        }
        
        private void DebugPrint(string text) 
        {
            textDebug.AppendText(text);
            textDebug.AppendText("\n");
        }
        
        #region events
        private void ordersToolStripTextBox1_Click(object sender, EventArgs e)
        {
            FormOrders FormOrders = new FormOrders();
            FormOrders.ShowDialog();

        }
        
        private void listItemView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {        
            e.Item = new ListViewItem(new[] { Items[e.ItemIndex].Name +"\n"+ Items[e.ItemIndex].Price.ToString(), Items[e.ItemIndex].Price.ToString(), "24" });
                //Items[e.ItemIndex].Name,0);
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormAboutBox About = new FormAboutBox();
            //About.ShowDialog();
        }

        private void databasesettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
            FormDatabaseSettings FormSettings = new FormDatabaseSettings();

            DialogResult = FormSettings.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                FormSettings.Write();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void listItemView_MouseClick(object sender, MouseEventArgs e)
        {
            /*
             if (e.Button == MouseButtons.Right)
             {
                 if (listIMenuView.FocusedItem.Bounds.Contains(e.Location) == true)
                 {
                     listViewMenu.Items[1].Enabled = true;
                     listViewMenu.Items[2].Enabled = true;
                     listViewMenu.Show(Cursor.Position);
                 }
                 else 
                 {
                     listViewMenu.Items[1].Enabled = false;
                     listViewMenu.Items[2].Enabled = false;
                     listViewMenu.Show(Cursor.Position);
                 }
             } 
             */

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int a = listIMenuView.FocusedItem.Index;
        }


        private void listItemView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SetSelectedItem();
        }

        void listItemView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void listItemView_DragDrop(object sender, DragEventArgs e)
        {
            // listView1.Items.Add(e.Data.ToString());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {

            return;
            flowLayoutPanel.SuspendLayout();

            foreach (Control ctrl in flowLayoutPanel.Controls)
            {
                ctrl.Width = flowLayoutPanel.ClientSize.Width - ItemPadding * 2;
                ctrl.Height = flowLayoutPanel.Height / 2;
                ctrl.Margin = new Padding(ItemPadding);
            }

            flowLayoutPanel.ResumeLayout();

        }


        private void listIMenuView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                //e.Bounds.Height = 100;
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                e.DrawFocusRectangle();
            }
            else
            {
                // Draw the background for an unselected item.
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);


                //e.Graphics.FillRectangle(brush, e.Bounds);

            }

            // Draw the item text for views other than the Details view.
            //if (listIMenuView.View != View.Details)
            //{
            //  e.DrawText();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items.Generate();
        }

        private void labelItemPrice_Click(object sender, EventArgs e)
        {
            if (Order != null)
            {
                FormOrder FormOrder = new FormOrder(Order);

                if (FormOrder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Order = null;
                    UpdateOrderPrice();
                }
            }

        }

        #endregion

        public void AddToOrder(Item item) 
        {
            if (Order == null) 
            {
                Order = new Order();
                Order.Name = "Order";
                Order.Insert();
                Order.Id = Order.GetMax();
            }

            OrderItem OrderItem = new OrderItem();
            OrderItem.IdOrder = Order.Id;
            OrderItem.Name = item.Name;
            OrderItem.Price = item.Price;
            OrderItem.Insert();

            Order.OrderItems.IdOrder = Order.Id;
            Order.OrderItems.Clear();
            Order.OrderItems.Read();

            UpdateOrderPrice();
        }

        private void UpdateOrderPrice() 
        {
            if(Order == null)
                labelOrderPrice.Text = "0";      
            else
                labelOrderPrice.Text = string.Format("{0:f}", Order.OrderItems.GetPrice());
        }

        private void StartTicker()
        {
            System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DebugPrint("Start Update");
            UpdateDataAndControls();
            DebugPrint("End Update");
        }

        private void ReadData()
        {
            if (SelectedItem == null)
            {
                Items.IdParent = 0;
            }
            else
            {
                Items.IdParent = SelectedItem.Id;
            }
            
            Items.Clear();
            Items.Read();
        }


        public void NotifyUser(string strMessage, NotifyType type)
        {
            //StatusTime = 0;
            Color Color = Color.Green;

            switch (type)
            {
                case NotifyType.StatusMessage:
                    Color = Color.Green;
                    break;
                case NotifyType.ErrorMessage:
                    Color = Color.Red;
                    break;
            }

            if (this.InvokeRequired == true)
            {

                //StatusText.Invoke((Action)delegate
                //{
                  //  StatusText.Text = strMessage;
                  //  StatusText.BackColor = Color;
                  //  StatusText.Visible = true;
                //});

            }
            else
            {

                //StatusText.BackColor = Color;
                //StatusText.Text = strMessage;
                //StatusText.Visible = true;

            }
        }

        #region settings

        private void ReadSettings()
        {
            this.Width = Settings.FormMainWidth;
            this.Height = Settings.FormMainHeight;
            this.Location = new Point(Settings.FormMainLocationX, Settings.FormMainLocationY);
            this.WindowState = (FormWindowState)Settings.FormMainWindowState;
        }

        private void WriteSettings()
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                Settings.FormMainWidth = this.Width;
                Settings.FormMainHeight = this.Height;
                Settings.FormMainLocationX = this.Location.X;
                Settings.FormMainLocationY = this.Location.Y;
            }

            Settings.FormMainWindowState = (int)this.WindowState;
            Settings.Save();
        }
        #endregion

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            FormItem FormItem = new FormItem();
            if (FormItem.ShowDialog() == DialogResult.OK)
            {
                Item Item = new Item();
                Item.Name = FormItem.ItemName;
                Item.Price = double.Parse(FormItem.Price);
                Item.IdParent = SelectedItem.Id;
                Item.Insert();

                UpdateDataAndControls();
                //Items.Clear();
                //Items.Read();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSMTPSettings FormSMTP = new FormSMTPSettings();
            if (FormSMTP.ShowDialog() == DialogResult.OK)
            {
                FormSMTP.Write();

            }
        }

    }



    public enum NotifyType
    {
        StatusMessage,
        ErrorMessage
    };
}
