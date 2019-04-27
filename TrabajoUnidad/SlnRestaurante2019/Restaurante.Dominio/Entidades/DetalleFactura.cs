using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Entidades
{
    public class DetalleFactura
    {
        public int CodigoFactura { get;  set; }
        public int CodigoDetalleF { get; private set; }
        public string Plato { get; private set; }
        public double Importe { get; private set; }


        public virtual Factura vFactura { get; private set; }
      

    }
}
