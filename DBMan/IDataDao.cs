using System;
using System.Data.SqlClient;
using DataMan;

namespace DBMan {
    public interface IDataDao {
        int userLogin(string xh, string mm);
        SqlDataAdapter listUser(string xh);
        Boolean addUser(User u);
        Boolean delUser(string xh);
        Boolean modUserA(User u);

        SqlDataAdapter listNotice(string xh);
        Boolean postNotice(string xh, string notice);

        SqlDataAdapter listActivity(string xh);
        Boolean postActivity(string xh,string year, string day, string start, string end);

        SqlDataAdapter listSoc(string xh);
        Boolean modUserU(User u);
    }
}