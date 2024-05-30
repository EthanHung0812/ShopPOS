namespace myProject
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.btnConfirm = new Sunny.UI.UISymbolButton();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBth = new Sunny.UI.UIDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCel = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(56, 544);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Radius = 42;
            this.btnConfirm.Size = new System.Drawing.Size(156, 42);
            this.btnConfirm.SymbolSize = 36;
            this.btnConfirm.TabIndex = 34;
            this.btnConfirm.Text = "送出";
            this.btnConfirm.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(167, 389);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.Radius = 43;
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(211, 43);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(167, 304);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.Radius = 43;
            this.txtAddress.ShowText = false;
            this.txtAddress.Size = new System.Drawing.Size(211, 43);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.TagString = "";
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAddress.Watermark = "";
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 111);
            this.label2.TabIndex = 31;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(262, 544);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 42;
            this.btnClear.Size = new System.Drawing.Size(156, 42);
            this.btnClear.Symbol = 61453;
            this.btnClear.SymbolSize = 36;
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "清除";
            this.btnClear.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email";
            // 
            // dtpBth
            // 
            this.dtpBth.FillColor = System.Drawing.Color.White;
            this.dtpBth.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBth.ForeColor = System.Drawing.Color.Blue;
            this.dtpBth.Location = new System.Drawing.Point(167, 460);
            this.dtpBth.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpBth.MaxLength = 10;
            this.dtpBth.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpBth.Name = "dtpBth";
            this.dtpBth.Padding = new System.Windows.Forms.Padding(0, 0, 45, 2);
            this.dtpBth.Radius = 45;
            this.dtpBth.Size = new System.Drawing.Size(202, 54);
            this.dtpBth.SymbolDropDown = 61555;
            this.dtpBth.SymbolNormal = 61555;
            this.dtpBth.TabIndex = 42;
            this.dtpBth.Text = "2000-01-01";
            this.dtpBth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpBth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpBth.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(50, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "生日";
            // 
            // txtCel
            // 
            this.txtCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCel.Location = new System.Drawing.Point(167, 229);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCel.Name = "txtCel";
            this.txtCel.Padding = new System.Windows.Forms.Padding(5);
            this.txtCel.Radius = 43;
            this.txtCel.ShowText = false;
            this.txtCel.Size = new System.Drawing.Size(211, 43);
            this.txtCel.TabIndex = 44;
            this.txtCel.TagString = "";
            this.txtCel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCel.Watermark = "";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(167, 154);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 43;
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(211, 43);
            this.txtName.TabIndex = 45;
            this.txtName.TagString = "";
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(18, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "＊";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(18, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "＊";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(18, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "＊";
            // 
            // SignUpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(455, 610);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 489, 665);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton btnConfirm;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UISymbolButton btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIDatePicker dtpBth;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtCel;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}