using Phonebook.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Phonebook.Requesters
{
    public static class EntryRequester
    {
        public static async Task<PhoneBook> CreateEntry(HttpClient client, Entry entry)
        {
            PhoneBook responsePhonebook = null;
            HttpResponseMessage response = await client.PostAsJsonAsync($"entry/create/{entry.PhoneBookName}", entry);
            if (response.IsSuccessStatusCode)
            {
                responsePhonebook = response.Content.ReadFromJsonAsync<PhoneBook>().Result;
            }
            return responsePhonebook;
        }
    }
}
