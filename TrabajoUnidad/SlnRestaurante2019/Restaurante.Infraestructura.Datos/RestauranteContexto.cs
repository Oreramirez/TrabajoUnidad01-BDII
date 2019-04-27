using Restaurante.Dominio;
using Restaurante.Dominio.Entidades;
using Restaurante.Infraestructura.Datos.Mapeos;
using System.Data.Entity;

namespace Restaurante.Infraestructura.Datos
{
    public class RestauranteContexto : DbContext
    {
        public RestauranteContexto() : base("Restaurante")
        {

        }

        public IDbSet<Cliente> Clientes { get;  set; }
        public IDbSet<Camarero> Camareros { get; set; }
        public IDbSet<Factura> Factura { get; set; }
        public IDbSet<DetalleFactura> DetallesFactura { get; set; }
        public IDbSet<Mesa> Mesas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CamareroMapeo());
            modelBuilder.Configurations.Add(new DetalleFMapeo());
            modelBuilder.Configurations.Add(new FacturaMapeo());
            modelBuilder.Configurations.Add(new MesaMapeo());
        }

    }
}
