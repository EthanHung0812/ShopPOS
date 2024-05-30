namespace myProject
{
    partial class MembersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            this.lbl會員等級 = new System.Windows.Forms.Label();
            this.txt會員等級 = new Sunny.UI.UITextBox();
            this.btnUpdate = new Sunny.UI.UISymbolButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.btn新增資料 = new Sunny.UI.UISymbolButton();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt點數 = new Sunny.UI.UITextBox();
            this.txt地址 = new Sunny.UI.UITextBox();
            this.txt電話 = new Sunny.UI.UITextBox();
            this.dtp日期 = new Sunny.UI.UIDatePicker();
            this.lbl點數 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbl會員編號 = new System.Windows.Forms.Label();
            this.txt姓名 = new Sunny.UI.UITextBox();
            this.cbox欄位 = new Sunny.UI.UIComboBox();
            this.myDataGridView = new Sunny.UI.UIDataGridView();
            this.txt搜尋 = new Sunny.UI.UITextBox();
            this.btn搜尋 = new Sunny.UI.UISymbolButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl會員等級
            // 
            this.lbl會員等級.BackColor = System.Drawing.Color.Gray;
            this.lbl會員等級.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員等級.ForeColor = System.Drawing.Color.Aqua;
            this.lbl會員等級.Location = new System.Drawing.Point(30, 541);
            this.lbl會員等級.Name = "lbl會員等級";
            this.lbl會員等級.Size = new System.Drawing.Size(162, 39);
            this.lbl會員等級.TabIndex = 52;
            this.lbl會員等級.Text = "會員等級：";
            this.lbl會員等級.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt會員等級
            // 
            this.txt會員等級.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt會員等級.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt會員等級.Location = new System.Drawing.Point(201, 541);
            this.txt會員等級.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt會員等級.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt會員等級.Name = "txt會員等級";
            this.txt會員等級.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt會員等級.Radius = 39;
            this.txt會員等級.ShowText = false;
            this.txt會員等級.Size = new System.Drawing.Size(158, 39);
            this.txt會員等級.TabIndex = 51;
            this.txt會員等級.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt會員等級.Watermark = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(24, 637);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 33);
            this.btnUpdate.Symbol = 257733;
            this.btnUpdate.SymbolColor = System.Drawing.Color.Blue;
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "儲存修改";
            this.btnUpdate.TipsFont = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(402, 637);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 33);
            this.btnDelete.Symbol = 62005;
            this.btnDelete.SymbolColor = System.Drawing.Color.Red;
            this.btnDelete.SymbolDisableColor = System.Drawing.Color.Black;
            this.btnDelete.SymbolSize = 27;
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "刪除資料";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(570, 637);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 33);
            this.btnClear.Symbol = 61470;
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "清空欄位";
            this.btnClear.TipsFont = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn新增資料.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn新增資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.ForeColor = System.Drawing.Color.Black;
            this.btn新增資料.Location = new System.Drawing.Point(231, 637);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn新增資料.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(150, 33);
            this.btn新增資料.Symbol = 62004;
            this.btn新增資料.SymbolColor = System.Drawing.Color.Blue;
            this.btn新增資料.SymbolSize = 27;
            this.btn新增資料.TabIndex = 47;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.TipsFont = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(201, 335);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Radius = 39;
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(284, 39);
            this.txtEmail.TabIndex = 45;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(30, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 39);
            this.label12.TabIndex = 44;
            this.label12.Text = "Email：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt點數
            // 
            this.txt點數.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt點數.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(201, 475);
            this.txt點數.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt點數.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt點數.Name = "txt點數";
            this.txt點數.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt點數.Radius = 39;
            this.txt點數.ShowText = false;
            this.txt點數.Size = new System.Drawing.Size(158, 39);
            this.txt點數.TabIndex = 34;
            this.txt點數.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt點數.Watermark = "";
            // 
            // txt地址
            // 
            this.txt地址.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt地址.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(201, 264);
            this.txt地址.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt地址.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt地址.Name = "txt地址";
            this.txt地址.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt地址.Radius = 39;
            this.txt地址.ShowText = false;
            this.txt地址.Size = new System.Drawing.Size(284, 39);
            this.txt地址.TabIndex = 43;
            this.txt地址.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt地址.Watermark = "";
            // 
            // txt電話
            // 
            this.txt電話.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt電話.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt電話.ForeColor = System.Drawing.Color.Blue;
            this.txt電話.Location = new System.Drawing.Point(201, 193);
            this.txt電話.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt電話.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt電話.Name = "txt電話";
            this.txt電話.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt電話.Radius = 39;
            this.txt電話.ShowText = false;
            this.txt電話.Size = new System.Drawing.Size(228, 39);
            this.txt電話.TabIndex = 42;
            this.txt電話.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt電話.Watermark = "";
            // 
            // dtp日期
            // 
            this.dtp日期.FillColor = System.Drawing.Color.White;
            this.dtp日期.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp日期.ForeColor = System.Drawing.Color.Blue;
            this.dtp日期.Location = new System.Drawing.Point(201, 404);
            this.dtp日期.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtp日期.MaxLength = 10;
            this.dtp日期.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp日期.Name = "dtp日期";
            this.dtp日期.Padding = new System.Windows.Forms.Padding(0, 0, 45, 2);
            this.dtp日期.Radius = 39;
            this.dtp日期.Size = new System.Drawing.Size(210, 39);
            this.dtp日期.SymbolDropDown = 61555;
            this.dtp日期.SymbolNormal = 61555;
            this.dtp日期.TabIndex = 41;
            this.dtp日期.Text = "2000-01-01";
            this.dtp日期.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp日期.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp日期.Watermark = "";
            // 
            // lbl點數
            // 
            this.lbl點數.BackColor = System.Drawing.Color.Gray;
            this.lbl點數.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl點數.ForeColor = System.Drawing.Color.Aqua;
            this.lbl點數.Location = new System.Drawing.Point(30, 475);
            this.lbl點數.Name = "lbl點數";
            this.lbl點數.Size = new System.Drawing.Size(120, 39);
            this.lbl點數.TabIndex = 40;
            this.lbl點數.Text = "點數：";
            this.lbl點數.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(30, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 39);
            this.label10.TabIndex = 39;
            this.label10.Text = "電話*：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(30, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 39);
            this.label9.TabIndex = 38;
            this.label9.Text = "地址：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(30, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 39);
            this.label8.TabIndex = 37;
            this.label8.Text = "生日：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(30, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 39);
            this.label7.TabIndex = 36;
            this.label7.Text = "姓名*：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblID.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(195, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 46);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl會員編號
            // 
            this.lbl會員編號.AutoSize = true;
            this.lbl會員編號.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl會員編號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員編號.ForeColor = System.Drawing.Color.Black;
            this.lbl會員編號.Location = new System.Drawing.Point(29, 54);
            this.lbl會員編號.Name = "lbl會員編號";
            this.lbl會員編號.Size = new System.Drawing.Size(200, 46);
            this.lbl會員編號.TabIndex = 33;
            this.lbl會員編號.Text = "會員編號：";
            // 
            // txt姓名
            // 
            this.txt姓名.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt姓名.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(201, 121);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt姓名.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt姓名.Radius = 39;
            this.txt姓名.ShowText = false;
            this.txt姓名.Size = new System.Drawing.Size(180, 39);
            this.txt姓名.TabIndex = 32;
            this.txt姓名.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt姓名.Watermark = "";
            // 
            // cbox欄位
            // 
            this.cbox欄位.DataSource = null;
            this.cbox欄位.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbox欄位.FillColor = System.Drawing.Color.White;
            this.cbox欄位.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox欄位.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbox欄位.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbox欄位.Location = new System.Drawing.Point(727, 105);
            this.cbox欄位.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbox欄位.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbox欄位.Name = "cbox欄位";
            this.cbox欄位.Padding = new System.Windows.Forms.Padding(0, 0, 45, 2);
            this.cbox欄位.Size = new System.Drawing.Size(141, 39);
            this.cbox欄位.TabIndex = 31;
            this.cbox欄位.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbox欄位.Watermark = "";
            // 
            // myDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.myDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.myDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.myDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.myDataGridView.EnableHeadersVisualStyles = false;
            this.myDataGridView.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.myDataGridView.Location = new System.Drawing.Point(727, 153);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myDataGridView.Name = "myDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.myDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.myDataGridView.RowTemplate.Height = 31;
            this.myDataGridView.SelectedIndex = -1;
            this.myDataGridView.Size = new System.Drawing.Size(394, 518);
            this.myDataGridView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.myDataGridView.TabIndex = 30;
            this.myDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellContentClick);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(880, 105);
            this.txt搜尋.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt搜尋.MinimumSize = new System.Drawing.Size(1, 14);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt搜尋.ShowText = false;
            this.txt搜尋.Size = new System.Drawing.Size(123, 39);
            this.txt搜尋.TabIndex = 29;
            this.txt搜尋.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt搜尋.Watermark = "";
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.White;
            this.btn搜尋.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn搜尋.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn搜尋.Location = new System.Drawing.Point(1010, 105);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn搜尋.Size = new System.Drawing.Size(111, 39);
            this.btn搜尋.Symbol = 61442;
            this.btn搜尋.SymbolColor = System.Drawing.SystemColors.HotTrack;
            this.btn搜尋.TabIndex = 28;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.TipsFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.TipsForeColor = System.Drawing.Color.Black;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1136, 63);
            this.label1.TabIndex = 54;
            // 
            // MembersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 684);
            this.Controls.Add(this.lbl會員等級);
            this.Controls.Add(this.txt會員等級);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn新增資料);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt點數);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.dtp日期);
            this.Controls.Add(this.lbl點數);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbl會員編號);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.cbox欄位);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1429, 1006);
            this.Load += new System.EventHandler(this.MembersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl會員等級;
        private Sunny.UI.UITextBox txt會員等級;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btn新增資料;
        private Sunny.UI.UITextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox txt點數;
        private Sunny.UI.UITextBox txt地址;
        private Sunny.UI.UITextBox txt電話;
        private Sunny.UI.UIDatePicker dtp日期;
        private System.Windows.Forms.Label lbl點數;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbl會員編號;
        private Sunny.UI.UITextBox txt姓名;
        private Sunny.UI.UIComboBox cbox欄位;
        private Sunny.UI.UIDataGridView myDataGridView;
        private Sunny.UI.UITextBox txt搜尋;
        private Sunny.UI.UISymbolButton btn搜尋;
        private System.Windows.Forms.Label label1;
    }
}