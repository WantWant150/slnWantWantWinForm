using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjWantWantWinForm.Properties;

namespace prjWantWantWinForm
{
    public partial class FrmMemberInfo : Form
    {
        public FrmMemberInfo()
        {
            InitializeComponent();
            //為了可以選擇性別的RadioButton
            this.radioBtnMale.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioBtnFemale.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioBtnOthers.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            //日曆自動選今日，並限定日期區間
            datePickerMemberBirthD.MaxDate = DateTime.Today;
            datePickerMemberBirthD.MinDate = new DateTime(1900, 1, 1);

            //自動載入會員資料
            NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
            MemberAccount member = (from m in dbContext.MemberAccounts
                                                 where m.AccountID == CMember.AccountID
                                                 select m).FirstOrDefault();
            if (member.Name != null)
            {
                txtBoxName.Text = member.Name;
                txtBoxIDCardNo.Text = member.IDCardNo;
                if (member.BitrhDay != null)
                {
                    datePickerMemberBirthD.Value = (DateTime)member.BitrhDay;
                }
                txtBoxUserName.Text = member.UserName;
                if(radioBtnMale.Text == member.Gender)
                {
                    radioBtnMale.Checked = true;
                }
                if (radioBtnFemale.Text == member.Gender)
                {
                    radioBtnFemale.Checked = true;
                }
                if (radioBtnOthers.Text == member.Gender)
                {
                    radioBtnOthers.Checked = true;
                }
                txtBoxPhone.Text = member.PhoneNo;
                if (member.MemberPhoto.Length != 0)
                {
                    byte[] bytes = member.MemberPhoto;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    picMemberPhoto.Image = Image.FromStream(ms);
                }
            }
        }
        CMemerInfo cmi = new CMemerInfo(); //為了使用CMemerInfo方法，實作
        NewIspanProjectEntities  dbContext = new NewIspanProjectEntities();
        private RadioButton selectedrb; //為了取得性別選了哪個RadioBox
        private void radioButton_CheckedChanged(object sender, EventArgs e) //取得性別選取項值(selectedrb.Text)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedrb = rb;
            }
        }

        private void btnSaveMemberInfo_Click(object sender, EventArgs e) //註冊按鈕：先判斷資料格式，再上傳
        {
            try
            {
                //判斷txtBox是否有填寫&&符合要求，Result==6才符合
                int tfResult =
            cmi.CheckName(txtBoxName.Text, label5) +
            cmi.CheckIDCardNo(txtBoxIDCardNo.Text, label8) +
            cmi.CheckUserName(txtBoxUserName.Text, label9) +
            cmi.CheckPhoneNo(txtBoxPhone.Text, label11) +
            cmi.CheckBD(datePickerMemberBirthD.Value.Date, label12) +
            cmi.CheckGender(selectedrb, label10);

                //圖片不強制上傳
                Byte[] bytes;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                if (picMemberPhoto.Image != null)
                {
                    this.picMemberPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                bytes = ms.GetBuffer();

                if (tfResult == 6)
                {
                    //修改資料表MemberAccounts的資料列(因為共用表，有帳號就有一筆資料在裡面了，只是個人資料的欄位值為Null)
                    var member = (from m in this.dbContext.MemberAccounts
                                  where m.AccountID == CMember.AccountID
                                  select m).FirstOrDefault();

                    if (member == null) return;
                    member.Name = txtBoxName.Text;
                    member.IDCardNo = txtBoxIDCardNo.Text;
                    member.BitrhDay = datePickerMemberBirthD.Value.Date;
                    member.Gender = selectedrb.Text;
                    member.UserName = txtBoxUserName.Text;
                    member.PhoneNo = txtBoxPhone.Text;
                    member.MemberPhoto = bytes;
                    this.dbContext.SaveChanges();
                    MessageBox.Show("完成修改基本資料~");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("再看一下欄位喔~~");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.picMemberPhoto.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void FrmMemberInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
