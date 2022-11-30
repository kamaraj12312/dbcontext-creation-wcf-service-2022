
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.ServiceModel.Web;
using System.Text;

namespace mydbcontext
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public readonly EndocDataContext endocDataContext;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["endoc"].ConnectionString;

        public Service1(EndocDataContext _endocDataContext)
        {
            endocDataContext = _endocDataContext;
        }
        public Service1()
        {

        }
        public List<HolidaySetup> GetHolidaySetup()
        {
            EndocDataContext obj = new EndocDataContext(ConnectionString);
            var prodects = (from s in obj.HolidaySetups
                            select s).ToList();
            return prodects;
        }
    }
}
