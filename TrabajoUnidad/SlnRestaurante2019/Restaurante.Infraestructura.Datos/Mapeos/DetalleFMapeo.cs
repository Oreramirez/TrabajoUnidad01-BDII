using Restaurante.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;
namespace Restaurante.Infraestructura.Datos.Mapeos
{
    public class DetalleFMapeo :EntityTypeConfiguration<DetalleFactura>
    {
        public int CodigoFactura { get; set; }
        public int CodigoDetalleF { get; private set; }
        public string Plato { get; private set; }
        public double Importe { get; private set; }
        public virtual Factura vFactura { get; private set; }
        public DetalleFMapeo()
        {
            ToTable("TBL_DETALLEFACTURA");
            HasKey(k => k.CodigoDetalleF);
            Property(p => p.CodigoDetalleF).HasColumnName("COD_DETALLEF").IsRequired();
            Property(p => p.CodigoFactura).HasColumnName("COD_FACTURA").IsRequired();
            Property(p => p.Plato).HasColumnName("PLATO").IsRequired();
            Property(p => p.Importe).HasColumnName("IMPORTE").IsRequired();

            HasRequired(m => m.vFactura).WithMany().HasForeignKey(f => f.CodigoFactura);
        }
    }
}
