using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestForms.models;

namespace TestForms.restapi
{
    internal class RestService
    {
        HttpClient _client;

        public RestService() { 
            _client = new HttpClient();
        }

        public async Task<List<Character>> GetCharacters(string uri)
        {
            List<Character> listCharacters = null;
            try
            {
                HttpResponseMessage response 
                    = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync(); ;
                    Characters characters = JsonConvert.DeserializeObject<Characters>(content);
                    listCharacters = characters.results;
                }
            }catch(Exception ex)
            {
                Debug.WriteLine("Error: {0}", ex.Message);
            }
            return listCharacters;
        }
    }
}
