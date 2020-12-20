using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMan;
using DBMan;

namespace ManagementApp
{
    public partial class register : Form
    {
        IDataDao dd = new DataDaoImpl();
        OdbcDataAdapter da;
        DataSet ds;

        public register()
        {
            InitializeComponent();
        }

        private void reg_Click_1(object sender, EventArgs e) {
            User u = new User();
            u.Uname = uname.Text;
            u.Sid = sid.Text;
            u.Gender = gender.Text;
            u.Age = age.Text;
            u.Phone = phone.Text;
            u.Depart = depart.Text;
            u.Soc = soc.Text;
            u.Idenity = idenity.Text;
            u.Upass = pass.Text;
            if (dd.addUser(u)) {
                MessageBox.Show("注册成功！");
            }
            else {
                MessageBox.Show("注册失败！");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void soc_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void register_Load(object sender, EventArgs e) {
            da = dd.listAllSoc();
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                soc.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }
    }
}
