using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class BaseAPIController : ApiController
    {
        public async Task<T> InvokeAPI<T>(string Uri, string authKey, string host) where T : class
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(Uri),
                Headers =
                {
                    { "X-RapidAPI-Key", authKey },
                    { "X-RapidAPI-Host", host },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(body);
            }
        }
    }
}
