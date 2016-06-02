using ProjectConsultants.DataAccess;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectConsultants.Action
{

    public class SecurityQuestionsManager
    {
        ////public IEnumerable<SelectListItem> GetSecurityQuestionList()
        ////{
        ////    List<SelectListItem> securityQuestionList = new List<SelectListItem>();
        ////    securityQuestionList.Add(new SelectListItem { Text = "What is your pet name?", Value = "1" });
        ////    securityQuestionList.Add(new SelectListItem { Text = "Which is your favorite sports?", Value = "2" });
        ////    securityQuestionList.Add(new SelectListItem { Text = "What is your father name?", Value = "3" });
        ////    securityQuestionList.Add(new SelectListItem { Text = "Your Favorite color?", Value = "4" });
        ////    return securityQuestionList;
        ////}

        public List<SelectListItem> GetSecurityQuestionList()
        {
            List<SelectListItem> securityQuestionList = new List<SelectListItem>();
            try
            {
                ////securityQuestionList = new SecurityQuestionsDa().GetSecurityQuestionList();
            }
            catch (Exception ex)
            {
                var message = ex.ToString();

            }
            return securityQuestionList;
        }


    }
}
