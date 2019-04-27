using Restaurante.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Restaurante.Infraestructura.Datos
{
    public class ClienteMapeo : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapeo()
        {
            ToTable("TBL_CLIENTES");
            HasKey(k => k.CodigoCliente);
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.NombreCliente).HasColumnName("NOM_CLIENTE").IsRequired().HasMaxLength(100);
            Property(p => p.FechaRegistro).HasColumnName("FEC_REGISTRO").IsRequired();
            Property(p => p.ObservacionesCliente).HasColumnName("OBS_CLIENTE").IsRequired();
        }
    }
}
