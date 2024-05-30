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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;
using Sunny.UI;

namespace myProject
{
    public partial class Form1 : UIForm
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);
                   
        List<int> memberID = new List<int>();     
        List<int> total_total = new List<int>();
        List<int> Toast_List = new List<int>();
        List<int> Burger_List = new List<int>();
        List<int> Pancake_List = new List<int>();
        List<int> Drink_List = new List<int>();
        List<int> Sidedish_List = new List<int>();

        TimeSpan S = new TimeSpan(6, 0, 0);
        TimeSpan E = new TimeSpan(23, 0, 0);
        TimeSpan N = DateTime.Now.TimeOfDay;

        int price = 0;
        int total = 0;
        string product_name = "";
        bool is吐司加蛋 = false;
        bool is漢堡加蛋 = false;
        int DGVCount = 0;
       
        public Form1()
        {
            InitializeComponent();
        }             
        private void Form1_Load(object sender, EventArgs e)
        {           
            if (N <= S || N >= E)
            {              
                MessageBox.Show($"******系統維護中******\n\n開啟時間為\n{S} ~ {E}");

                DialogResult R = MessageBox.Show("管理者登入", "登入確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    if(GlobalVar.userLevel != "管理者")
                    {
                        MessageBox.Show("非管理者，權限不足");
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }

            scsb.DataSource = @".";               //伺服器名稱
            scsb.InitialCatalog = "myProject";    //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
                        
            ShowToast();
            ShowBurger();
            ShowPancake();
            ShowSidedish();
            ShowDrink();
            
            btnCount.Value = 1;     
            dtpEnd.Value = DateTime.Now;
        }
        //================================================================================================
        //============================================function=============================================
        void ShowToast()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM 吐司類;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string str = "";
                str += $"{rdr["name"]}   {rdr["price"]}元";
                Toast_List.Add((int)rdr["id"]);
                lboxToast.Items.Add(str);
            }
            rdr.Close();
            con.Close();                   
        }
        void ShowBurger()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM 漢堡類;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string str = "";
                str += $"{rdr["name"]}   {rdr["price"]}元";
                Burger_List.Add((int)rdr["id"]);
                lboxBurger.Items.Add(str);
            }
            rdr.Close();
            con.Close();
        }
        void ShowPancake()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM 蛋餅類;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string str = "";
                str += $"{rdr["name"]}   {rdr["price"]}元";
                Pancake_List.Add((int)rdr["id"]);
                lboxPancake.Items.Add(str);
            }
            rdr.Close();
            con.Close();

            
        }
        void ShowSidedish()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM 單點;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string str = "";
                str += $"{rdr["name"]}   {rdr["price"]}元";
                Sidedish_List.Add((int)rdr["id"]);
                lboxSidedish.Items.Add(str);
            }
            rdr.Close();
            con.Close();
        }
        void ShowDrink()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = "SELECT * FROM 飲料;";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string str = "";
                str += $"{rdr["name"]}   {rdr["price"]}元";
                Drink_List.Add((int)rdr["id"]);
                lboxDrink.Items.Add(str);
            }
            rdr.Close();
            con.Close();
        }
        void Total()
        {
            total = price * btnCount.Value;
            if (is吐司加蛋 == true && lboxToast.SelectedIndex != -1 || is漢堡加蛋 == true && lboxBurger.SelectedIndex != -1)
            {
                total = (price + 15) * btnCount.Value;
                lbl總價.Text = $"總價：{total}";
            }
            else
            {
                lbl總價.Text = $"總價：{total}";
            }

        }
        void Show_OrderPrice()
        {
            int orderPrice = 0;
            for (int i = 0; i < total_total.Count; i++)
            {
                orderPrice += total_total[i];
            }
            lblOrderPrice.Text = $"{orderPrice}";
        }
        void ShowHistory()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"SELECT Member_name, Order_date, Order_number, Order_Details, Total_price FROM OrderList WHERE Member_name = '{GlobalVar.userName}' AND " +
                $"Order_date >= '{dtpStart.Value.ToString("yyyy-MM-dd")}' AND Order_date <= '{dtpEnd.Value.ToString("yyyy-MM-dd")}';";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                DGVCount = dt.Rows.Count;
                DGVHistory.DataSource = dt;
            }
            rdr.Close();
            con.Close();
        }
        void ShowSum()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"SELECT SUM(Total_price) AS T FROM OrderList WHERE Member_name = '{GlobalVar.userName}' AND Order_date >= " +
                $"'{dtpStart.Value.ToString("yyyy-MM-dd")}' AND Order_date <= '{dtpEnd.Value.ToString("yyyy-MM-dd")}';";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblTotal.Text = rdr["T"].ToString();
            }
            rdr.Close();
            con.Close();
        }
        //============================================function=============================================
        //================================================================================================


        //=========================================================================================================
        //============================================SelectIndex=============================================    
        private void lboxToast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxToast.SelectedIndex != -1)
            {
                lboxPancake.ClearSelected();
                lboxBurger.ClearSelected();
                lboxDrink.ClearSelected();
                lboxSidedish.ClearSelected();
            }

            if (lboxToast.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT name,price FROM 吐司類 WHERE ID = {Toast_List[lboxToast.SelectedIndex]};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    product_name = (string)rdr["name"];
                    price = (int)rdr["price"];
                    total = price * btnCount.Value;
                    Total();
                }
                rdr.Close();
                con.Close();
            }
        }

        private void lboxBurger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxBurger.SelectedIndex != -1)
            {
                lboxPancake.ClearSelected();
                lboxToast.ClearSelected();
                lboxDrink.ClearSelected();
                lboxSidedish.ClearSelected();
            }
            if (lboxBurger.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT name,price FROM 漢堡類 WHERE ID = {Burger_List[lboxBurger.SelectedIndex]};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    product_name = rdr["name"].ToString();
                    price = (int)rdr["price"];
                    total = price * btnCount.Value;
                    Total();
                }
                rdr.Close();
                con.Close();
            }
        }

        private void lboxPancake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxPancake.SelectedIndex != -1)
            {
                lboxToast.ClearSelected();
                lboxBurger.ClearSelected();
                lboxDrink.ClearSelected();
                lboxSidedish.ClearSelected();
            }
            if (lboxPancake.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT name,price FROM 蛋餅類 WHERE ID = {Pancake_List[lboxPancake.SelectedIndex]};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    product_name = rdr["name"].ToString();
                    price = (int)rdr["price"];
                    total = price * btnCount.Value;
                    Total();
                }
                rdr.Close();
                con.Close();
            }
        }

        private void lboxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxDrink.SelectedIndex != -1)
            {
                lboxToast.ClearSelected();
                lboxBurger.ClearSelected();
                lboxPancake.ClearSelected();
                lboxSidedish.ClearSelected();
            }
            if (lboxDrink.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT name,price FROM 飲料 WHERE ID = {Drink_List[lboxDrink.SelectedIndex]};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    product_name = rdr["name"].ToString();
                    price = (int)rdr["price"];
                    total = price * btnCount.Value;
                    Total();
                }
                rdr.Close();
                con.Close();
            }
        }

        private void lboxSidedish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxSidedish.SelectedIndex != -1)
            {
                lboxToast.ClearSelected();
                lboxBurger.ClearSelected();
                lboxPancake.ClearSelected();
                lboxDrink.ClearSelected();
            }
            if (lboxSidedish.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT name,price FROM 單點 WHERE ID = {Sidedish_List[lboxSidedish.SelectedIndex]};";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    product_name = rdr["name"].ToString();
                    price = (int)rdr["price"];
                    total = price * btnCount.Value;
                    Total();
                }
                rdr.Close();
                con.Close();
            }
        }
        //============================================SelectIndex=============================================
        //==========================================================================================================

        private void btnCount_ValueChanged(object sender, int value)
        {
            Total();
        }

        private void chk吐司加蛋_CheckedChanged(object sender, EventArgs e)
        {
            if(chk吐司加蛋.Checked)
            {
                is吐司加蛋 = true;
                Total();
            }
            else
            {
                is吐司加蛋= false;
                Total();
            }
        }

        private void chk漢堡加蛋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk漢堡加蛋.Checked)
            {
                is漢堡加蛋 = true;
                Total();
            }
            else
            {
                is漢堡加蛋 = false;
                Total();
            }
        }

        private void btnAddShoppingCart_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                total_total.Add(total);
                string str = $"{product_name}  {price}元  {btnCount.Value}個   總價：{total}";
                lboxShoppingCart.Items.Add(str);              
                MessageBox.Show("加入成功");
                btnCount.Value = 1;
            }
            else
            {
                MessageBox.Show("請選擇餐點");
            }
        }
        
        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Show_OrderPrice();           
        }

        private void btnClearSC_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要清空購物車?", "清空確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                lboxShoppingCart.Items.Clear();
                total_total.Clear();
                lblOrderPrice.Text = "訂單總價：0";
            }
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            if(lboxShoppingCart.SelectedIndex >= 0)
            {
                int selectIndex = lboxShoppingCart.SelectedIndex;
                lboxShoppingCart.Items.RemoveAt(selectIndex);
                total_total.RemoveAt(selectIndex);

                Show_OrderPrice();
            }
            else
            {
                MessageBox.Show("請選擇所要刪除的項目");
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tpgMenu;
        }

        private void btnShowSCart_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tpgShoppingCart;
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {          
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            DGVHistory.ClearAll();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl.SelectedTab == tpgMenu) {lblTitle.Text = "ＭＥＮＵ";}
            if(tabControl.SelectedTab == tpgShoppingCart) { lblTitle.Text = "購   物   車"; }
            if (tabControl.SelectedTab == tpgHistory) { lblTitle.Text = "歷   史   紀   錄"; }
            if (tabControl.SelectedTab == Empty1) { lblTitle.Text = ""; } 
        }
        private void btnProductS_Click(object sender, EventArgs e)
        {
            ProductForm PF = new ProductForm();
            PF.ShowDialog();
        }
        private void btnShowMember_Click(object sender, EventArgs e)
        {
            if (GlobalVar.userLevel == "管理者" || GlobalVar.userLevel == "員工")
            {
                MembersForm MF = new MembersForm();
                MF.ShowDialog();
            }                      
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm su = new SignUpForm();
            su.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {            
            lblUserLevel.Text = GlobalVar.userLevel;
            lblName.Text = GlobalVar.userName;
            lblPoints.Text = $"點數：{GlobalVar.userPoints.ToString()}";
            lblTotal.Text = "0";

            if(GlobalVar.userLevel == "管理者")
            {
                btnProductS.Visible = true;
                btnShowMember.Visible = true;
                btnShowLogin.Visible = false;
                btnSignUp.Visible = false;
                btnLogout.Visible = true;
                lblName.Visible = true;
                lblPoints.Visible = true;
                lblUserLevel.Visible = true;
            }
            else if(GlobalVar.userLevel == "員工")
            {
                btnProductS.Visible = true;
                btnShowMember.Visible = true;
                btnClockin.Visible = true;
                btnShowLogin.Visible = false;
                btnSignUp.Visible = false;
                btnLogout.Visible = true;
                lblName.Visible = true;
                lblPoints.Visible = true;
                lblUserLevel.Visible = true;
            }
            else if (GlobalVar.userLevel == "一般會員")
            {
                btnProductS.Visible = false;
                lblPoints.Visible = true;
                btnClockin.Visible = false;
                btnShowLogin.Visible = false;
                btnSignUp.Visible = false;
                btnLogout.Visible = true;
                lblName.Visible = true;
                lblPoints.Visible = true;
                lblUserLevel.Visible = true;
            }
            else
            {
                btnShowLogin.Visible = true;
                btnSignUp.Visible = true;
                btnLogout.Visible = false;
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (N <= S || N >= E)
            {
                MessageBox.Show("******系統維護中******\n\n若需使用 請先登入!!");
                Application.Exit();
            }
            GlobalVar.userLevel = "";
            GlobalVar.userName = "訪客";
            GlobalVar.userPoints = 0;

            lblRevenue.Visible = false;
            lblName.Visible = false;
            lblPoints.Visible = false;
            lblUserLevel.Visible = false;
            MessageBox.Show("登出成功");
           
            btnShowLogin.Visible = true;
            btnSignUp.Visible = true;
            btnLogout.Visible = false;
            btnClockin.Visible = false;    
            btnShowMember.Visible = false;
            btnProductS.Visible = false;
            
            DGVHistory.ClearAll();
        }

        private void btnClockin_Click(object sender, EventArgs e)
        {
            if(GlobalVar.userLevel == "")
            {
                MessageBox.Show("請先登入");
            }
            else
            {
                ClockinForm CF = new ClockinForm();
                CF.ShowDialog();
            }
            
        }

        private void btnProductS_Click_1(object sender, EventArgs e)
        {
            ProductForm PF = new ProductForm();
            PF.ShowDialog();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {    
            string str = "";
            foreach(string item in lboxShoppingCart.Items)
            {
                str += item + "\n";
            }

            Random rd = new Random();
            DateTime dt = DateTime.Now;
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string SQL = $"INSERT INTO Orderlist(Member_name ,Order_date, Order_number, Order_Details, Total_price) VALUES" +
                $"('{GlobalVar.userName}' ,'{dt.ToString("yyyy-MM-dd")}', '{"10002024"+rd.Next(1000, 9999)}', '{str}', {Convert.ToInt32(lblOrderPrice.Text)});";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("*********訂單已成立*********");

            lboxShoppingCart.Items.Clear();
        }

        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            if (GlobalVar.userLevel == "管理者")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string SQL = $"SELECT Member_name, Order_date, Order_number, Order_Details, Total_price FROM OrderList WHERE " +
                    $"Order_date >= '{dtpStart.Value.ToString("yyyy-MM-dd")}' AND Order_date <= '{dtpEnd.Value.ToString("yyyy-MM-dd")}';";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    DGVCount = dt.Rows.Count;
                    DGVHistory.DataSource = dt;
                }                              

                string SQL2 = $"SELECT SUM(Total_price) AS T FROM OrderList WHERE Order_date >= " +
                    $"'{dtpStart.Value.ToString("yyyy-MM-dd")}' AND Order_date <= '{dtpEnd.Value.ToString("yyyy-MM-dd")}';";
                cmd = new SqlCommand(SQL2, con);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lblTotal.Text = rdr["T"].ToString();
                }
                rdr.Close();
                con.Close();

                lblRevenue.Visible = true;
            }
            else
            {
                ShowHistory();
                ShowSum();
            }         
        }
    }
}
