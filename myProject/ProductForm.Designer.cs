namespace myProject
{
    partial class ProductForm
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
            this.btnDel = new Sunny.UI.UISymbolButton();
            this.DGVPorduct = new Sunny.UI.UIDataGridView();
            this.cboxSelectProduct = new Sunny.UI.UIComboBox();
            this.btnRevise = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.txtPname = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPprice = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPorduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FillColor = System.Drawing.Color.Gray;
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(299, 225);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(123, 40);
            this.btnDel.Symbol = 61526;
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "商品下架";
            this.btnDel.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // DGVPorduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DGVPorduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPorduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPorduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPorduct.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DGVPorduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPorduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPorduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPorduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPorduct.EnableHeadersVisualStyles = false;
            this.DGVPorduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVPorduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DGVPorduct.Location = new System.Drawing.Point(8, 318);
            this.DGVPorduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVPorduct.Name = "DGVPorduct";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPorduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPorduct.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGVPorduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVPorduct.RowTemplate.Height = 31;
            this.DGVPorduct.SelectedIndex = -1;
            this.DGVPorduct.Size = new System.Drawing.Size(411, 381);
            this.DGVPorduct.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DGVPorduct.TabIndex = 8;
            this.DGVPorduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPorduct_CellClick);
            // 
            // cboxSelectProduct
            // 
            this.cboxSelectProduct.DataSource = null;
            this.cboxSelectProduct.FillColor = System.Drawing.Color.White;
            this.cboxSelectProduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxSelectProduct.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboxSelectProduct.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboxSelectProduct.Location = new System.Drawing.Point(279, 281);
            this.cboxSelectProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSelectProduct.MinimumSize = new System.Drawing.Size(56, 0);
            this.cboxSelectProduct.Name = "cboxSelectProduct";
            this.cboxSelectProduct.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboxSelectProduct.Size = new System.Drawing.Size(144, 31);
            this.cboxSelectProduct.TabIndex = 9;
            this.cboxSelectProduct.Text = "uiComboBox1";
            this.cboxSelectProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboxSelectProduct.Watermark = "";
            this.cboxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cboxSelectProduct_SelectedIndexChanged);
            // 
            // btnRevise
            // 
            this.btnRevise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevise.FillColor = System.Drawing.Color.Teal;
            this.btnRevise.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRevise.Location = new System.Drawing.Point(153, 225);
            this.btnRevise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevise.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(126, 40);
            this.btnRevise.Symbol = 261508;
            this.btnRevise.TabIndex = 10;
            this.btnRevise.Text = "商品修改";
            this.btnRevise.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(8, 225);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 40);
            this.btnAdd.Symbol = 61694;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "商品新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPname
            // 
            this.txtPname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPname.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPname.Location = new System.Drawing.Point(140, 86);
            this.txtPname.Margin = new System.Windows.Forms.Padding(4);
            this.txtPname.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtPname.Name = "txtPname";
            this.txtPname.Padding = new System.Windows.Forms.Padding(4);
            this.txtPname.ShowText = false;
            this.txtPname.Size = new System.Drawing.Size(241, 38);
            this.txtPname.TabIndex = 12;
            this.txtPname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPname.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "商品名稱：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(43, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "價錢：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPprice
            // 
            this.txtPprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPprice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPprice.Location = new System.Drawing.Point(140, 148);
            this.txtPprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPprice.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Padding = new System.Windows.Forms.Padding(4);
            this.txtPprice.ShowText = false;
            this.txtPprice.Size = new System.Drawing.Size(241, 38);
            this.txtPprice.TabIndex = 14;
            this.txtPprice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPprice.Watermark = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "商品編號：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(134, 35);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(41, 46);
            this.lblPID.TabIndex = 18;
            this.lblPID.Text = "0";
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 704);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRevise);
            this.Controls.Add(this.cboxSelectProduct);
            this.Controls.Add(this.DGVPorduct);
            this.Controls.Add(this.btnDel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 536, 732);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPorduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton btnDel;
        private Sunny.UI.UIDataGridView DGVPorduct;
        private Sunny.UI.UIComboBox cboxSelectProduct;
        private Sunny.UI.UISymbolButton btnRevise;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UITextBox txtPname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtPprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPID;
    }
}