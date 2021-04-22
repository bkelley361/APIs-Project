using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;


namespace Star_Wars_API
{
    class JSONHelper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Planet> GetPlanet(int i)
        {
            Planet myDeserializedClass = new Planet();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/planets/" + i + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }

        public static async Task<Character> GetCharacter(int i)
        {
            Character myDeserializedClass = new Character();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people/" + i + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Character>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }
        public static async Task<Species> GetSpecies(int i)
        {
            Species myDeserializedClass = new Species();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/species/" + i + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Species>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }
    }
}
