using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Clima.Forms.Models
{
    class Datos
    {
        public static IList<CiudadData> Ciudad { get; private set; }
        public static ContactList ObjContactList = new ContactList();
        static Datos()
        {

            string jsonFileName = "Ciudades.json";
            var assembly = typeof(Datos).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                ObjContactList = JsonConvert.DeserializeObject<ContactList>(jsonString);
            }
        }

    }
}
