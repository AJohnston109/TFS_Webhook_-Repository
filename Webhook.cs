using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Owin;
using System.Web.Http;

namespace WebHook
{
    public class WebHook
    {
        
        private static object client;

        
        public static async void GetProjects()
        {
            try
            {
                Console.ReadKey();
                var personalAccessToken = String.Empty;
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                    string.Format("{0}:{1}", "", personalAccessToken))));

                    //process the response stream
                    using (HttpResponseMessage response = await client.GetAsync(
                         "https://ndi-tfs.visualstudio.com/_apis/projects?api-version=2.0"))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex);
            }
        }
    }
}
