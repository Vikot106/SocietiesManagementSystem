using System.Data.Odbc;
using System.Data.SqlClient;
using DataMan;

namespace DBMan {
    public class DataDaoImp:DataDao {
        Conn conn = new Conn();
        private OdbcConnection con = null;
        
        private OdbcConnection getCon() {
            this.con = conn.getConnection();
            return con;
        }

        private string getName(string xh) {
            string name = null;
            return name;
        }
        
        private string getSoc(string xh) {
            string soc = null;
            return soc;
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

        public SqlDataAdapter listUser(string xh) {
            throw new System.NotImplementedException();
        }

        public bool addUser(User u) {
            throw new System.NotImplementedException();
        }

        public bool delUser(string xh) {
            throw new System.NotImplementedException();
        }

        public bool modUserA(User u) {
            throw new System.NotImplementedException();
        }

        public SqlDataAdapter listNotice(string xh) {
            throw new System.NotImplementedException();
        }

        public bool postNotice(string xh, string notice) {
            throw new System.NotImplementedException();
        }

        public SqlDataAdapter listActivity(string xh) {
            throw new System.NotImplementedException();
        }

        public bool postActivity(string xh, string year, string day, string start, string end) {
            throw new System.NotImplementedException();
        }

        public SqlDataAdapter listSoc(string xh) {
            throw new System.NotImplementedException();
        }

        public bool modUserU(User u) {
            throw new System.NotImplementedException();
        }
    }
}