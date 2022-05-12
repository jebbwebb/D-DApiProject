using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace DND
{
    class Program
    {
        static void Main(string[] args)
        {
            var dndApi = "https://www.dnd5eapi.co/api/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(dndApi);

            HttpResponseMessage response = client.GetAsync("spells/acid-arrow").Result;

            var result = response.Content.ReadAsStringAsync().Result;
            var spell = JsonConvert.DeserializeObject<Spell>(result);

            foreach (var entry in spell.damage.damage_at_slot_level)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
