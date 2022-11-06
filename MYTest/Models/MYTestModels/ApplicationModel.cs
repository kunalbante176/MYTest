using MYTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYTest.Models.MYTestModels
{
    public class ApplicationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string MobileNo { get; set; }

        public string SaveApplication(ApplicationModel model)
        {
            string msg = "";
            MYTestEntities Db = new MYTestEntities();
            {
                var Applicationdata = new tblApplication()
                {
                    Name = model.Name,
                    City = model.City,
                    State = model.State,
                    Address = model.Address,
                    Pincode = model.Pincode,
                    MobileNo = model.MobileNo,
                };
                Db.tblApplications.Add(Applicationdata);
                Db.SaveChanges();
                return msg;
            }
        }
        public string 
    }
}