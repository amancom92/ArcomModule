using ProjectConsultants.DataAccess;
using ProjectConsultants.Entity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectConsultants.Action
{
    public class CommonManager : BaseManager
    {
        /// <summary>
        /// Gets the country list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetCountryList()
        {
            List<System.Web.Mvc.SelectListItem> listCountry = new List<System.Web.Mvc.SelectListItem>();
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "India", Value = "1" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "Srilanka", Value = "2" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "China", Value = "3" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "Austrila", Value = "4" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "Japan", Value = "5" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "UK", Value = "6" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "Australia", Value = "7" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "West Indies", Value = "8" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "Bangladesh", Value = "9" });
            listCountry.Add(new System.Web.Mvc.SelectListItem { Text = "USA", Value = "10" });

            return listCountry;
        }

        /// <summary>
        /// Gets the states by country identifier.
        /// </summary>
        /// <param name="countryId">The country identifier.</param>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetStatesByCountryId(int countryId)
        {
            List<System.Web.Mvc.SelectListItem> states = new List<System.Web.Mvc.SelectListItem>();
            switch (countryId)
            {
                case 1:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Select", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ANDAMAN & NIKOBAR ISLANDS", Value = "1" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ANDHRA PRADESH", Value = "2" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ARUNACHAL PRADESH", Value = "3" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ASSAM", Value = "4" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "BIHAR", Value = "5" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "CHANDIGARH", Value = "6" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "CHHATTISGARH", Value = "7" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "DADRA & NAGAR HAVELI", Value = "8" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "DAMAN & DIU", Value = "9" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "GOA", Value = "10" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "GUJARAT", Value = "11" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "HARYANA", Value = "12" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "HIMACHAL PRADESH", Value = "13" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "JAMMU & KASHMIR", Value = "14" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "JHARKHAND", Value = "15" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "KARNATAKA", Value = "16" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "KERALA", Value = "17" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "LAKSHADWEEP", Value = "18" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MADHYA PRADESH", Value = "19" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MAHARASHTRA", Value = "20" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MANIPUR", Value = "21" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MEGHALAYA", Value = "22" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MIZORAM", Value = "23" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "NAGALAND", Value = "24" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "NCT OF DELHI", Value = "25" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ORISSA", Value = "26" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "JAMMU & KASHMIR", Value = "14" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "JHARKHAND", Value = "15" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "KARNATAKA", Value = "16" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "KERALA", Value = "17" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "LAKSHADWEEP", Value = "18" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MADHYA PRADESH", Value = "19" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MAHARASHTRA", Value = "20" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MANIPUR", Value = "21" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MEGHALAYA", Value = "22" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "MIZORAM", Value = "23" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "NAGALAND", Value = "24" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "NCT OF DELHI", Value = "25" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "ORISSA", Value = "26" });
                    break;
                case 2:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Matale District", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Kandy District", Value = "1" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Default", Value = "2" });
                    break;
                case 3:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Hebei Province", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Shanxi Province", Value = "1" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Default", Value = "2" });
                    break;
                case 4:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Queensland", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Victoria", Value = "1" });
                    break;
                case 5:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Fukuoka", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Hiroshima", Value = "1" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Tochigi", Value = "2" });
                    break;
                case 6:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Scotland", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "England", Value = "1" });
                    break;
                case 7:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Queensland", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Victoria", Value = "1" });
                    break;
                case 8:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Antigua", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Dominica", Value = "1" });
                    break;
                case 9:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Dhaka", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Chittagong", Value = "1" });
                    break;
                case 10:
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Florida", Value = "0" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Iowa", Value = "1" });
                    break;
            }

            return states;
        }

        /// <summary>
        /// Gets the state list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetStateList()
        {
            return null;
        }

        /// <summary>
        /// Gets the procurement list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetProcurementList()
        {
            List<System.Web.Mvc.SelectListItem> listProcurements = new List<System.Web.Mvc.SelectListItem>();
            listProcurements.Add(new System.Web.Mvc.SelectListItem { Text = "Default", Value = "1" });
            listProcurements.Add(new System.Web.Mvc.SelectListItem { Text = "Default One", Value = "2" });
            return listProcurements;
        }

        /// <summary>
        /// Gets the origin of contract list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetOriginContractList()
        {
            List<System.Web.Mvc.SelectListItem> contractOrigin = new List<System.Web.Mvc.SelectListItem>();
            contractOrigin.Add(new System.Web.Mvc.SelectListItem { Text = "Default", Value = "1" });
            contractOrigin.Add(new System.Web.Mvc.SelectListItem { Text = "Default One", Value = "2" });
            return contractOrigin;
        }

        /// <summary>
        /// Gets the contract list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System.Web.Mvc.SelectListItem> GetContractList()
        {
            List<System.Web.Mvc.SelectListItem> listContracts = new List<System.Web.Mvc.SelectListItem>();
            listContracts.Add(new System.Web.Mvc.SelectListItem { Text = "Default", Value = "1" });
            listContracts.Add(new System.Web.Mvc.SelectListItem { Text = "Default One", Value = "2" });
            return listContracts;
        }

        /// <summary>
        /// Gets the security question.
        /// </summary>
        /// <returns></returns>
        //public IEnumerable<SelectListItem> GetSecurityQuestionList()
        //{
        //    List<SelectListItem> securityQuestionList = new List<SelectListItem>();
        //    securityQuestionList.Add(new SelectListItem { Text = "What is your pet name?", Value = "1" });
        //    securityQuestionList.Add(new SelectListItem { Text = "Which is your favorite sports?", Value = "2" });
        //    securityQuestionList.Add(new SelectListItem { Text = "What is your father name?", Value = "3" });
        //    securityQuestionList.Add(new SelectListItem { Text = "Your Favorite color?", Value = "4" });
        //    return securityQuestionList;
        //}
        

        /// <summary>
        /// Adds the specified project data.
        /// </summary>
        /// <param name="projectData">The project data.</param>
        /// <returns></returns>
        public ProjectInformationEntity Add(ProjectInformationEntity projectData)
        {

            var projectDetail = new ProjectInformationDa().Add(projectData);
            return projectDetail;

        }

    }
}
