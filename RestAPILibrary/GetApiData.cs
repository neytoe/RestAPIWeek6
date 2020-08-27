using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestAPILibrary
{
    /*This class is responsible for initiating a Get Request to the Api,
     * adding the contents gotten from the different pages that contain data to a list
     * of type Datum.
     */
   public class GetApiData
    {
       
            //This holds an Instance of Root class
            public static Root Page1 { get; set; }

            //This holds an Instance of Root class
            public static Root Page2 { get; set; }

            //This holds an instance of a Generic list of Type Datum
            public static List<Datum> OurList = new List<Datum>();


            /*
             * This method concatenates the data gotten from page1 and page2 and saves it
             * in a list
             */
            public static async Task MergePage()
            {
                //This holds the content gotten when a GetRequest is sent to the API for the first page
                Page1 = await GetRequest("https://jsonmock.hackerrank.com/api/article_users/search?page=1");

                //This holds the content gotten when a GetRequest is sent to the API for the first page
                Page2 = await GetRequest("https://jsonmock.hackerrank.com/api/article_users/search?page=2");

                //This joins the data gotten from the two pages and save it in a list
                OurList = Page1.Data.Concat(Page2.Data).ToList();
            }


            public static async Task<Root> GetRequest(string url)
            {
                //Instantiating the httpClient
                using (HttpClient client = new HttpClient())
                {
                //getting the response from the httpClient request
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                        //getting the content from the response gotten after making the get request
                            var json = await response.Content.ReadAsStringAsync();
                            return JsonSerializer.Deserialize<Root>(json);
                        }
                        return null;
                    }

                }

            }
   }
}

