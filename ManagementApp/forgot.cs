using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBMan;

namespace ManagementApp {
    public partial class forgot : Form {
        IDataDao dd = new DataDaoImpl();
        
        public forgot() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "" || textBox3.Text == "") {
                MessageBox.Show("密码不能为空！");
            }else if (!textBox1.Text.Equals(textBox3.Text)) {
                MessageBox.Show("两次密码输入不匹配！");
            }else if (dd.modPass(textBox4.Text, textBox2.Text, textBox1.Text)) {
                MessageBox.Show("修改成功！");
            }else {
                MessageBox.Show("修改失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
