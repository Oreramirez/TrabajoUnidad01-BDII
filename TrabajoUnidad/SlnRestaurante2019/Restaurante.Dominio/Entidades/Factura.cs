using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Entidades
{
    public class Factura
    {
        public int CodigoFactura { get;  set; }
        public int CodigoCliente { get; private set; }
        public int CodigoCamarero { get; private set; }
        public int CodigoMesa { get; private set; }
        public DateTime FechaFactura { get; private set; }

        public virtual Cliente vCliente { get; private set; }
        public virtual Camarero vCamarero { get; private set; }
        public virtual Mesa vMesa{ get; private set; }

    }
}
