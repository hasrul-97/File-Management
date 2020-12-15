using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserProfile.Query.Abstraction.BusinessLogic;

namespace UserProfile.Query.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IBusinessManager _businessManager;
        public UserProfileController(IBusinessManager businessManager)
        {
            _businessManager = businessManager;
        }
    }
}
