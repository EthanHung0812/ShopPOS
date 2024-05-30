using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace myProject
{
    public partial class ClockinForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);
        public ClockinForm()
        {
            InitializeComponent();
        }

        private void ClockinForm_Load(object sender, EventArgs e)
        {            
            scsb.DataSource = @".";               //伺服器名稱
            scsb.InitialCatalog = "myProject";    //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            lblUser.Text = GlobalVar.userName;
            ShowDGV();
        }

        void ShowDGV()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"SELECT Staff_Name, Clock_in, Clock_out, Notes FROM Clock " +
                $"WHERE Staff_Name='{GlobalVar.userName}';";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);               
                DGVClock.DataSource = dt;
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            rdr.Close();
            con.Close();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"INSERT INTO Clock(Staff_Name, Clock_in) VALUES('{GlobalVar.userName}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}')";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("打卡成功");
            ShowDGV();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"UPDATE Clock SET Clock_out='{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}' WHERE Staff_Name='{GlobalVar.userName}' AND Clock_out IS NULL;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("打卡成功");
            ShowDGV();          
        }
    }
}
