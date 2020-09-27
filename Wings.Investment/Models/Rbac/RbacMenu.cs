using System;
namespace Wings.Investment.Models.Rbac
{
    public class RbacMenu
    {
        public long id { get; set; }

        public string name { get; set; }

        public long parentId { get; set; }

        public string link { get; set; }


        public DateTime createAt { get; set; } = DateTime.Now;
    }
}
