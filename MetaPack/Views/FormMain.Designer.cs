namespace MetaPack.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
                
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.databasesettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gfhToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.textDebug = new System.Windows.Forms.TextBox();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.listViewMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripTextBox1,
            this.toolStripSeparator1,
            this.databasesettingsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.gfhToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // ordersToolStripTextBox1
            // 
            this.ordersToolStripTextBox1.Name = "ordersToolStripTextBox1";
            resources.ApplyResources(this.ordersToolStripTextBox1, "ordersToolStripTextBox1");
            this.ordersToolStripTextBox1.Click += new System.EventHandler(this.ordersToolStripTextBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // databasesettingsToolStripMenuItem
            // 
            this.databasesettingsToolStripMenuItem.Name = "databasesettingsToolStripMenuItem";
            resources.ApplyResources(this.databasesettingsToolStripMenuItem, "databasesettingsToolStripMenuItem");
            this.databasesettingsToolStripMenuItem.Click += new System.EventHandler(this.databasesettingsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // gfhToolStripMenuItem
            // 
            this.gfhToolStripMenuItem.Name = "gfhToolStripMenuItem";
            resources.ApplyResources(this.gfhToolStripMenuItem, "gfhToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // listViewMenu
            // 
            this.listViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            resources.ApplyResources(this.listViewMenu, "listViewMenu");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.jpg");
            this.imageList1.Images.SetKeyName(1, "WIN_20170718_00_21_19_Pro.jpg");
            this.imageList1.Images.SetKeyName(2, "WIN_20170718_00_21_37_Pro.jpg");
            this.imageList1.Images.SetKeyName(3, "WIN_20170718_00_23_37_Pro (2).jpg");
            this.imageList1.Images.SetKeyName(4, "WIN_20170718_00_23_37_Pro.jpg");
            this.imageList1.Images.SetKeyName(5, "WIN_20170718_00_23_38_Pro.jpg");
            this.imageList1.Images.SetKeyName(6, "WIN_20170718_00_23_39_Pro (2).jpg");
            this.imageList1.Images.SetKeyName(7, "WIN_20170718_00_23_39_Pro (3).jpg");
            this.imageList1.Images.SetKeyName(8, "WIN_20170718_00_23_39_Pro.jpg");
            this.imageList1.Images.SetKeyName(9, "WIN_20170718_00_24_04_Pro.jpg");
            this.imageList1.Images.SetKeyName(10, "WIN_20170718_00_24_07_Pro.jpg");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelItemName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOrderPrice, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textDebug, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // labelItemName
            // 
            this.labelItemName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.labelItemName, "labelItemName");
            this.labelItemName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelItemName.Name = "labelItemName";
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoEllipsis = true;
            resources.ApplyResources(this.labelOrderPrice, "labelOrderPrice");
            this.labelOrderPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrderPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOrderPrice.ForeColor = System.Drawing.Color.White;
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Click += new System.EventHandler(this.labelItemPrice_Click);
            // 
            // textDebug
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textDebug, 4);
            resources.ApplyResources(this.textDebug, "textDebug");
            this.textDebug.Name = "textDebug";
            // 
            // buttonNewItem
            // 
            resources.ApplyResources(this.buttonNewItem, "buttonNewItem");
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Name = "label1";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.listViewMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator gfhToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listViewMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textDebug;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Label label1;
       
    }
}

