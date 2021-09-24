using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_IS_18_02.Controllers.Service;
using Web_Api_IS_18_02.DB;
using Web_Api_IS_18_02.Model;

namespace Web_Api_IS_18_02.Service
{
    public class UserServisDB : IUserServis
    {
        public int AddUser(User user)
        {
            EfDbContext context = new EfDbContext();
            context.Users.Add(GetUser(user));
            return context.SaveChanges();

        }

        private DB.Model.User GetUser (Model.User user)
        {
            return new DB.Model.User
            {
                Password = user.Password,
                Login = user.Login,
                Name = user.Name
            };
        }
    }
}
