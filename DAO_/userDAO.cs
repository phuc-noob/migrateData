using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_
{
    public class userDAO
    {
        public int Id { get; set; }
        public String first_name { get; set; }
        public string last_name { get; set; }
        public string middleInitial { get; set; }
        public string address { get; set; }
        public string suite { get; set; }
        public int zipCodeId { get; set; }
        public string email { get; set; }
        public string homePhone { get; set; }
        public string mobilePhone { get; set; }
        public string facebook { get; set; }
        public string photoLink { get; set; }
        public string ssn { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public int tablet_access { get; set; }
        public int opennessAccess { get; set; }
        public string switter { get; set; }
        public int officeHouerAccess { get; set; }
        public string otherName { get; set; }
        public int carrier { get; set; }
        public int countryCode { get; set; }
        public string patientId { get; set; }
        public string DoB { get; set; }
        public string imgFolder { get; set; }

        public userDAO(string imgFolder)
        {
            this.imgFolder = imgFolder;
        }

        public userDAO(int id, string first_name, string last_name, string middleInitial, string address, string suite, int zipCodeId, string email, string homePhone, string mobilePhone, string facebook, string photoLink, string ssn, string userName, string password, string userType, int tablet_access, int opennessAccess, string switter, int officeHouerAccess, string otherName, int carrier, int countryCode, string patientId, string doB)
        {
            Id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.middleInitial = middleInitial;
            this.address = address;
            this.suite = suite;
            this.zipCodeId = zipCodeId;
            this.email = email;
            this.homePhone = homePhone;
            this.mobilePhone = mobilePhone;
            this.facebook = facebook;
            this.photoLink = photoLink;
            this.ssn = ssn;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
            this.tablet_access = tablet_access;
            this.opennessAccess = opennessAccess;
            this.switter = switter;
            this.officeHouerAccess = officeHouerAccess;
            this.otherName = otherName;
            this.carrier = carrier;
            this.countryCode = countryCode;
            this.patientId = patientId;
            DoB = doB;
        }

        public userDAO()
        {
        }
    }
}
