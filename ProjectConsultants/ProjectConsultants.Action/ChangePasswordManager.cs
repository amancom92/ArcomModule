using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsultants.Action
{
    public class ChangePasswordManager
    {
        public bool ChangePassword(UserEntity userDetails)
        {
            var isSuccess = new ChangePasswordDa().ChangePassword(userDetails);
            return isSuccess;
        }
    }
}
