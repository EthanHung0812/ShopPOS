using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Sunny.UI;

namespace myProject
{
    public partial class ProductForm : UIForm
    {
        myProjectEntities DB = new myProjectEntities();
        吐司類 myToast = new 吐司類();
        漢堡類 myBurger = new 漢堡類();
        蛋餅類 myPancake = new 蛋餅類();
        單點 mySidedish = new 單點();
        飲料 myDrink = new 飲料();

        int myPID = 0;
        int DGVCount = 0;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cboxSelectProduct.Items.Add("吐司類");
            cboxSelectProduct.Items.Add("漢堡類");
            cboxSelectProduct.Items.Add("蛋餅類");
            cboxSelectProduct.Items.Add("單點");
            cboxSelectProduct.Items.Add("飲料");
            cboxSelectProduct.SelectedIndex = 0;         
        }

        private void cboxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSelectProduct.SelectedIndex == 0)
            {
                DGVPorduct.DataSource = DB.吐司類.ToList();
                DGVCount = DB.吐司類.ToList().Count;
            }
            if (cboxSelectProduct.SelectedIndex == 1)
            {
                DGVPorduct.DataSource = DB.漢堡類.ToList();
                DGVCount = DB.漢堡類.ToList().Count;
            }
            if (cboxSelectProduct.SelectedIndex == 2)
            {
                DGVPorduct.DataSource = DB.蛋餅類.ToList();
                DGVCount = DB.蛋餅類.ToList().Count;
            }
            if (cboxSelectProduct.SelectedIndex == 3)
            {
                DGVPorduct.DataSource = DB.單點.ToList();
                DGVCount = DB.單點.ToList().Count;
            }
            if (cboxSelectProduct.SelectedIndex == 4)
            {
                DGVPorduct.DataSource = DB.飲料.ToList();
                DGVCount = DB.飲料.ToList().Count;
            }
        }

        private void DGVPorduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGVCount)
            {
                string strID = DGVPorduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strID, out selectID);

                if (cboxSelectProduct.SelectedIndex == 0)
                {
                    var result = DB.吐司類.Where(s => s.id == selectID);
                    myToast = result.FirstOrDefault();
                    
                    lblPID.Text = myToast.id.ToString();
                    txtPname.Text = myToast.name;
                    txtPprice.Text = myToast.price.ToString();
                }
                if (cboxSelectProduct.SelectedIndex == 1)
                {
                    var result = DB.漢堡類.Where(s => s.id == selectID);
                    myBurger = result.FirstOrDefault();
                    lblPID.Text = myBurger.id.ToString();
                    txtPname.Text = myBurger.name;
                    txtPprice.Text = myBurger.price.ToString();
                }
                if (cboxSelectProduct.SelectedIndex == 2)
                {
                    var result = DB.蛋餅類.Where(s => s.id == selectID);
                    myPancake = result.FirstOrDefault();
                    lblPID.Text = myPancake.id.ToString();
                    txtPname.Text = myPancake.name;
                    txtPprice.Text = myPancake.price.ToString();
                }
                if (cboxSelectProduct.SelectedIndex == 3)
                {
                    var result = DB.單點.Where(s => s.id == selectID);
                    mySidedish = result.FirstOrDefault();
                    lblPID.Text = mySidedish.id.ToString();
                    txtPname.Text = mySidedish.name;
                    txtPprice.Text = mySidedish.price.ToString();
                }
                if (cboxSelectProduct.SelectedIndex == 4)
                {
                    var result = DB.飲料.Where(s => s.id == selectID);
                    myDrink = result.FirstOrDefault();
                    lblPID.Text = myDrink.id.ToString();
                    txtPname.Text = myDrink.name;
                    txtPprice.Text = myDrink.price.ToString();
                }
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            if(txtPname.Text != "" && txtPprice.Text != "")
            {
                if (cboxSelectProduct.SelectedIndex == 0)
                {
                    myToast.name = txtPname.Text;
                    myToast.price = Convert.ToInt32(txtPprice.Text);

                    DB.Entry(myToast).State = EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("資料修改成功");
                }
                if (cboxSelectProduct.SelectedIndex == 1)
                {
                    myBurger.name = txtPname.Text;
                    myBurger.price = Convert.ToInt32(txtPprice.Text);

                    DB.Entry(myBurger).State = EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("資料修改成功");
                }
                if (cboxSelectProduct.SelectedIndex == 2)
                {
                    myPancake.name = txtPname.Text;
                    myPancake.price = Convert.ToInt32(txtPprice.Text);

                    DB.Entry(myPancake).State = EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("資料修改成功");
                }
                if (cboxSelectProduct.SelectedIndex == 3)
                {
                    mySidedish.name = txtPname.Text;
                    mySidedish.price = Convert.ToInt32(txtPprice.Text);

                    DB.Entry(mySidedish).State = EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("資料修改成功");
                }
                if (cboxSelectProduct.SelectedIndex == 4)
                {
                    myDrink.name = txtPname.Text;
                    myDrink.price = Convert.ToInt32(txtPprice.Text);

                    DB.Entry(myDrink).State = EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("資料修改成功");
                }
            }
            else
            {
                MessageBox.Show("資料欄位不能為空!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPname.Text != "" && txtPprice.Text != "")
            {
                if (cboxSelectProduct.SelectedIndex == 0)
                {
                    myToast = new 吐司類();
                    myToast.name = txtPname.Text;
                    myToast.price = Convert.ToInt32(txtPprice.Text);

                    DB.吐司類.Add(myToast);
                    DB.SaveChanges();

                    MessageBox.Show("新增成功");
                }
                if (cboxSelectProduct.SelectedIndex == 1)
                {
                    myBurger = new 漢堡類();
                    myBurger.name = txtPname.Text;
                    myBurger.price = Convert.ToInt32(txtPprice.Text);

                    DB.漢堡類.Add(myBurger);
                    DB.SaveChanges();

                    MessageBox.Show("新增成功");
                }
                if (cboxSelectProduct.SelectedIndex == 2)
                {
                    myPancake = new 蛋餅類();
                    myPancake.name = txtPname.Text;
                    myPancake.price = Convert.ToInt32(txtPprice.Text);

                    DB.蛋餅類.Add(myPancake);
                    DB.SaveChanges();

                    MessageBox.Show("新增成功");
                }
                if (cboxSelectProduct.SelectedIndex == 3)
                {
                    mySidedish = new 單點();
                    mySidedish.name = txtPname.Text;
                    mySidedish.price = Convert.ToInt32(txtPprice.Text);

                    DB.單點.Add(mySidedish);
                    DB.SaveChanges();

                    MessageBox.Show("新增成功");
                }
                if (cboxSelectProduct.SelectedIndex == 4)
                {
                    myDrink = new 飲料();
                    myDrink.name = txtPname.Text;
                    myDrink.price = Convert.ToInt32(txtPprice.Text);

                    DB.飲料.Add(myDrink);
                    DB.SaveChanges();

                    MessageBox.Show("新增成功");
                }
            }
            else
            {
                MessageBox.Show("資料欄位不能為空!!!");
            }
            txtPname.Text = string.Empty;
            txtPprice.Text = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblPID.Text != "")
            {
                if (cboxSelectProduct.SelectedIndex == 0)
                {
                    if (myToast != null)
                    {
                        DialogResult R = MessageBox.Show("您確定要下架此商品?", "下架確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R == DialogResult.Yes)
                        {
                            DB.吐司類.Remove(myToast);
                            DB.SaveChanges();
                            MessageBox.Show("下架成功");
                        }
                    }
                }
                if (cboxSelectProduct.SelectedIndex == 1)
                {
                    if (myBurger != null)
                    {
                        DialogResult R = MessageBox.Show("您確定要下架此商品?", "下架確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R == DialogResult.Yes)
                        {
                            DB.漢堡類.Remove(myBurger);
                            DB.SaveChanges();
                            MessageBox.Show("下架成功");
                        }
                    }
                }
                if (cboxSelectProduct.SelectedIndex == 2)
                {
                    if (myPancake != null)
                    {
                        DialogResult R = MessageBox.Show("您確定要下架此商品?", "下架確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R == DialogResult.Yes)
                        {
                            DB.蛋餅類.Remove(myPancake);
                            DB.SaveChanges();
                            MessageBox.Show("下架成功");
                        }
                    }
                }
                if (cboxSelectProduct.SelectedIndex == 3)
                {
                    if (mySidedish != null)
                    {
                        DialogResult R = MessageBox.Show("您確定要下架此商品?", "下架確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R == DialogResult.Yes)
                        {
                            DB.單點.Remove(mySidedish);
                            DB.SaveChanges();
                            MessageBox.Show("下架成功");
                        }
                    }
                }
                if (cboxSelectProduct.SelectedIndex == 4)
                {
                    if (myDrink != null)
                    {
                        DialogResult R = MessageBox.Show("您確定要下架此商品?", "下架確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R == DialogResult.Yes)
                        {
                            DB.飲料.Remove(myDrink);
                            DB.SaveChanges();
                            MessageBox.Show("下架成功");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇要下架的商品");
            }
        }
    }
}
