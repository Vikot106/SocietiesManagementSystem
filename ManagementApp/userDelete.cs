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
    public partial class userDelete : Form {
        IDataDao dd = new DataDaoImpl();
        public userDelete() {
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                if (dd.delUser(textBox1.Text)) {
                    MessageBox.Show("删除成功！");
                }
                else {
                    MessageBox.Show("删除失败 请检查输入信息");
                }
            }
            else {
                MessageBox.Show("请勾选确认选项");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
