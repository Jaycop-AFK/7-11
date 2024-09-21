namespace _7_11
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_login = new System.Windows.Forms.Button();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.DarkOrange;
            this.b_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.Location = new System.Drawing.Point(86, 296);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(112, 37);
            this.b_login.TabIndex = 7;
            this.b_login.Text = "login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // t_password
            // 
            this.t_password.BackColor = System.Drawing.Color.DarkGreen;
            this.t_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password.ForeColor = System.Drawing.Color.Orange;
            this.t_password.Location = new System.Drawing.Point(71, 245);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(140, 35);
            this.t_password.TabIndex = 6;
            this.t_password.Text = "password";
            this.t_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password.UseSystemPasswordChar = true;
            this.t_password.TextChanged += new System.EventHandler(this.t_password_TextChanged);
            // 
            // t_username
            // 
            this.t_username.BackColor = System.Drawing.Color.DarkGreen;
            this.t_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_username.ForeColor = System.Drawing.Color.Orange;
            this.t_username.Location = new System.Drawing.Point(71, 189);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(140, 35);
            this.t_username.TabIndex = 5;
            this.t_username.Tag = "";
            this.t_username.Text = "username";
            this.t_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_username.TextChanged += new System.EventHandler(this.t_username_TextChanged);
            this.t_username.Enter += new System.EventHandler(this.t_username_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_7_11.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(86, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(299, 363);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

