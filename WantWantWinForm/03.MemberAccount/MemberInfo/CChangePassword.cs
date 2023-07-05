using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace prjIspanWinForms
{
    public static class CChangePassword
    {

        public static Boolean checkPassword(TextBox textbox, Label label) //驗證原本密碼(並顯示警告)
        {
            NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
            MemberAccount loginInfo = (from m in dbContext.MemberAccounts
                                       where m.AccountID == CMember.AccountID
                                       select m).FirstOrDefault();

            if (textbox.Text == loginInfo.Password)
            {
                label.Text = "";
                return true;
            }
            else
            {
                label.Text = "與目前密碼不同";
                MessageBox.Show("請再次確認欄位內容");
                return false;
            }
        }
        public static Boolean checkChangeNew(TextBox textbox, Label label) //新密碼不能與舊密碼相同(並顯示警告)
        {
            NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
            MemberAccount loginInfo = (from m in dbContext.MemberAccounts
                                       where m.AccountID == CMember.AccountID
                                       select m).FirstOrDefault();

            if (textbox.Text == loginInfo.Password)
            {
                label.Text = "密碼不能與原密碼相同";
                MessageBox.Show("請再次確認欄位內容");
                return false;
            }
            else
            {
                label.Text = "";
                return true;
            }
        }

        public static Boolean checkPasswordsSame(TextBox textbox, TextBox textboxconfirm, Label label, Label label2) //新密碼二次確認(並顯示警告)
        {
            //密碼僅限英文、數字、特殊字元
            Regex regex = new Regex(@"^[a-zA-Z0-9\p{P}\p{S}]+$");
            if (regex.IsMatch(textbox.Text))
            {
                //新密碼二次確認，都要輸入同一組字串
                if (textbox.Text == textboxconfirm.Text)
                {
                    label.Text = "";
                    label2.Text = "";
                    return true;
                }
                else
                {
                    label2.Text = "與新密碼不同";
                    MessageBox.Show("請再次確認欄位內容");
                    return false;
                }
            }
            else
            {
                label.Text = " 密碼僅限英文、數字、特殊字元";
                MessageBox.Show("請再次確認欄位內容");
                return false;
            }
        }
    }
}
