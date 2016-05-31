using ProjectConsultants.Entity;
using System.Linq;

namespace ProjectConsultants.DataAccess
{
    public class LoginDa
    {
        /// <summary>
        /// Logins the authentication.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        public UserEntity AuthenticateLogin(UserEntity login)
        {
            using (var context = new ArcomDbContext())
            {
                var loginDetail = context.userInformation.FirstOrDefault(p => p.Email.Equals(login.Email) && p.Password == login.Password);
                return loginDetail;
            }
         
        }
    }
}