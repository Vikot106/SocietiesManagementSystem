using System;
using System.Data.Odbc;
using DataMan;

namespace DBMan {
    public interface IDataDao {
        int userLogin(string xh, string mm);
        string getName(string xh);
        string getSoc(string xh);
        OdbcDataAdapter listUser(string xh,Boolean flag);
        Boolean addUser(User u);
        Boolean delUser(string xh);
        Boolean modUserA(User u,string xh);
        Boolean modPass(string xh, string sfz, string mm);

        OdbcDataAdapter listNotice(string xh);
        Boolean postNotice(string xh, string notice);

        OdbcDataAdapter listActivity(string xh);
        Boolean postActivity(string xh, string dateS, string dateE);

        OdbcDataAdapter listSoc(string xh);
        Boolean modUserU(User u,string xh);
    }
}