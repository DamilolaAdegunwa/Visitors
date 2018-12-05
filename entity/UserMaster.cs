using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitors.entity
{
   public  class UserMaster
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string mobileNo { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string emailId { get; set; }
        public DateTime dob { get; set; }
        public string pwd { get; set; }
         public RoleMaster designationRef { get; set; }
        public byte[] picture { get; set; }
        public ArrayList getUserList(int id, string usename, string mobileNo, string address, string g, string mailid, DateTime d, string pwd, string RoleMaster)
        {
            ArrayList usrList = new ArrayList();
            usrList.Add(id);
            usrList.Add(usename);
            usrList.Add(mobileNo);
            usrList.Add(address);
            usrList.Add(g);
            usrList.Add(mailid);
            usrList.Add(d);
            usrList.Add(pwd);
            usrList.Add(RoleMaster);
            return usrList;

        }

    }
}
