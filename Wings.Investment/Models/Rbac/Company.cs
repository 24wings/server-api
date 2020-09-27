using System;
namespace Wings.Investment.Models.Rbac
{
    public class Company
    {
        public long id { get; set; }

        public string companyName { get; set; }

        public DateTime createAt { get; set; } = DateTime.Now;

    }
}
