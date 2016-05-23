using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsultants.DataAccess
{
    public class ChangePasswordDa
    {
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
