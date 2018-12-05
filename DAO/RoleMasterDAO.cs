using System.Data;
using Visitors.entity;

namespace Visitors.DAO
{
    interface RoleMasterDAO
    {
        void insertRole(RoleMaster roleMasterRef);
        void updaterole(RoleMaster roleMasterRef);
        void deleteRole(RoleMaster roleMasterRef);
        RoleMaster findbyprimaryKey(string roleName);
        //  List<ArrayList> getRoleList();
        DataTable selectAll();

    }
}
