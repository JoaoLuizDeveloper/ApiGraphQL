using ApiGraphQL.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace ApiGraphQL.Services
{
    public class MusicCollectionService
    {
        private const string JsonFile = "musics.json";

        public static MusicCollection FromJson()
        {
            if (File.Exists(JsonFile))
            {
                var json = File.ReadAllText(JsonFile, Encoding.UTF8);
                return JsonConvert.DeserializeObject<MusicCollection>(json);
            }

            return new();
        }

        public static void ToJson(MusicCollection musicCollection)
        {
            var json = JsonConvert.SerializeObject(musicCollection, new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                Formatting = Formatting.Indented,
            });
            File.WriteAllText(JsonFile, json);
        }
    }
}
