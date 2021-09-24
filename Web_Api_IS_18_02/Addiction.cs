using System;
using Web_Api_IS_18_02.Controllers.Service;

namespace Web_Api_IS_18_02
{
    internal class Addiction
    {
        internal static IUserServis GetUserServis()
        {
            return new Service.UserServisDB(); 
            // todo наша зависимость
        }
    }
}