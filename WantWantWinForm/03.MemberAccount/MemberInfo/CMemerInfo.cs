using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;


namespace prjWantWantWinForm
{
    public class CMemerInfo
    {
        public int CheckUserName(string username, Label lab) //暱稱僅能使用英文、數字、特殊自元
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\p{P}\p{S}]+$");
            if (regex.IsMatch(username))
            {
                lab.Text = "";
                return 1;
            }
            else
            {
                lab.Text =  "請填入英文數字特殊字元";
                return 0;
            }
        }
        public int CheckName(string name, Label lab)  //確定姓名為中文繁體
        {
            if (name.Length > 1)
            {
                Regex regex = new Regex(@"^[\u4E00-\u9FFF]+$");
                if (regex.IsMatch(name))
                {
                    lab.Text = "";
                    return 1;
                }
                else
                {
                    lab.Text = "請以繁體中文輸入";
                    return 0;
                }
            }
            else
            {
                lab.Text = "請輸入姓名";
                return 0;
            }
        }
        public int CheckIDCardNo(string id, Label lab) //確定身分證字號格式
        {

            var regex = new Regex("^[A-Z]{1}[0-9]{9}$");
            if (!regex.IsMatch(id))
            {
                //Regular Expression 驗證失敗，回傳 ID 錯誤
                lab.Text = "身分證基本格式錯誤";
                return 0;
            }

            //除了檢查碼外每個數字的存放空間 
            int[] seed = new int[10];

            //建立字母陣列(A~Z)
            //A=10 B=11 C=12 D=13 E=14 F=15 G=16 H=17 J=18 K=19 L=20 M=21 N=22
            //P=23 Q=24 R=25 S=26 T=27 U=28 V=29 X=30 Y=31 W=32  Z=33 I=34 O=35            
            string[] charMapping = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "W", "Z", "I", "O" };
            string target = id.Substring(0, 1); //取第一個英文數字
            for (int index = 0; index < charMapping.Length; index++)
            {
                if (charMapping[index] == target)
                {
                    index += 10;
                    //10進制的高位元放入存放空間   (權重*1)
                    seed[0] = index / 10;

                    //10進制的低位元*9後放入存放空間 (權重*9)
                    seed[1] = (index % 10) * 9;

                    break;
                }
            }
            for (int index = 2; index < 10; index++) //(權重*8~1)
            {   //將剩餘數字乘上權數後放入存放空間                
                seed[index] = Convert.ToInt32(id.Substring(index - 1, 1)) * (10 - index);
            }
            //檢查是否符合檢查規則，10減存放空間所有數字和除以10的餘數的個位數字是否等於檢查碼            
            //(10 - ((seed[0] + .... + seed[9]) % 10)) % 10 == 身分證字號的最後一碼   
            if ((10 - (seed.Sum() % 10)) % 10 != Convert.ToInt32(id.Substring(9, 1)))
            {
                lab.Text = "請輸入正確身分證";
                return 0;
            }

            lab.Text = "";
            return 1;
        }
        public int CheckPhoneNo(string phoneNo, Label lab) //確認電話號碼
        {
            var regex = new Regex("09[0-9]{8}$");
            if (!regex.IsMatch(phoneNo))
            {
                lab.Text = "請輸入正確手機號碼";
                return 0;
            }
            lab.Text = "";
            return 1;
        }
        public int CheckBD(DateTime date, Label lab)//確認生日是否有改(不是今天就可以)
        {
            if(date==DateTime.Now.Date)
            {
                lab.Text = "請選擇生日";
                return 0;
            }
            else
            {
                lab.Text = "";
                return 1;
            }
        }
        public int CheckGender(RadioButton radio, Label lab) //確認性別有選擇
        {
            if (radio!=null)
            {
                lab.Text = "";
                return 1;
            }
            else
            {
                lab.Text = "請選擇性別";
                return 0;
            }
        }
    }
}
