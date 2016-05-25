

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
<<<<<<< .merge_file_a08060
        public bool AuthenticateLogin(UserEntity userDetails)
        {
            var userDetail = new LoginDa().AuthenticateLogin(userDetails);
=======
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
>>>>>>> .merge_file_a05396
            return userDetail;
        }
    }
}