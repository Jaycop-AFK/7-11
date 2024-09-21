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

    namespace _7_11
    {
        public partial class FormSale : Form
        {
            SqlConnection conn = new SqlConnection("Data Source=344_14;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataTable dt;
            int proCount = 0;
            string numCash = null;
            public FormSale()
            {
                InitializeComponent();
            }

            private void FormSale_Load(object sender, EventArgs e)
            {

            }

            private void tID_KeyUp(object sender, KeyEventArgs e)
            {
           
                try
                {
                    if (tID.TextLength == 4)
                    {
                        cmd = new SqlCommand("SELECT * FROM product WHERE product_id = " + tID.Text + "", conn);
                        conn.Open();
                        adapter = new SqlDataAdapter(cmd);
                        conn.Close();
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        la_product.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        la_amount.Text = "1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
            
            }

        private void nu_count_ValueChanged(object sender, EventArgs e)
        {
            la_amount.Text = nu_count.Value.ToString();
        }

        private void calTotal()
        {

            int total = 0;
            for (int i = 0; i < productDataGridView.Rows.Count; i++)
            {
                total += Convert.ToInt32(productDataGridView.Rows[i].Cells[4].Value);
            }
            la_total.Text = string.Format(" {0:#,##0.00}", double.Parse(total.ToString()));
        }
        private void getCash(String getCash)
        {
            numCash += getCash;
            la_recive.Text = string.Format(" {0:#,##0.00}", double.Parse(numCash));
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM product WHERE product_id = " + tID.Text + "", conn);
                conn.Open();
                adapter = new SqlDataAdapter(cmd);
                conn.Close();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                int p = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[2]);
                int a = Convert.ToInt16(la_amount.Text);
                int total = p * a;
                string[] row = new string[] { "" + ds.Tables[0].Rows[0].ItemArray[0], "" + ds.Tables[0].Rows[0].ItemArray[1], "" + la_amount.Text, "" + ds.Tables[0].Rows[0].ItemArray[2], "" + total };
                productDataGridView.Rows.Add(row);
                proCount++;
                calTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    productDataGridView.Rows.RemoveAt(index);
                    calTotal();
                }
            }


        }

        private void b0_Click(object sender, EventArgs e)
        {
            getCash("0");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            getCash("1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            getCash("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            getCash("3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            getCash("4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            getCash("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            getCash("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            getCash("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            getCash("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            getCash("9");
        }

        private void b_Dot_Click(object sender, EventArgs e)
        {
            getCash(".");
        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            numCash = null;
            la_recive.Text = string.Empty;
        }

        private void updateAmount()
        {
            try
            {
                foreach (DataGridViewRow row in productDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)

                    {
                        cmd = new SqlCommand("UPDATE product SET product_amout=product_amout-" + row.Cells[2].Value + "WHERE product_id=" + row.Cells[0].Value + "", conn);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("฿ Sale Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_Sale_Click(object sender, EventArgs e)
        {
            if (la_recive.Text == string.Empty)
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(la_recive.Text) < Convert.ToDouble(la_total.Text))
            {
                MessageBox.Show("ใส่จำนวนเงินให้มากกว่าราคารวม", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double change = Convert.ToDouble(la_recive.Text) - Convert.ToDouble(la_total.Text);
                la_change.Text = change.ToString();
            }
            updateAmount();
        }
    }
   
}
