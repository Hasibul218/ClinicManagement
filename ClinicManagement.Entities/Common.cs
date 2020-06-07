using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{

    public class Common
    {
        private string userid;
        private string username;
        private string gender;
        private string phone;
        private string email;
        private string dateOfBirth;

        public string Divission { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }


        public Common()
        { }

        //for admin  cons
        public Common(string userid, string username)
        {
            this.Userid = userid;
            this.Username = username;
        }

        //clinic cons
        public Common(string userid,string username, string divission, string district, string thana, string phone)
        {
            this.Userid = userid;
            this.Username = username;
            this.Phone = phone;
            this.Divission = divission;
            this.District = district;
            this.Thana = thana;
            
        }
        //for patient and doctor cons
        public Common(string userid,string username, string gender, string phone, string email, string dateOfBirth, string divission, string district, string thana)
        {
            this.Userid = userid;
            this.Username = username;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Divission = divission;
            this.District = district;
            this.Thana = thana;
        }

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
}
