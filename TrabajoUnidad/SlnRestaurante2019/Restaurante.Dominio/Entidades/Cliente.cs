using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    public class Cliente 
    {

        public int CodigoCliente { get; private set; }
        public string NombreCliente { get; private set; }
        public string ObservacionesCliente { get; private set; }

        public DateTime FechaRegistro { get; private set; }

   
        public static Cliente Crear(int aiCodigoCliente, string asNombreCliente)
        {
            return new Cliente()
            {
                CodigoCliente = aiCodigoCliente,
                NombreCliente = asNombreCliente,
                FechaRegistro = DateTime.Now
            };
        }
      
        public void CambiarNombre(string asNombreCliente)
        {
            NombreCliente = asNombreCliente;
        }

       
    }
}
