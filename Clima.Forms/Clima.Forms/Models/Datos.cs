using System;
using System.Collections.Generic;
using System.Text;

namespace Clima.Forms.Models
{
    class Datos
    {
        public static IList<CiudadData> Ciudad { get; private set; }
        static Datos()
        {

            Ciudad = new List<CiudadData>();

            Ciudad.Add(new CiudadData
            {
                Name = "London"
            });

            Ciudad.Add(new CiudadData
            {
                Name = "Algarinejo"
            });

            Ciudad.Add(new CiudadData
            {
                Name = "Atauri"
            });
        }

    }
}
