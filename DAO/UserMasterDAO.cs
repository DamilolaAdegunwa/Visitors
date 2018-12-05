using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitors.entity;

namespace Visitors.DAO
{
    interface UserMasterDAO
    {
        void insertUser(UserMaster userMasterRef);
        void updateUser(UserMaster userMasterRef);
        void deleteUser(UserMaster userMasterRef);
        UserMaster findbyprimaryKey(int userId);
        List<string> getRoleName();
        List<ArrayList> getUsrList(UserMaster usermasterRef);
        //   UserMaster login(UserMaster usermasterRef);
        int login(UserMaster usermasterRef);
        DataTable selectAll();

    }
}
