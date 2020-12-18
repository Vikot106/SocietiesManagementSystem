﻿using System;
using System.Windows.Forms;
using DBMan;

namespace ManagementApp {
    public partial class Login : Form {
        private userDAO ud = new userDAO();

        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == null || textBox2.Text == null) {
                MessageBox.Show("学号与密码不能为空");
            }
            else if ((ud.userLogin(textBox1.Text, textBox2.Text)) == 1) {
                userForm uf = new userForm();
                uf.Show();
                this.Hide();
            }
            else if ((ud.userLogin(textBox1.Text, textBox2.Text)) == 2) {
                userForm uf = new userForm();
                uf.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("您的学号与密码不匹配");
            }
        }

        private void label3_Click(object sender, EventArgs e) {
            register reg = new register();
            reg.Show();
        }

        private void label4_Click(object sender, EventArgs e) {
            forgot fg = new forgot();
            fg.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}