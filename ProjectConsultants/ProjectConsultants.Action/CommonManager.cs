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
        public IEnumerable<SelectListItem> GetCountryList()
        {
            List<SelectListItem> listCountry = new List<SelectListItem>();
            listCountry.Add(new SelectListItem { Text = "India", Value = "1" });
            listCountry.Add(new SelectListItem { Text = "Srilanka", Value = "2" });
            listCountry.Add(new SelectListItem { Text = "China", Value = "3" });
            listCountry.Add(new SelectListItem { Text = "Austrila", Value = "4" });
            listCountry.Add(new SelectListItem { Text = "Japan", Value = "5" });
            listCountry.Add(new SelectListItem { Text = "UK", Value = "6" });
            listCountry.Add(new SelectListItem { Text = "Australia", Value = "7" });
            listCountry.Add(new SelectListItem { Text = "West Indies", Value = "8" });
            listCountry.Add(new SelectListItem { Text = "Bangladesh", Value = "9" });
            listCountry.Add(new SelectListItem { Text = "USA", Value = "10" });

            return listCountry;
        }

        /// <summary>
        /// Gets the states by country identifier.
        /// </summary>
        /// <param name="countryId">The country identifier.</param>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetStatesByCountryId(int countryId)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            switch (countryId)
            {
                case 1:
                    states.Add(new SelectListItem { Text = "Select", Value = "0" });
                    states.Add(new SelectListItem { Text = "ANDAMAN & NIKOBAR ISLANDS", Value = "1" });
                    states.Add(new SelectListItem { Text = "ANDHRA PRADESH", Value = "2" });
                    states.Add(new SelectListItem { Text = "ARUNACHAL PRADESH", Value = "3" });
                    states.Add(new SelectListItem { Text = "ASSAM", Value = "4" });
                    states.Add(new SelectListItem { Text = "BIHAR", Value = "5" });
                    states.Add(new SelectListItem { Text = "CHANDIGARH", Value = "6" });
                    states.Add(new SelectListItem { Text = "CHHATTISGARH", Value = "7" });
                    states.Add(new SelectListItem { Text = "DADRA & NAGAR HAVELI", Value = "8" });
                    states.Add(new SelectListItem { Text = "DAMAN & DIU", Value = "9" });
                    states.Add(new SelectListItem { Text = "GOA", Value = "10" });
                    states.Add(new SelectListItem { Text = "GUJARAT", Value = "11" });
                    states.Add(new SelectListItem { Text = "HARYANA", Value = "12" });
                    states.Add(new SelectListItem { Text = "HIMACHAL PRADESH", Value = "13" });
                    states.Add(new SelectListItem { Text = "JAMMU & KASHMIR", Value = "14" });
                    states.Add(new SelectListItem { Text = "JHARKHAND", Value = "15" });
                    states.Add(new SelectListItem { Text = "KARNATAKA", Value = "16" });
                    states.Add(new SelectListItem { Text = "KERALA", Value = "17" });
                    states.Add(new SelectListItem { Text = "LAKSHADWEEP", Value = "18" });
                    states.Add(new SelectListItem { Text = "MADHYA PRADESH", Value = "19" });
                    states.Add(new SelectListItem { Text = "MAHARASHTRA", Value = "20" });
                    states.Add(new SelectListItem { Text = "MANIPUR", Value = "21" });
                    states.Add(new SelectListItem { Text = "MEGHALAYA", Value = "22" });
                    states.Add(new SelectListItem { Text = "MIZORAM", Value = "23" });
                    states.Add(new SelectListItem { Text = "NAGALAND", Value = "24" });
                    states.Add(new SelectListItem { Text = "NCT OF DELHI", Value = "25" });
                    states.Add(new SelectListItem { Text = "ORISSA", Value = "26" });
                    states.Add(new SelectListItem { Text = "JAMMU & KASHMIR", Value = "14" });
                    states.Add(new SelectListItem { Text = "JHARKHAND", Value = "15" });
                    states.Add(new SelectListItem { Text = "KARNATAKA", Value = "16" });
                    states.Add(new SelectListItem { Text = "KERALA", Value = "17" });
                    states.Add(new SelectListItem { Text = "LAKSHADWEEP", Value = "18" });
                    states.Add(new SelectListItem { Text = "MADHYA PRADESH", Value = "19" });
                    states.Add(new SelectListItem { Text = "MAHARASHTRA", Value = "20" });
                    states.Add(new SelectListItem { Text = "MANIPUR", Value = "21" });
                    states.Add(new SelectListItem { Text = "MEGHALAYA", Value = "22" });
                    states.Add(new SelectListItem { Text = "MIZORAM", Value = "23" });
                    states.Add(new SelectListItem { Text = "NAGALAND", Value = "24" });
                    states.Add(new SelectListItem { Text = "NCT OF DELHI", Value = "25" });
                    states.Add(new SelectListItem { Text = "ORISSA", Value = "26" });
                    break;
                case 2:
                    states.Add(new SelectListItem { Text = "Matale District", Value = "0" });
                    states.Add(new SelectListItem { Text = "Kandy District", Value = "1" });
                    states.Add(new SelectListItem { Text = "Default", Value = "2" });
                    break;
                case 3:
                    states.Add(new SelectListItem { Text = "Hebei Province", Value = "0" });
                    states.Add(new SelectListItem { Text = "Shanxi Province", Value = "1" });
                    states.Add(new SelectListItem { Text = "Default", Value = "2" });
                    break;
                case 4:
                    states.Add(new SelectListItem { Text = "Queensland", Value = "0" });
                    states.Add(new SelectListItem { Text = "Victoria", Value = "1" });
                    break;
                case 5:
                    states.Add(new SelectListItem { Text = "Fukuoka", Value = "0" });
                    states.Add(new SelectListItem { Text = "Hiroshima", Value = "1" });
                    states.Add(new SelectListItem { Text = "Tochigi", Value = "2" });
                    break;
                case 6:
                    states.Add(new SelectListItem { Text = "Scotland", Value = "0" });
                    states.Add(new SelectListItem { Text = "England", Value = "1" });
                    break;
                case 7:
                    states.Add(new SelectListItem { Text = "Queensland", Value = "0" });
                    states.Add(new SelectListItem { Text = "Victoria", Value = "1" });
                    break;
                case 8:
                    states.Add(new SelectListItem { Text = "Antigua", Value = "0" });
                    states.Add(new SelectListItem { Text = "Dominica", Value = "1" });
                    break;
                case 9:
                    states.Add(new SelectListItem { Text = "Dhaka", Value = "0" });
                    states.Add(new SelectListItem { Text = "Chittagong", Value = "1" });
                    break;
                case 10:
                    states.Add(new SelectListItem { Text = "Florida", Value = "0" });
                    states.Add(new SelectListItem { Text = "Iowa", Value = "1" });
                    break;
            }

            return states;
        }

        /// <summary>
        /// Gets the state list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetStateList()
        {
            return null;
        }

        /// <summary>
        /// Gets the procurement list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetProcurementList()
        {
            List<SelectListItem> listProcurements = new List<SelectListItem>();
            listProcurements.Add(new SelectListItem { Text = "Default", Value = "1" });
            listProcurements.Add(new SelectListItem { Text = "Default One", Value = "2" });
            return listProcurements;
        }

        /// <summary>
        /// Gets the origin of contract list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetOriginContractList()
        {
            List<SelectListItem> contractOrigin = new List<SelectListItem>();
            contractOrigin.Add(new SelectListItem { Text = "Default", Value = "1" });
            contractOrigin.Add(new SelectListItem { Text = "Default One", Value = "2" });
            return contractOrigin;
        }

        /// <summary>
        /// Gets the contract list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetContractList()
        {
            List<SelectListItem> listContracts = new List<SelectListItem>();
            listContracts.Add(new SelectListItem { Text = "Default", Value = "1" });
            listContracts.Add(new SelectListItem { Text = "Default One", Value = "2" });
            return listContracts;
        }

        /// <summary>
        /// Gets the security question.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetSecurityQuestionList()
        {
            List<SelectListItem> securityQuestionList = new List<SelectListItem>();
            securityQuestionList.Add(new SelectListItem { Text = "What is your pet name?", Value = "1" });
            securityQuestionList.Add(new SelectListItem { Text = "Which is your favorite sports?", Value = "2" });
            securityQuestionList.Add(new SelectListItem { Text = "What is your father name?", Value = "3" });
            securityQuestionList.Add(new SelectListItem { Text = "Your Favorite color?", Value = "4" });
            return securityQuestionList;
        }
        

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
