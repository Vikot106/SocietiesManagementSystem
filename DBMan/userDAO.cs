using System;
using System.Data.Odbc;

namespace DBMan {
    public class userDAO {
        Conn conn = new Conn();
        private OdbcConnection con = null;
        
        public OdbcConnection getCon() {
            this.con = conn.getConnection();
            return con;
        }
        
        public int userLogin(string xh, string mm) {
            int flag = 0;
            OdbcConnection con = getCon();
            string sql = "select * from tb_user where sid = " + xh + " and pass = " + mm + "";
            OdbcCommand com = new OdbcCommand(sql,con);
            OdbcDataReader dr = com.ExecuteReader();
            if (dr.Read()) {
                if (dr.GetBoolean(10)) {
                    flag = 2 ;
                }
                else {
                    flag = 1;
                }
            }
            return flag;
        }
    }
}