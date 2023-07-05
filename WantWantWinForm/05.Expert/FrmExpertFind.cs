using prjIspanWinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIspanWinForms
{
    public class FrmExpertFind
    {
        NewIspanProjectEntities db = new NewIspanProjectEntities();
        public void Findcity(string comboxcity, string comboxtown, out int cityback, out int townback)
        {

            var q = db.Resumes.Where(x => x.Town.City.City1 == comboxcity && x.Town.Town1 == comboxtown).Select(x => new {
                townback = x.TownID.GetValueOrDefault(),
                cityback = x.Town.CityID
            });
            townback = q.First().townback;
            cityback = q.First().cityback;
        }
        public void Selectcity(int member, string comboxcity, out IEnumerable<string> cityname, out IEnumerable<string> townname)
        {
            var q = db.Resumes.Where(x => x.AccountID == member).Select(x => new {
                townname = x.Town.Town1,
                cityname = x.Town.City.City1
            });
            var qtwon = db.Towns.Where(x => x.City.City1 == comboxcity).Select(x => x);
            cityname = q.Select(x => x.cityname);
            townname = qtwon.Select(x => x.Town1);


        }

      
      
       

    }

   
   
    public class FindAccount{

        NewIspanProjectEntities db = new NewIspanProjectEntities();
        public int findaccoutid { get { return 28; } }

        public int whereresumeid { get; set; }
    }
}
