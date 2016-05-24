using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsultants.Action
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangePasswordManager
    {
        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="userDetails">The user details.</param>
        /// <returns></returns>
        public bool ChangePassword(UserEntity userDetails)
        {
            var isSuccess = new ChangePasswordDa().ChangePassword(userDetails);
            return isSuccess;
        }
    }
}
