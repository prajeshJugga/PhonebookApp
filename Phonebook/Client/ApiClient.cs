using Newtonsoft.Json;
using Phonebook.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Phonebook.Client
{
    public static class ApiClient
    {
        //private static HttpClient client;

        public static HttpClient GetHttpClient(string uri)
        {
            HttpClient client = new HttpClient();
            // Update port # in the following line.
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
