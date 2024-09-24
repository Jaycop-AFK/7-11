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
    public partial class FormUser : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344_14;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormUser()
        {
            InitializeComponent();
        }


        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", t_id.Text);
            cmd.Parameters.AddWithValue("name", t_name.Text);
            cmd.Parameters.AddWithValue("lastname", t_lastname.Text);
            cmd.Parameters.AddWithValue("email", t_email.Text);
            cmd.Parameters.AddWithValue ("username", t_username.Text);
            cmd.Parameters.AddWithValue("password", t_password.Text);
            cmd.Parameters.AddWithValue("search", t_search.Text);
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._7_11DataSet.users);
            
        }

        private void t_lastname_TextChanged(object sender, EventArgs e)
        {

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
                t_lastname.Text = row.Cells[2].Value.ToString();
                t_email.Text = row.Cells[3].Value.ToString();
                t_username.Text = row.Cells[4].Value.ToString();
                t_password.Text = row.Cells[5].Value.ToString();
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE users SET user_firstName=@name,user_lastName=@lastname,user_email=@email,user_name@username,user_password@password WHERE user_ID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
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
                cmd = new SqlCommand("INSERT INTO users ( user_ID, user_firstName, user_lastName, user_email,user_name,user_password)VALUES(@id,@name,@lastname,@email,@username,@password)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
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
                cmd = new SqlCommand("DELETE FROM users WHERE user_ID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
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

        private void b_search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM users WHERE user_ID LIKE @search+'%' OR user_name LIKE @search+'%' OR user_name LIKE @search+'%' OR user_email LIKE @search+'%'", conn);
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
