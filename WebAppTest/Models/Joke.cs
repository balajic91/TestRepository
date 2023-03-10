using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace WebAppTest.Models
{
    public class Joke
    {
        public string _id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public string type { get; set; }
        public List<object> likes { get; set; }
        public Author author { get; set; }
        public bool approved { get; set; }
        public int date { get; set; }
        public bool NSFW { get; set; }
        public string shareableLink { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public object id { get; set; }
    }

    public class ReturnType<T>
    {
        public bool success { get; set; }
        public T body { get; set; }
    }
}