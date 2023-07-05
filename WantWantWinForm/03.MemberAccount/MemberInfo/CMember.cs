using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjWantWantWinForm
{
    public static class CMember
    {

        public static int AccountID { get; set; }
        public static int MemberTotalPoint { get; set; }
        public static string Name { get; set; }
        public static void getMemberID(MemberAccount loginInfo) //取得登入的會員ID
        {
            CMember.AccountID = loginInfo.AccountID;
        }
        public static void getMemInfo(int memberID) //取得登入的會員資訊
        {
            NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
            var loginmem = (from member in dbContext.MemberAccounts
                             where member.AccountID == memberID
                             select new {member.Name, member.MemberTotalPoint}).FirstOrDefault();
            CMember.Name = loginmem.Name;
            CMember.MemberTotalPoint = loginmem.MemberTotalPoint;
        }
    }
}
