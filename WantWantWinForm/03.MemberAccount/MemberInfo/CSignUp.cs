using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Label = System.Windows.Forms.Label;


namespace prjIspanWinForms
{
    internal class CSignUp
    {

        public Boolean CheckPassword(string password, Label lab) //暱稱僅能使用英文、數字、特殊自元(並顯示警告)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\p{P}\p{S}]+$");
            if (regex.IsMatch(password))
            {
                lab.Text = "";
                return true;
            }
            else
            {
                lab.Text = "密碼僅限英文數字特殊字元";
                return false;
            }
        }

        public Boolean CheckPasswordSame(string password, string password2, Label lab) //新密碼二次確認(並顯示警告)
        {
            if (password != password2)
            {
                lab.Text = "與密碼不同";
                return false;
            }
            else
            {
                lab.Text = "";
                return true;
            }
        }
    }
} 
