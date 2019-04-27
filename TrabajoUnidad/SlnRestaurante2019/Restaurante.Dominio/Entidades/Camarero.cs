using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Entidades
{
   public class Camarero
    {
        public int CodigoCamarero { get; private set; }
        public string NombreCamarero { get; private set; }
       

        public static Camarero Crear(int aiCodigoCamarero, string asNombreCamarero )
        {
            return new Camarero()
            {
                CodigoCamarero = aiCodigoCamarero,
                NombreCamarero = asNombreCamarero,
           
            };
        }

        public void CambiarNombre(string asNombreCliente)
        {
            NombreCamarero = asNombreCliente;
       
        }

    }
}
