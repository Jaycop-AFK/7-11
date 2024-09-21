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
    public partial class FormProduct : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344_14;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", t_id.Text);
            cmd.Parameters.AddWithValue("name", t_name.Text);
            cmd.Parameters.AddWithValue("price", t_price.Text);
            cmd.Parameters.AddWithValue("amount", t_amount.Text);
            cmd.Parameters.AddWithValue("type", t_type.Text);
            cmd.Parameters.AddWithValue("search", t_search.Text);
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._7_11DataSet.product);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                t_id.Text = row.Cells[0].Value.ToString();
                t_name.Text = row.Cells[1].Value.ToString();
                t_price.Text = row.Cells[2].Value.ToString();
                t_amount.Text = row.Cells[3].Value.ToString();
                t_type.Text = row.Cells[4].Value.ToString();
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE product SET product_name=@name,product_price=@price,product_amout=@amount WHERE product_id=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.product);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO product ( product_id, product_name, product_price, product_amout,peoduct_tID)VALUES(@id,@name,@price,@amount,@type)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.product);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM product WHERE product_id=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.productTableAdapter.Fill(this._7_11DataSet.product);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM product WHERE product_id LIKE @search+'%' OR product_name LIKE @search+'%' OR product_price LIKE @search+'%' OR product_amout LIKE @search+'%'", conn);
                parameter();
                conn.Open();
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No data ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
