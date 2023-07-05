using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWantWantWinForm
{
    public static class CLoginInfo
    {
        public static int lastFailCount //取得會員上一次登入時的失敗次數記錄
        {
            get {
                NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                int lastFailC = (from loginHis in dbContext.LoginHistories
                                 where loginHis.AccountID == CMember.AccountID
                                 orderby loginHis.LoginID descending
                                 select loginHis.PasswordFailCount).FirstOrDefault();
                return lastFailC; 
            }
          
        }
       

        public static int accountID //同登入時的AccountID
        {
            get
            {
                return CMember.AccountID;
            }
        }
       
        public static Boolean memInfoFinished //以會員的Name資料判斷是否填寫完成會員資料
        {
            get
            {
                NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                string memInfo = (from mem in dbContext.MemberAccounts
                                        where mem.AccountID == CMember.AccountID
                                        select mem.Name).FirstOrDefault();
                if (memInfo == null)
                {
                    return false;
                }
                else
                    return true;
            }
        }
        public static void setLogHis(LoginHistory loghis,Boolean loginsf) //設定"LoginHistory"資料表的欄位值的方法
        {
            loghis.AccountID = CMember.AccountID;
            loghis.LoginS_F = loginsf; //true是登入成功；false是登入失敗
            loghis.LoginTime = DateTime.Now;
            if(loginsf==true)
            {
                loghis.PasswordFailCount = 0; //登入成功次數歸零
            }
            else
            {
                loghis.PasswordFailCount = 1+CLoginInfo.lastFailCount; //登入失敗需要計次
            }
            loghis.MemberInfoFinished = CLoginInfo.memInfoFinished;
        }
    }
}
