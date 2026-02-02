using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   
    public class UserDTO
    {
        private readonly QLNHANSUEntities context;
        public UserDTO()
        {
            context = new QLNHANSUEntities();
        }

        public tb_User Login(string username, string password)
        {
            var user = context.tb_User.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
