using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_11
{
    public partial class FormProductType : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344_14;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormProductType()
        {
            InitializeComponent();
        }

        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", t_id.Text);
            cmd.Parameters.AddWithValue("name", t_name.Text);
       
        }

        private void FormProductType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.product_type' table. You can move, or remove it, as needed.
            this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                t_id.Text = row.Cells[0].Value.ToString();
                t_name.Text = row.Cells[1].Value.ToString();
         
            }
        }

        private void t_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO product_type ( product_tID, product_tName)VALUES(@id,@name)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE product_type SET product_tName=@name WHERE product_tID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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
                cmd = new SqlCommand("DELETE FROM product_type WHERE product_tID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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
    }
}
