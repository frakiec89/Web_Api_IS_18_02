using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_IS_18_02.Controllers.Service;

namespace Web_Api_IS_18_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
          IUserServis _userServis = Addiction.GetUserServis();

          [HttpPost("RegistrationUser")]
          public string RegistrationUser (Model.User user)
          {
             try
             {
                int count = _userServis.AddUser(user);
                return "Добавлено + " +  count.ToString() +" Юзер";
             }
              catch
             {
                return "Error";
             }
            
          }
    }
}
