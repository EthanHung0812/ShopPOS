namespace myProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new Sunny.UI.UITabControlMenu();
            this.tpgMenu = new System.Windows.Forms.TabPage();
            this.btnShowSCart = new Sunny.UI.UISymbolButton();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.btnCount = new Sunny.UI.UIIntegerUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddShoppingCart = new Sunny.UI.UISymbolButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboxPancake = new Sunny.UI.UIListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lboxSidedish = new Sunny.UI.UIListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lboxDrink = new Sunny.UI.UIListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk漢堡加蛋 = new Sunny.UI.UICheckBox();
            this.lboxBurger = new Sunny.UI.UIListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk吐司加蛋 = new Sunny.UI.UICheckBox();
            this.lboxToast = new Sunny.UI.UIListBox();
            this.Empty1 = new System.Windows.Forms.TabPage();
            this.tpgShoppingCart = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.btnContinue = new Sunny.UI.UISymbolButton();
            this.btnSendOrder = new Sunny.UI.UISymbolButton();
            this.btnDeleteSelect = new Sunny.UI.UISymbolButton();
            this.btnClearSC = new Sunny.UI.UISymbolButton();
            this.lboxShoppingCart = new Sunny.UI.UIListBox();
            this.Empty2 = new System.Windows.Forms.TabPage();
            this.tpgHistory = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new Sunny.UI.UIDatePicker();
            this.dtpStart = new Sunny.UI.UIDatePicker();
            this.DGVHistory = new Sunny.UI.UIDataGridView();
            this.btnHistorySearch = new Sunny.UI.UISymbolButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowLogin = new Sunny.UI.UISymbolButton();
            this.btnShowMember = new Sunny.UI.UISymbolButton();
            this.btnSignUp = new Sunny.UI.UISymbolButton();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.btnLogout = new Sunny.UI.UISymbolButton();
            this.btnClockin = new Sunny.UI.UISymbolButton();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnProductS = new Sunny.UI.UISymbolButton();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpgMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpgShoppingCart.SuspendLayout();
            this.tpgHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tpgMenu);
            this.tabControl.Controls.Add(this.Empty1);
            this.tabControl.Controls.Add(this.tpgShoppingCart);
            this.tabControl.Controls.Add(this.Empty2);
            this.tabControl.Controls.Add(this.tpgHistory);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("微軟正黑體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl.Location = new System.Drawing.Point(3, 121);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.MaximumSize = new System.Drawing.Size(1650, 850);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1492, 767);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.uiTabControlMenu1_SelectedIndexChanged);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tpgMenu
            // 
            this.tpgMenu.BackColor = System.Drawing.Color.Gray;
            this.tpgMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgMenu.BackgroundImage")));
            this.tpgMenu.Controls.Add(this.btnShowSCart);
            this.tpgMenu.Controls.Add(this.lbl總價);
            this.tpgMenu.Controls.Add(this.btnCount);
            this.tpgMenu.Controls.Add(this.label2);
            this.tpgMenu.Controls.Add(this.btnAddShoppingCart);
            this.tpgMenu.Controls.Add(this.groupBox3);
            this.tpgMenu.Controls.Add(this.groupBox4);
            this.tpgMenu.Controls.Add(this.groupBox5);
            this.tpgMenu.Controls.Add(this.groupBox2);
            this.tpgMenu.Controls.Add(this.groupBox1);
            this.tpgMenu.Location = new System.Drawing.Point(201, 0);
            this.tpgMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgMenu.Name = "tpgMenu";
            this.tpgMenu.Size = new System.Drawing.Size(1291, 767);
            this.tpgMenu.TabIndex = 0;
            this.tpgMenu.Text = "菜單";
            // 
            // btnShowSCart
            // 
            this.btnShowSCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSCart.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSCart.FillDisableColor = System.Drawing.Color.Black;
            this.btnShowSCart.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSCart.Location = new System.Drawing.Point(1076, 693);
            this.btnShowSCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowSCart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowSCart.Name = "btnShowSCart";
            this.btnShowSCart.RectColor = System.Drawing.Color.Black;
            this.btnShowSCart.Size = new System.Drawing.Size(193, 54);
            this.btnShowSCart.Symbol = 61442;
            this.btnShowSCart.SymbolSize = 36;
            this.btnShowSCart.TabIndex = 10;
            this.btnShowSCart.Text = "查看購物車";
            this.btnShowSCart.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSCart.Click += new System.EventHandler(this.btnShowSCart_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.BackColor = System.Drawing.Color.LightCyan;
            this.lbl總價.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl總價.Location = new System.Drawing.Point(937, 607);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(312, 73);
            this.lbl總價.TabIndex = 9;
            this.lbl總價.Text = "總價：";
            this.lbl總價.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(988, 525);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCount.MinimumSize = new System.Drawing.Size(112, 0);
            this.btnCount.Name = "btnCount";
            this.btnCount.ShowText = false;
            this.btnCount.Size = new System.Drawing.Size(150, 60);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = null;
            this.btnCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCount.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.btnCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(937, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 138);
            this.label2.TabIndex = 8;
            this.label2.Text = "數量";
            // 
            // btnAddShoppingCart
            // 
            this.btnAddShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShoppingCart.FillDisableColor = System.Drawing.Color.Black;
            this.btnAddShoppingCart.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddShoppingCart.Location = new System.Drawing.Point(864, 693);
            this.btnAddShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddShoppingCart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddShoppingCart.Name = "btnAddShoppingCart";
            this.btnAddShoppingCart.RectColor = System.Drawing.Color.Black;
            this.btnAddShoppingCart.Size = new System.Drawing.Size(193, 54);
            this.btnAddShoppingCart.Symbol = 57466;
            this.btnAddShoppingCart.SymbolSize = 36;
            this.btnAddShoppingCart.TabIndex = 6;
            this.btnAddShoppingCart.Text = "加入購物車";
            this.btnAddShoppingCart.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddShoppingCart.Click += new System.EventHandler(this.btnAddShoppingCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.lboxPancake);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(464, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(360, 420);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "蛋餅";
            // 
            // lboxPancake
            // 
            this.lboxPancake.FillColor = System.Drawing.Color.White;
            this.lboxPancake.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxPancake.ForeColor = System.Drawing.Color.Maroon;
            this.lboxPancake.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxPancake.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxPancake.Location = new System.Drawing.Point(18, 65);
            this.lboxPancake.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lboxPancake.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxPancake.Name = "lboxPancake";
            this.lboxPancake.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxPancake.ShowText = false;
            this.lboxPancake.Size = new System.Drawing.Size(330, 330);
            this.lboxPancake.TabIndex = 0;
            this.lboxPancake.Text = "uiListBox1";
            this.lboxPancake.SelectedIndexChanged += new System.EventHandler(this.lboxPancake_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.lboxSidedish);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(464, 477);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(360, 270);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "單點";
            // 
            // lboxSidedish
            // 
            this.lboxSidedish.FillColor = System.Drawing.Color.White;
            this.lboxSidedish.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxSidedish.ForeColor = System.Drawing.Color.Maroon;
            this.lboxSidedish.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxSidedish.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxSidedish.Location = new System.Drawing.Point(18, 57);
            this.lboxSidedish.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lboxSidedish.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxSidedish.Name = "lboxSidedish";
            this.lboxSidedish.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxSidedish.ShowText = false;
            this.lboxSidedish.Size = new System.Drawing.Size(330, 200);
            this.lboxSidedish.TabIndex = 0;
            this.lboxSidedish.Text = "uiListBox1";
            this.lboxSidedish.SelectedIndexChanged += new System.EventHandler(this.lboxSidedish_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Controls.Add(this.lboxDrink);
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(889, 26);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(360, 420);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "飲料";
            // 
            // lboxDrink
            // 
            this.lboxDrink.FillColor = System.Drawing.Color.White;
            this.lboxDrink.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDrink.ForeColor = System.Drawing.Color.Maroon;
            this.lboxDrink.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxDrink.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxDrink.Location = new System.Drawing.Point(18, 65);
            this.lboxDrink.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lboxDrink.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxDrink.Name = "lboxDrink";
            this.lboxDrink.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxDrink.ShowText = false;
            this.lboxDrink.Size = new System.Drawing.Size(330, 330);
            this.lboxDrink.TabIndex = 0;
            this.lboxDrink.Text = "uiListBox1";
            this.lboxDrink.SelectedIndexChanged += new System.EventHandler(this.lboxDrink_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.chk漢堡加蛋);
            this.groupBox2.Controls.Add(this.lboxBurger);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(37, 474);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(360, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "漢堡";
            // 
            // chk漢堡加蛋
            // 
            this.chk漢堡加蛋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chk漢堡加蛋.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk漢堡加蛋.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk漢堡加蛋.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk漢堡加蛋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk漢堡加蛋.Location = new System.Drawing.Point(197, 14);
            this.chk漢堡加蛋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk漢堡加蛋.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk漢堡加蛋.Name = "chk漢堡加蛋";
            this.chk漢堡加蛋.Size = new System.Drawing.Size(143, 35);
            this.chk漢堡加蛋.TabIndex = 10;
            this.chk漢堡加蛋.Text = "加蛋 15$";
            this.chk漢堡加蛋.CheckedChanged += new System.EventHandler(this.chk漢堡加蛋_CheckedChanged);
            // 
            // lboxBurger
            // 
            this.lboxBurger.FillColor = System.Drawing.Color.White;
            this.lboxBurger.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxBurger.ForeColor = System.Drawing.Color.Maroon;
            this.lboxBurger.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxBurger.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxBurger.Location = new System.Drawing.Point(18, 65);
            this.lboxBurger.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lboxBurger.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxBurger.Name = "lboxBurger";
            this.lboxBurger.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxBurger.ShowText = false;
            this.lboxBurger.Size = new System.Drawing.Size(330, 192);
            this.lboxBurger.TabIndex = 0;
            this.lboxBurger.Text = "uiListBox1";
            this.lboxBurger.SelectedIndexChanged += new System.EventHandler(this.lboxBurger_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.chk吐司加蛋);
            this.groupBox1.Controls.Add(this.lboxToast);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "吐司";
            // 
            // chk吐司加蛋
            // 
            this.chk吐司加蛋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chk吐司加蛋.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk吐司加蛋.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk吐司加蛋.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk吐司加蛋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk吐司加蛋.Location = new System.Drawing.Point(197, 14);
            this.chk吐司加蛋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk吐司加蛋.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk吐司加蛋.Name = "chk吐司加蛋";
            this.chk吐司加蛋.Size = new System.Drawing.Size(143, 35);
            this.chk吐司加蛋.TabIndex = 1;
            this.chk吐司加蛋.Text = "加蛋 15$";
            this.chk吐司加蛋.CheckedChanged += new System.EventHandler(this.chk吐司加蛋_CheckedChanged);
            // 
            // lboxToast
            // 
            this.lboxToast.FillColor = System.Drawing.Color.White;
            this.lboxToast.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxToast.ForeColor = System.Drawing.Color.Maroon;
            this.lboxToast.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxToast.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxToast.Location = new System.Drawing.Point(18, 65);
            this.lboxToast.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lboxToast.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxToast.Name = "lboxToast";
            this.lboxToast.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxToast.ShowText = false;
            this.lboxToast.Size = new System.Drawing.Size(330, 330);
            this.lboxToast.TabIndex = 0;
            this.lboxToast.Text = "uiListBox1";
            this.lboxToast.SelectedIndexChanged += new System.EventHandler(this.lboxToast_SelectedIndexChanged);
            // 
            // Empty1
            // 
            this.Empty1.Location = new System.Drawing.Point(201, 0);
            this.Empty1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empty1.Name = "Empty1";
            this.Empty1.Size = new System.Drawing.Size(1291, 767);
            this.Empty1.TabIndex = 5;
            this.Empty1.Text = " ";
            this.Empty1.UseVisualStyleBackColor = true;
            // 
            // tpgShoppingCart
            // 
            this.tpgShoppingCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgShoppingCart.BackgroundImage")));
            this.tpgShoppingCart.Controls.Add(this.label1);
            this.tpgShoppingCart.Controls.Add(this.lblOrderPrice);
            this.tpgShoppingCart.Controls.Add(this.btnContinue);
            this.tpgShoppingCart.Controls.Add(this.btnSendOrder);
            this.tpgShoppingCart.Controls.Add(this.btnDeleteSelect);
            this.tpgShoppingCart.Controls.Add(this.btnClearSC);
            this.tpgShoppingCart.Controls.Add(this.lboxShoppingCart);
            this.tpgShoppingCart.Location = new System.Drawing.Point(201, 0);
            this.tpgShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgShoppingCart.Name = "tpgShoppingCart";
            this.tpgShoppingCart.Size = new System.Drawing.Size(1291, 767);
            this.tpgShoppingCart.TabIndex = 1;
            this.tpgShoppingCart.Text = "購物車";
            this.tpgShoppingCart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(622, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "訂單總價：";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOrderPrice.Font = new System.Drawing.Font("細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderPrice.Location = new System.Drawing.Point(822, 639);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(72, 36);
            this.lblOrderPrice.TabIndex = 3;
            this.lblOrderPrice.Text = "000";
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FillColor = System.Drawing.Color.Teal;
            this.btnContinue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnContinue.Location = new System.Drawing.Point(95, 684);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(180, 69);
            this.btnContinue.Symbol = 61694;
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "繼續訂購";
            this.btnContinue.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.Location = new System.Drawing.Point(1075, 684);
            this.btnSendOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(180, 69);
            this.btnSendOrder.Symbol = 61528;
            this.btnSendOrder.TabIndex = 5;
            this.btnSendOrder.Text = "送出訂單";
            this.btnSendOrder.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSelect.FillColor = System.Drawing.Color.Gray;
            this.btnDeleteSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(330, 684);
            this.btnDeleteSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(180, 69);
            this.btnDeleteSelect.Symbol = 61544;
            this.btnDeleteSelect.TabIndex = 4;
            this.btnDeleteSelect.Text = "刪除所選品項";
            this.btnDeleteSelect.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnClearSC
            // 
            this.btnClearSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearSC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearSC.Location = new System.Drawing.Point(570, 684);
            this.btnClearSC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearSC.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearSC.Name = "btnClearSC";
            this.btnClearSC.Size = new System.Drawing.Size(180, 69);
            this.btnClearSC.Symbol = 61453;
            this.btnClearSC.TabIndex = 2;
            this.btnClearSC.Text = "清空購物車";
            this.btnClearSC.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearSC.Click += new System.EventHandler(this.btnClearSC_Click);
            // 
            // lboxShoppingCart
            // 
            this.lboxShoppingCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lboxShoppingCart.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxShoppingCart.ForeColor = System.Drawing.Color.White;
            this.lboxShoppingCart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lboxShoppingCart.ItemSelectForeColor = System.Drawing.Color.White;
            this.lboxShoppingCart.Location = new System.Drawing.Point(72, 41);
            this.lboxShoppingCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lboxShoppingCart.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxShoppingCart.Name = "lboxShoppingCart";
            this.lboxShoppingCart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxShoppingCart.ShowText = false;
            this.lboxShoppingCart.Size = new System.Drawing.Size(1160, 581);
            this.lboxShoppingCart.TabIndex = 1;
            this.lboxShoppingCart.Text = "uiListBox1";
            // 
            // Empty2
            // 
            this.Empty2.Location = new System.Drawing.Point(201, 0);
            this.Empty2.Name = "Empty2";
            this.Empty2.Size = new System.Drawing.Size(1291, 767);
            this.Empty2.TabIndex = 6;
            this.Empty2.UseVisualStyleBackColor = true;
            // 
            // tpgHistory
            // 
            this.tpgHistory.Controls.Add(this.lblRevenue);
            this.tpgHistory.Controls.Add(this.lblTotal);
            this.tpgHistory.Controls.Add(this.label5);
            this.tpgHistory.Controls.Add(this.label4);
            this.tpgHistory.Controls.Add(this.label3);
            this.tpgHistory.Controls.Add(this.dtpEnd);
            this.tpgHistory.Controls.Add(this.dtpStart);
            this.tpgHistory.Controls.Add(this.DGVHistory);
            this.tpgHistory.Controls.Add(this.btnHistorySearch);
            this.tpgHistory.Location = new System.Drawing.Point(201, 0);
            this.tpgHistory.Name = "tpgHistory";
            this.tpgHistory.Size = new System.Drawing.Size(1291, 767);
            this.tpgHistory.TabIndex = 7;
            this.tpgHistory.Text = "歷史訂單";
            this.tpgHistory.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(1064, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 36);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(916, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 46;
            this.label5.Text = "總花費：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(842, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "～";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(520, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "區間";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.FillColor = System.Drawing.Color.White;
            this.dtpEnd.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.Blue;
            this.dtpEnd.Location = new System.Drawing.Point(908, 7);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpEnd.MaxLength = 10;
            this.dtpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 45, 2);
            this.dtpEnd.Radius = 39;
            this.dtpEnd.Size = new System.Drawing.Size(210, 39);
            this.dtpEnd.SymbolDropDown = 61555;
            this.dtpEnd.SymbolNormal = 61555;
            this.dtpEnd.TabIndex = 43;
            this.dtpEnd.Text = "2000-01-01";
            this.dtpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEnd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Watermark = "";
            // 
            // dtpStart
            // 
            this.dtpStart.FillColor = System.Drawing.Color.White;
            this.dtpStart.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.ForeColor = System.Drawing.Color.Blue;
            this.dtpStart.Location = new System.Drawing.Point(610, 7);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpStart.MaxLength = 10;
            this.dtpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Padding = new System.Windows.Forms.Padding(0, 0, 45, 2);
            this.dtpStart.Radius = 39;
            this.dtpStart.Size = new System.Drawing.Size(210, 39);
            this.dtpStart.SymbolDropDown = 61555;
            this.dtpStart.SymbolNormal = 61555;
            this.dtpStart.TabIndex = 42;
            this.dtpStart.Text = "2000-01-01";
            this.dtpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Watermark = "";
            // 
            // DGVHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DGVHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVHistory.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DGVHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVHistory.EnableHeadersVisualStyles = false;
            this.DGVHistory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DGVHistory.Location = new System.Drawing.Point(4, 134);
            this.DGVHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVHistory.Name = "DGVHistory";
            this.DGVHistory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVHistory.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVHistory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVHistory.RowTemplate.Height = 31;
            this.DGVHistory.SelectedIndex = -1;
            this.DGVHistory.Size = new System.Drawing.Size(1278, 626);
            this.DGVHistory.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DGVHistory.TabIndex = 35;
            // 
            // btnHistorySearch
            // 
            this.btnHistorySearch.BackColor = System.Drawing.Color.White;
            this.btnHistorySearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorySearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHistorySearch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistorySearch.ForeColor = System.Drawing.Color.Black;
            this.btnHistorySearch.Location = new System.Drawing.Point(1138, 7);
            this.btnHistorySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorySearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHistorySearch.Name = "btnHistorySearch";
            this.btnHistorySearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHistorySearch.Size = new System.Drawing.Size(142, 39);
            this.btnHistorySearch.Symbol = 61442;
            this.btnHistorySearch.SymbolColor = System.Drawing.SystemColors.HotTrack;
            this.btnHistorySearch.TabIndex = 32;
            this.btnHistorySearch.Text = "搜尋";
            this.btnHistorySearch.TipsFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistorySearch.TipsForeColor = System.Drawing.Color.Black;
            this.btnHistorySearch.Click += new System.EventHandler(this.btnHistorySearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1568, 84);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ＭＥＮＵ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowLogin
            // 
            this.btnShowLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLogin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowLogin.Location = new System.Drawing.Point(1174, 51);
            this.btnShowLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowLogin.Name = "btnShowLogin";
            this.btnShowLogin.Size = new System.Drawing.Size(126, 48);
            this.btnShowLogin.Symbol = 62141;
            this.btnShowLogin.SymbolSize = 36;
            this.btnShowLogin.TabIndex = 29;
            this.btnShowLogin.Text = "登入";
            this.btnShowLogin.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowLogin.Click += new System.EventHandler(this.btnShowLogin_Click);
            // 
            // btnShowMember
            // 
            this.btnShowMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowMember.ForeColor = System.Drawing.Color.Black;
            this.btnShowMember.Location = new System.Drawing.Point(16, 40);
            this.btnShowMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowMember.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowMember.Name = "btnShowMember";
            this.btnShowMember.Size = new System.Drawing.Size(136, 32);
            this.btnShowMember.Symbol = 62141;
            this.btnShowMember.SymbolColor = System.Drawing.Color.Black;
            this.btnShowMember.SymbolSize = 27;
            this.btnShowMember.TabIndex = 30;
            this.btnShowMember.Text = "會員中心";
            this.btnShowMember.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowMember.Visible = false;
            this.btnShowMember.Click += new System.EventHandler(this.btnShowMember_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FillColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignUp.Location = new System.Drawing.Point(1333, 51);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(126, 48);
            this.btnSignUp.Symbol = 62004;
            this.btnSignUp.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUp.SymbolSize = 36;
            this.btnSignUp.TabIndex = 31;
            this.btnSignUp.Text = "註冊";
            this.btnSignUp.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.BackColor = System.Drawing.Color.Black;
            this.lblUserLevel.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserLevel.ForeColor = System.Drawing.Color.White;
            this.lblUserLevel.Location = new System.Drawing.Point(222, 51);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(110, 24);
            this.lblUserLevel.TabIndex = 32;
            this.lblUserLevel.Text = "一般會員";
            this.lblUserLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Location = new System.Drawing.Point(1333, 51);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 48);
            this.btnLogout.Symbol = 61584;
            this.btnLogout.SymbolSize = 36;
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "登出";
            this.btnLogout.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClockin
            // 
            this.btnClockin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockin.FillColor = System.Drawing.Color.Lime;
            this.btnClockin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClockin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClockin.Location = new System.Drawing.Point(1174, 51);
            this.btnClockin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClockin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClockin.Name = "btnClockin";
            this.btnClockin.Size = new System.Drawing.Size(126, 48);
            this.btnClockin.Symbol = 361463;
            this.btnClockin.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClockin.TabIndex = 34;
            this.btnClockin.Text = "打卡";
            this.btnClockin.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClockin.Visible = false;
            this.btnClockin.Click += new System.EventHandler(this.btnClockin_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Black;
            this.lblPoints.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(369, 86);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(110, 24);
            this.lblPoints.TabIndex = 35;
            this.lblPoints.Text = "目前點數";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoints.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(222, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "一般會員";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductS
            // 
            this.btnProductS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductS.FillColor = System.Drawing.Color.Navy;
            this.btnProductS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductS.Location = new System.Drawing.Point(16, 82);
            this.btnProductS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductS.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnProductS.Name = "btnProductS";
            this.btnProductS.Size = new System.Drawing.Size(136, 32);
            this.btnProductS.Symbol = 61459;
            this.btnProductS.SymbolSize = 27;
            this.btnProductS.TabIndex = 54;
            this.btnProductS.Text = "商品管理";
            this.btnProductS.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductS.Visible = false;
            this.btnProductS.Click += new System.EventHandler(this.btnProductS_Click_1);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRevenue.Location = new System.Drawing.Point(916, 95);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(127, 36);
            this.lblRevenue.TabIndex = 48;
            this.lblRevenue.Text = "總營收：";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRevenue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1490, 884);
            this.Controls.Add(this.btnProductS);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnClockin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnShowMember);
            this.Controls.Add(this.btnShowLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1890, 1055);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpgMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tpgShoppingCart.ResumeLayout(false);
            this.tpgShoppingCart.PerformLayout();
            this.tpgHistory.ResumeLayout(false);
            this.tpgHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITabControlMenu tabControl;
        private System.Windows.Forms.TabPage tpgMenu;
        private System.Windows.Forms.TabPage tpgShoppingCart;
        private System.Windows.Forms.TabPage Empty1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIListBox lboxToast;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIListBox lboxBurger;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIListBox lboxPancake;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIListBox lboxSidedish;
        private System.Windows.Forms.GroupBox groupBox5;
        private Sunny.UI.UIListBox lboxDrink;
        private Sunny.UI.UISymbolButton btnAddShoppingCart;
        private Sunny.UI.UISymbolButton btnClearSC;
        private Sunny.UI.UIListBox lboxShoppingCart;
        private Sunny.UI.UICheckBox chk吐司加蛋;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl總價;
        private Sunny.UI.UIIntegerUpDown btnCount;
        private Sunny.UI.UICheckBox chk漢堡加蛋;
        private System.Windows.Forms.Label lblOrderPrice;
        private Sunny.UI.UISymbolButton btnDeleteSelect;
        private Sunny.UI.UISymbolButton btnSendOrder;
        private Sunny.UI.UISymbolButton btnContinue;
        private Sunny.UI.UISymbolButton btnShowSCart;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UISymbolButton btnShowLogin;
        private Sunny.UI.UISymbolButton btnShowMember;
        private Sunny.UI.UISymbolButton btnSignUp;
        private System.Windows.Forms.Label lblUserLevel;
        private Sunny.UI.UISymbolButton btnLogout;
        private Sunny.UI.UISymbolButton btnClockin;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblName;
        private Sunny.UI.UISymbolButton btnProductS;
        private System.Windows.Forms.TabPage Empty2;
        private System.Windows.Forms.TabPage tpgHistory;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolButton btnHistorySearch;
        private Sunny.UI.UIDataGridView DGVHistory;
        private Sunny.UI.UIDatePicker dtpEnd;
        private Sunny.UI.UIDatePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRevenue;
    }
}

