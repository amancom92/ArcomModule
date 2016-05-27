using ProjectConsultants.Entity;
using System.Linq;

namespace ProjectConsultants.DataAccess
{
    public class UserDa
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
                var loginDetail = context.userInformation.FirstOrDefault(p => p.Email.Equals(login.Email.Trim(), System.StringComparison.CurrentCultureIgnoreCase) && p.Password == login.Password.Trim());
                //if (loginDetail == null)
                //{
                   
                //}
                return loginDetail;
            }
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        public bool ChangePassword(UserEntity login)
        {
            using (var context = new ArcomDbContext())
            {
                var loginDetail = context.userInformation.FirstOrDefault(log => log.Email == login.Email && log.Password == login.Password);

                if (loginDetail != null)
                {
                    loginDetail.Password = login.NewPassword.Trim();
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}