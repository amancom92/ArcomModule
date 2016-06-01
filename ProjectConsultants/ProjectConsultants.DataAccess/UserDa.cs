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

        /// <summary>
        /// Registers the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public UserEntity Register(UserEntity user)
        {
            using (var context = new ArcomDbContext())
            {
                var userdetails = context.userInformation.Add(user);
                context.SaveChanges();
                return userdetails;
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            using (var context = new ArcomDbContext())
            {
                var emailValidate = context.userInformation.FirstOrDefault(p => p.Email.Equals(email));
                return emailValidate != null ? false : true;
            }
        }

    }
}