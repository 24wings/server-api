using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wings.Investment.Areas.Common.Dtos;
using Wings.Investment.Models.Rbac;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wings.Investment.Areas.Rbac.Controllers
{
    [Route("api/rbac/rbac-user")]
    public class RbacUserController : Controller
    {
       private readonly ApplicationDbContext applicationDbContext;
        public RbacUserController(ApplicationDbContext _applicationDbContext) { applicationDbContext = _applicationDbContext; }

        // GET: /<controller>/
        public PageRes<RbacUser> Index()
        {
          var users=  applicationDbContext.users.ToList();
         return   PageRes<RbacUser>.success(users, users.Count);

        }
    }
}
