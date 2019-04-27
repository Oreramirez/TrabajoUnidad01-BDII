using Restaurante.Dominio;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infraestructura.Datos.Mapeos
{
    public class CamareroMapeo : EntityTypeConfiguration<Camarero>
    {
        public CamareroMapeo()
        {
            ToTable("TBL_CAMAREROS");
            HasKey(k => k.CodigoCamarero);
            Property(p => p.CodigoCamarero).HasColumnName("COD_CAMARERO").IsRequired();
            Property(p => p.NombreCamarero).HasColumnName("NOM_CAMARERO").IsRequired().HasMaxLength(100);
            
        }
    }
}
