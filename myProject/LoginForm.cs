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
    public partial class LoginForm : UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myProject";
            scsb.IntegratedSecurity = true;
            
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!="" && txtPassword.Text!="")
            {               
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT * FROM members WHERE Email='{txtUserName.Text}' AND " +
                    $"Cel='{txtPassword.Text}';";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    GlobalVar.isLogin = true;
                    GlobalVar.userName = rdr["Name"].ToString();
                    GlobalVar.userID = (int)rdr["ID"];
                    GlobalVar.userPoints = (int)rdr["Points"];
                    GlobalVar.userLevel = rdr["Level"].ToString();

                    MessageBox.Show($"[{GlobalVar.userLevel}]\n登入成功!!");

                    rdr.Close();
                    con.Close(); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼輸入錯誤");
                }
                //if(GlobalVar.isLogin == false)
                //{
                //    MessageBox.Show("帳號或密碼輸入錯誤");
                //}
                //rdr.Close();
                //con.Close();
            }
            else
            {
                MessageBox.Show("帳號密碼欄位必填");
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
