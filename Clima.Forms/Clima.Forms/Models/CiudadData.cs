using Newtonsoft.Json;
using System.Collections.Generic;

namespace Clima.Forms.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class CiudadData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
    }

    public class ContactList
    {
        public List<CiudadData> ciudades { get; set; }
    }
}
