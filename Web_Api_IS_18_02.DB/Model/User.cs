using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_IS_18_02.DB.Model
{
        public class User
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
        }
}
