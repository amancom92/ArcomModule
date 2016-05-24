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
        public bool AuthenticateLogin(UserEntity login)
        {
            var exist = false;
            using (var context = new ArcomDbContext())
            {
                exist = context.userInformation.Any(p => p.Email.Equals(login.Email) && p.Password == login.Password);
            }
            return exist;
        }
    }
}