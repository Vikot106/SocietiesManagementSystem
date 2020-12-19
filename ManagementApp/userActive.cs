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
    public partial class userActive : Form {
        IDataDao dd = new DataDaoImpl();
        private string xh;
        public userActive(string xh) {
            this.xh = xh;
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e) {
            string dateS = dateTimePicker1.Value.ToString("MM-dd HH:mm");
            string dateE = dateTimePicker2.Value.ToString("MM-dd HH:mm");
            if (dd.postActivity(xh, dateS, dateE)) {
                MessageBox.Show("发布成功！");
            }
            else {
                MessageBox.Show("发布失败！");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void userActive_Load(object sender, EventArgs e) {
            
        }
    }
}
