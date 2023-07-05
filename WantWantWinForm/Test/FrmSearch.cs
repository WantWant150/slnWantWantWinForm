using prjIspanWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
            SreachCity(comboBoxTaskCity);
            SreachCity(comboBoxExpertCity);
            SkillsShow(comboBoxTaskSkill);
        }


        #region 顯示縣市
        private void SreachCity(ComboBox comboBox)
        {
            try
            {
                NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                var q = from c in dbContext.Cities
                        select c.City1;

                foreach (var c in q)
                {
                    comboBox.Items.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region 顯示專長
        private void SkillsShow(ComboBox comboBox)
        {
            try
            {
                NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                var qskill = /*from x in dbContext.ResumeSkill.AsEnumerable()*/
                    from r in dbContext.ResumeSkills.AsEnumerable()
                        //where x.Resume.AccountID == member
                    select new
                    {
                        Myskilldetail = r.Skill.SkillName,
                        Myskill = r.Skill.SkillType.SkillTypeName
                    };

                foreach (var c in qskill)
                {
                    comboBox.Items.Add(c);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        private void comboBoxExpertCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SkillsShow();
        }
    }
}

