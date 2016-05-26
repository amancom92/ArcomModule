﻿

using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System.Web.UI.WebControls;

namespace ProjectConsultants.Action
{
    public class LoginManager
    {
        /// <summary>
        /// Logins the authentication.
        /// </summary>
        /// <param name="userDetails">The user details.</param>
        /// <returns></returns>
        public UserEntity AuthenticateLogin(UserEntity userDetails)
        {
            var userDetail = new UserEntity();
            try
            {
                userDetail = new UserDa().AuthenticateLogin(userDetails);
            }
            catch
            {

            }

            return userDetail;
        }
    }
}