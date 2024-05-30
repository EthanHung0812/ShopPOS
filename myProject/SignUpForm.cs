using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sunny.UI;

namespace myProject
{
    public partial class SignUpForm : UIForm
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myProject";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        void Clear()
        {
            txtName.Text = string.Empty;
            txtCel.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpBth.Value = new DateTime(2000, 1, 1);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {         
            if (txtName.Text != "" && txtEmail.Text != "" && txtCel.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT * FROM members WHERE Cel='{txtCel.Text}' OR Email='{txtEmail.Text}';";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    con.Close();
                    MessageBox.Show("此電話號碼或信箱已註冊過!!");
                }
                else
                {
                    con.Close();
                    con.Open();
                    string SQL2 = $"INSERT INTO members(Name, Cel, Address, Email, Bth) VALUES('{txtName.Text}', '{txtCel.Text}', " +
                        $"'{txtAddress.Text}', '{txtEmail.Text}', '{dtpBth.Value.ToString("yyyy-MM-dd")}');"; 
                    cmd = new SqlCommand(SQL2, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("註冊成功");
                    Clear();
                }
                
            }
            else
            {
                MessageBox.Show("*必填欄位不能為空");
            }
            

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
