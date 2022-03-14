using Newtonsoft.Json;
using Phonebook.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Phonebook.Requesters
{
    public static class PhoneBookRequester
    {
        public static async Task<PhoneBook> GetPhoneBookByName(HttpClient client, string phoneBookName)
        {
            //string requestUri = "";
            PhoneBook phonebook = null;
            HttpResponseMessage response = await client.GetAsync($"phonebook/get/{phoneBookName}");
            if (response.IsSuccessStatusCode)
            {
                phonebook = response.Content.ReadFromJsonAsync<PhoneBook>().Result;
            }
            return phonebook;
        }

        public static async Task<List<string>> GetPhoneBookNames(HttpClient client)
        {
            //string requestUri = "";
            List<string> phoneBookNames = new List<string>();
            HttpResponseMessage response = await client.GetAsync($"phonebook/get/phonebookNames");
            if (response.IsSuccessStatusCode)
            {
                phoneBookNames = response.Content.ReadFromJsonAsync<List<string>>().Result;
            }
            return phoneBookNames;
        }

        public static async Task<PhoneBook> CreatePhoneBook(HttpClient client, PhoneBook phoneBook)
        {
            //string requestUri = "";
            PhoneBook responsePhonebook = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("phonebook/create", phoneBook);
            if (response.IsSuccessStatusCode)
            {
                responsePhonebook = response.Content.ReadFromJsonAsync<PhoneBook>().Result;
            }
            return responsePhonebook;
        }
    }
}
