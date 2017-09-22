using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GitHubEventViewerJR.Models;

namespace GitHubEventViewerJR.Controllers
{
    public class HomeController : Controller
    {
        //Hosted web API REST Service base url
        static HttpClient client = GetHttpClient();

        public ActionResult Index()
        {
            //Sending request to find web api REST service resource Events
            HttpResponseMessage resp = client.GetAsync("events").Result;

            //Checking the response is successful or not which is sent using HttpClient  
            if (resp.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api   
                var eventResp = resp.Content.ReadAsAsync<dynamic>().Result;
                //Deserializing the response recieved from web api and storing into the Event list  
                return View(Newtonsoft.Json.JsonConvert.DeserializeObject<List<Event>>(eventResp.ToString(), SetSettings()));

            }
            //returning the event list to view  
            return View(new { Success = false, Message = "Experiencing technical difficulties please retry" });
        }

        public ActionResult UserEventDetails(string owner, string id)
        {
            //Sending request to find web api REST service resource EventDetails
            HttpResponseMessage resp = client.GetAsync("users/" + owner + "/events/public").Result;

            //Checking the response is successful or not which is sent using HttpClient 
            if (resp.IsSuccessStatusCode)
            {
                var eventResp = resp.Content.ReadAsAsync<dynamic>().Result;
                var userEventDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Event>>(eventResp.ToString(), SetSettings());

                // find requested id and return to view
                foreach (Models.Event ued in userEventDetails)
                {
                    if (ued.id == id)
                    {
                        // found the event requested; return it
                        return View(ued);
                    }
                }

                return View(new { Success = false, Message = "Event not found! Possible Causes : Invalid or Deleted User" });
            }
            else
            {
                return View(new { Success = false, Message = "Experiencing technical difficulties gathering event details" });
            }
        }

        /*   public ActionResult About()
               {
                   ViewBag.Message = "Your application description page.";
                   return View();
               }

               public ActionResult Contact()
               {
                   ViewBag.Message = "Your contact page.";
                   return View();
               }*/

        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            // Assigning an User-Agent value to satisfy gitHub
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2;)");
            return client;
        }

        private static JsonSerializerSettings SetSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            return settings;
        }
    }
}