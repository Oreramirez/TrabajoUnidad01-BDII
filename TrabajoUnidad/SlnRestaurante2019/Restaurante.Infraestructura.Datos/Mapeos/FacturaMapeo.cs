using Restaurante.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Restaurante.Infraestructura.Datos.Mapeos
{
    public class FacturaMapeo : EntityTypeConfiguration<Factura>

    {
        
        public FacturaMapeo()
        {
            ToTable("TBL_FACTURA");
            HasKey(k => k.CodigoFactura);
            Property(p => p.CodigoFactura).HasColumnName("COD_FACTURA").IsRequired();
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.CodigoCamarero).HasColumnName("COD_CAMARERO").IsRequired();
            Property(p => p.CodigoMesa).HasColumnName("COD_MESA").IsRequired();
            Property(p => p.FechaFactura).HasColumnName("FEC_FACTURA").IsRequired();

            HasRequired(m => m.vCliente).WithMany().HasForeignKey(f => f.CodigoCliente);
            HasRequired(m => m.vCamarero).WithMany().HasForeignKey(f => f.CodigoCamarero);
            HasRequired(m => m.vMesa).WithMany().HasForeignKey(f => f.CodigoMesa);
        }
    }
}
