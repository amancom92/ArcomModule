

using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;

namespace ProjectConsultants.Action
{
    public class LoginManager
    {
        /// <summary>
        /// Logins the authentication.
        /// </summary>
        /// <param name="userDetails">The user details.</param>
        /// <returns></returns>
        public bool AuthenticateLogin(UserEntity userDetails)
        {
            var userDetail = new LoginDa().AuthenticateLogin(userDetails);
            return userDetail;
        }
    }
}