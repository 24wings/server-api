using System;
using System.ComponentModel.DataAnnotations;

namespace Wings.Investment.Models.Rbac
{
    public class RbacUser
    {
        [Key]
        public long id { get; set; }

        public string nickname { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public DateTime createAt { get; set; } = DateTime.Now;


       
    }
}
