using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsultants.Action
{
   public class Register
    {
        public UserEntity Add(UserEntity user)
        {
            var userregister = new ProjectInformationDa().Register(user);
            return userregister;
        }
    }
}
