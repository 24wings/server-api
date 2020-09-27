using System;
using System.ComponentModel.DataAnnotations;

namespace Wings.Investment.Models.Rbac
{
    public class RbacRole
    {
        [Key]
      public long id { get; set; }

        public string roleName { get; set; }
        public string code { get; set; }
    }
}
