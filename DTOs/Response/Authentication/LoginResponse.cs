using BusinessObjects;
using BusinessObjects.Enums;
using BusinessObjects.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Response.Authentication
{
    public class LoginResponse
    {
        public string accessToken { get; set; }
        public int id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public string profileImage { get; set; }
        public string phoneNumber { get; set; }
        public RoleEnum Role { get; set; }

        public LoginResponse(int id, string fullName, string email, string gender, DateTime dateOfBirth, string address, string profileImage, string phoneNumber, RoleEnum role)
        {
            id = id;
            fullName = fullName;
            email = email;
            gender = gender;
            dateOfBirth = dateOfBirth;
            address = address;
            profileImage = profileImage;
            phoneNumber = phoneNumber;
            Role = role;
        }
    }
}
