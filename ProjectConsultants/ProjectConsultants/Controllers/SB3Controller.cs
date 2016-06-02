using Newtonsoft.Json;
using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectConsultants.Controllers
{
    public class SB3Controller : Controller
    {
        // GET: SB3

        public async Task<ActionResult> SB3()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64468/");
            HttpResponseMessage responseMessage = await client.GetAsync("api/Examination/GetQuestions");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var questions = JsonConvert.DeserializeObject<List<Questions>>(responseData);

                return View();
            }
            return View("SB3", "SB3");
        }
    }
}