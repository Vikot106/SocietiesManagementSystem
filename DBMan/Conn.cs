using System.Data.Odbc;

namespace DBMan {
    public class Conn {
        public OdbcConnection getConnection() {
            string strcon = @"DSN=soc";
            OdbcConnection con = new OdbcConnection(strcon);
            con.Open();
            return con;
        }

        public void Close(OdbcConnection con) {
            con.Close();
        }
    }
}