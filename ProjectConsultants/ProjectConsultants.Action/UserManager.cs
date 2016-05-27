using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System;

namespace ProjectConsultants.Action
{
    public class UserManager
    {
        /// <summary>
        /// Adds the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public UserEntity Add(UserEntity user)
        {
            var userEntity = new UserEntity();
            try
            {
                userEntity = new ProjectInformationDa().Register(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return userEntity;
        }


        public bool EmailValidate(string email)
        {

            var useremail = new ProjectInformationDa().ValidateEmail(email);
            return useremail;

        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="userDetails">The user details.</param>
        /// <returns></returns>
        public bool ChangePassword(UserEntity userDetails)
        {
            var isSuccess = false;

            try
            {
                isSuccess = new UserDa().ChangePassword(userDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isSuccess;
        }
    }
}
