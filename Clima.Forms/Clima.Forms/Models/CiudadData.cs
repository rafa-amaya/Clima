using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clima.Forms.Models
{
    public class CiudadData
    {
        //[JsonProperty("id")]
        //public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("country")]
        //public string Country { get; set; }

        //[JsonProperty("coord")]
        //public Coord Coord { get; set; }
    }

    //public partial class Coord
    //{
    //    [JsonProperty("lon")]
    //    public double Lon { get; set; }

    //    [JsonProperty("lat")]
    //    public double Lat { get; set; }
    //}
}
