using Restaurante.Dominio;
using Restaurante.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Restaurante.Infraestructura.Datos.Mapeos
{
    public class MesaMapeo : EntityTypeConfiguration<Mesa>
    {
        public MesaMapeo()
        {
            ToTable("TBL_MESAS");
            HasKey(k => k.CodigoMesa);
            Property(p => p.CodigoMesa).HasColumnName("COD_MESA").IsRequired();
            Property(p => p.UbicacionMesa).HasColumnName("UBICA_MESA").IsRequired();
        }
    }
}
