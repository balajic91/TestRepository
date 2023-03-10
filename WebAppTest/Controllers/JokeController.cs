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
    [Route("api/[controller]")]
    public class JokeController : BaseAPIController
    {
        private readonly string _apiKey = "37edd9a963msh47dd34600d0800ep1fec9djsn6369c202c875";
        private readonly string _host = "dad-jokes.p.rapidapi.com";

        [Route("get-random-joke")]
        public async Task<ReturnType<List<Joke>>> Get()
        {
            var Uri = "https://dad-jokes.p.rapidapi.com/random/joke";
            return await InvokeAPI<ReturnType<List<Joke>>>(Uri, _apiKey, _host); 
        }

        [Route("get-joke-count")]
        public async Task<ReturnType<int>> GetJokeCount()
        {
            var Uri = "https://dad-jokes.p.rapidapi.com/joke/count";
            return await InvokeAPI<ReturnType<int>>(Uri, _apiKey, _host);
        }
    }
}
