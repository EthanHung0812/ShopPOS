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
using System.Data.SqlClient;

namespace myProject
{  
    public partial class MembersForm : UIForm
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);
        int DGVCount = 0;

        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            if(GlobalVar.userLevel == "員工")
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btn新增資料.Visible = false;
                btnClear.Visible = false;
                txtEmail.ReadOnly = true;
                txt地址.ReadOnly = true;
                txt姓名.ReadOnly = true;
                txt會員等級.ReadOnly = true;
                txt電話.ReadOnly = true;
                txt點數.ReadOnly = true;
            }

            scsb.DataSource = @".";               //伺服器名稱
            scsb.InitialCatalog = "myProject";    //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            cbox欄位.Items.Add("Name");
            cbox欄位.Items.Add("Cel");
            cbox欄位.Items.Add("Email");
            cbox欄位.SelectedIndex = 0;

            ShowDataGridView();
        }
        void Clear() 
        {
            lblID.Text = string.Empty;
            txt會員等級.Text = string.Empty;
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txt點數.Clear();
            txtEmail.Clear();
            dtp日期.Value = DateTime.Now;
        }
        void ShowDataGridView()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM members;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                DGVCount = dt.Rows.Count;
                myDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            rdr.Close();
            con.Close();
        }
        void ShowMember(int searchID)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"SELECT * FROM members WHERE id = {searchID};";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblID.Text = rdr["ID"].ToString();
                txt姓名.Text = rdr["Name"].ToString();
                txt電話.Text = rdr["Cel"].ToString();
                txt地址.Text = rdr["Address"].ToString();
                txtEmail.Text = rdr["Email"].ToString();
                dtp日期.Value = (DateTime)rdr["Bth"];
                txt點數.Text = rdr["Points"].ToString();
                txt會員等級.Text = rdr["Level"].ToString();
            }
            rdr.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"SELECT * FROM members WHERE {cbox欄位.SelectedItem} LIKE '%{txt搜尋.Text}%';";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                myDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            rdr.Close();
            con.Close();
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "" && txt電話.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                string SQL = $"INSERT INTO members(Name, Cel, Address, Email, Bth, points, level) VALUES" +
                    $"('{txt姓名.Text}', '{txt電話.Text}', '{txt地址.Text}', '{txtEmail.Text}', " +
                    $"'{dtp日期.Value.ToString("yyyy-MM-dd")}', '{txt點數.Text}', '{txt會員等級.Text}');";
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("新增資料成功");
            }
            else
            {
                MessageBox.Show("請輸入必填欄位!!");
            }
            ShowDataGridView();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要刪除此筆資料?", "刪除確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"DELETE FROM members WHERE ID = {Convert.ToInt32(lblID.Text)};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("刪除成功");
                Clear();
            }
            ShowDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "" && txt電話.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"UPDATE members SET Name='{txt姓名.Text}', Cel='{txt電話.Text}', " +
                    $"Address='{txt地址.Text}', Email='{txtEmail.Text}', Bth='{dtp日期.Value.ToString("yyyy-MM-dd")}'," +
                    $" Points={txt點數.Text}, Level='{txt會員等級.Text}' WHERE ID={Convert.ToInt32(lblID.Text)};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("資料更新成功!!");
            }
            else
            {
                MessageBox.Show("姓名與電話欄位必填!!");
            }
            ShowDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGVCount)
            {
                string strID = myDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                int selectID = Convert.ToInt32(strID);

                ShowMember(selectID);
            }
        }
    }
}
