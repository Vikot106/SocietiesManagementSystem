using System;
using System.Data.Odbc;
using DataMan;

namespace DBMan {
    public class DataDaoImpl:IDataDao {
        Conn conn = new Conn();
        private OdbcConnection con = null;
        OdbcDataAdapter adapter = null;
        
        private OdbcConnection getCon() {
            this.con = conn.getConnection();
            return con;
        }

        public string getName(string xh) {
            string name = "";
            OdbcConnection con = getCon();
            string sql = "select * from tb_user where sid = " + xh + "";
            OdbcCommand com = new OdbcCommand(sql,con);
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.Read()) {
                name = dr.GetString(0);
            }
            return name;
        }
        
        public string getSoc(string xh) {
            string soc = "";
            OdbcConnection con = getCon();
            string sql = "select * from tb_user where sid = " + xh + "";
            OdbcCommand com = new OdbcCommand(sql,con);
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.Read()) {
                soc = dr.GetString(6);
            }
            return soc;
        }
        
        public int userLogin(string xh, string mm) {
            int flag = 0;
            OdbcConnection con = getCon();
            string sql = "select * from tb_user where sid = " + xh + " and pass = '" + mm + "'";
            OdbcCommand com = new OdbcCommand(sql,con);
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.Read()) {
                if (dr.GetBoolean(9)) {
                    flag = 2 ;
                }
                else {
                    flag = 1;
                }
            }
            return flag;
        }

        public OdbcDataAdapter listUser(string xh,Boolean flag) {
            string soc = getSoc(xh);
            OdbcConnection con = getCon();
            string sql = "";
            if (flag) {
                sql = "select uname as 姓名,sid as 学号,gender as 性别,age as 年龄,phone as 联系方式,depart as 系别,idenity as 身份证号 from tb_user where soc = '" + soc + "'";
            }
            else {
                sql = "select uname as 姓名,sid as 学号,gender as 性别,phone as 联系方式,depart as 系别 from tb_user where soc = '" + soc + "'";
            }
            adapter = new OdbcDataAdapter(sql,con);
            return adapter;
        }

        public bool addUser(User u) {
            OdbcConnection con = getCon();
            string sql = "insert into tb_user values('"+u.Uname+"','"+u.Sid+"','"+u.Gender+"','"+u.Age+"','"+u.Phone+"','"+u.Depart+"','"+u.Soc+"','"+u.Idenity+"','"+u.Upass+"',0)";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                throw e;
                return false;
            }
        }

        public bool delUser(string xh) {
            OdbcConnection con = getCon();
            string sql = "delete from tb_user where sid = " + xh + "";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public bool modUserA(User u,string xh) {
            OdbcConnection con = getCon();
            string sql = "update tb_user set uname = '"+u.Uname+"',age = "+u.Age+",phone = "+u.Phone+",depart = '"+u.Depart+"' where sid = '"+xh+"'";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public bool modPass(string xh, string sfz, string mm) {
            OdbcConnection con = getCon();
            string sql = "update tb_user set pass = '"+mm+"' where (sid = "+xh+" and idenity = "+sfz+")";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                throw e;
                return false;
            }
        }

        public OdbcDataAdapter listNotice(string xh) {
            string soc = getSoc(xh);
            OdbcConnection con = getCon();
            string sql = "select soc as 社团,user as 发布者,date as 发布时间,notice as 通知 from tb_notice where soc = '" + soc + "'";
            adapter = new OdbcDataAdapter(sql,con);
            return adapter;
        }

        public bool postNotice(string xh, string notice) {
            string name = getName(xh);
            string soc = getSoc(xh);
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            OdbcConnection con = getCon();
            string sql = "insert into tb_notice values('"+soc+"','"+name+"','"+date+"','"+notice+"')";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public OdbcDataAdapter listActivity(string xh) {
            string soc = getSoc(xh);
            OdbcConnection con = getCon();
            string sql = "select soc as 社团,dateS as 开始时间,dateE as 结束时间 from tb_active where soc = '" + soc + "'";
            adapter = new OdbcDataAdapter(sql,con);
            return adapter;
        }

        public bool postActivity(string xh, string dateS, string dateE) {
            string soc = getSoc(xh);
            OdbcConnection con = getCon();
            string sql = "insert into tb_active values('"+soc+"','"+dateS+"','"+dateE+"')";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public OdbcDataAdapter listSoc(string xh) {
            string soc = getSoc(xh);
            OdbcConnection con = getCon();
            string sql = "select tb_manager.soc as 社团名称,tb_manager.manager as 社团负责人,tb_soc.teacher as 指导教师,tb_soc.sdate as 创立时间 from tb_manager inner join tb_soc on tb_manager.soc = tb_soc.soc";
            adapter = new OdbcDataAdapter(sql,con);
            return adapter;
        }

        public bool modUserU(User u,string xh) {
            OdbcConnection con = getCon();
            string sql = "update tb_user set age = '"+u.Age+"',phone = "+u.Phone+",depart = '"+u.Depart+"',idenity = "+u.Idenity+",pass = "+u.Upass+" where sid = '"+xh+"'";
            OdbcCommand com = new OdbcCommand(sql,con);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public OdbcDataAdapter listAllSoc() {
            OdbcConnection con = getCon();
            string sql = "select soc from tb_soc";
            adapter = new OdbcDataAdapter(sql,con);
            return adapter;
        }
    }
}