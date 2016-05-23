using ProjectConsultants.Action;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class ChangePasswordController : BaseController
    {
        // GET: Change Password
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            //if (ModelState.IsValid)
            //{

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:63465/");

                HttpResponseMessage response = client.GetAsync("api/ChangePassword/ChangePassword?UserName=" + changePasswordViewModel.Email + "&Password=" + changePasswordViewModel.Password + "&NewPassword=" + changePasswordViewModel.NewPassword).Result;

                if (response.IsSuccessStatusCode)
                {

                    return RedirectToActionPermanent("Index", "Project");
                }
            //}
            return View(changePasswordViewModel);
        }
    }
}

            //    //var userDetails = new UserEntity();
            //    //userDetails.FirstName = changePasswordViewModel.Email;
            //    //userDetails.Password = changePasswordViewModel.Password;
            //    //userDetails.NewPassword = changePasswordViewModel.NewPassword;

            //        //var isSuccess = new ChangePasswordManager().ChangePassword(userDetails);
            //        //ViewBag.result = isSuccess ? "Password changed successfully." : "Password not changed.";

            //        catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //{
            //    Exception raise = dbEx;
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            string message = string.Format("{0}:{1}",
            //                validationErrors.Entry.Entity.ToString(),
            //                validationError.ErrorMessage);
            //            // raise a new exception nesting  the current instance as InnerException  
            //            raise = new InvalidOperationException(message, raise);
                    
  
