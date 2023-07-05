using prjIspanWinForms.MemberInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
            GenerateValidationCode();
            DisplayValidationCode();
        }
        public FrmForgetPassword(bool isCloseVisible)
        {
            InitializeComponent();
            GenerateValidationCode();
            DisplayValidationCode();
            this.ControlBox = isCloseVisible; // 禁用控制框

        }
        CValidateCode validateCode = new CValidateCode();
        private string validationCode; // 驗證碼

        private void GenerateValidationCode()
        {
            validationCode = validateCode.GenerateCheckCode(); // 產生驗證碼的內容(4碼英文大寫&數字)
        }

        private void DisplayValidationCode()
        {

            int w = 63; // 預設寬度
            int h = 30; // 預設高度
            Bitmap image = validateCode.CreateCheckCodeImage(validationCode, w, h); // 建立驗證碼圖片

            picValidateCode.Image = image;
            picValidateCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private bool ValidateInput(string userInput) //判斷驗證碼是否正確
        {
            string userInputUpper = userInput.ToUpper(); //這樣就不區分英文大小寫
            bool isValid = (userInputUpper == validationCode); // 判斷使用者輸入的字串是否與驗證碼相符
            return isValid;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {           
            if (ValidateInput(txtBoxValidateCode.Text)) //正確的話
            {
                NewIspanProjectEntities  dbContext = new NewIspanProjectEntities();
                int memberForgeterID= (from m in dbContext.MemberAccounts
                                  where m.Email == txtBoxMemberEmail.Text
                                  select m.AccountID).FirstOrDefault();
                if(memberForgeterID > 0) //如果有這組帳號(Email)
                {
                    CMember.AccountID = memberForgeterID;
                    FrmRenewPassword frmrp = new FrmRenewPassword(txtBoxMemberEmail.Text); //為了將使用者Email帶過去下一張表單
                    //frmrp.MdiParent = this.MdiParent;
                    frmrp.TopMost = true;
                    frmrp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("無此帳號");
                }
            }
            else //輸入錯誤後自動更新一次圖片
            {
                MessageBox.Show($"驗證碼不正確");
                UpdateValidationCode();
            }
        }

        private void btnChangeValidateCode_Click(object sender, EventArgs e)
        {
            UpdateValidationCode();
        }
        private void UpdateValidationCode()
        {
            int w = 63; // 預設寬度
            int h = 30; // 預設高度
            validationCode = validateCode.GenerateCheckCode(); // 更新類級別的 validationCode 成員
            Bitmap image = validateCode.CreateCheckCodeImage(validationCode, w, h); // 建立驗證碼圖片

            // 顯示圖片在 PictureBox 控制元件上
            picValidateCode.Image = image;
            picValidateCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
