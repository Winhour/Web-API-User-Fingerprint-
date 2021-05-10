using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User_Data
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // Foreign Key
        public int Fingerprint_Id { get; set; }
    }
}