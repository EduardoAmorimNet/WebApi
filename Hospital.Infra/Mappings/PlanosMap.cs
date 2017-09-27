using Hospital.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Hospital.Infra.Mappings
{
    public class PlanosMap : EntityTypeConfiguration<Planos>
    {
        public PlanosMap()
        {
            ToTable("Medico");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Property(x => x.Cnpj).HasMaxLength(50).IsRequired();
            Property(x => x.Plano).HasMaxLength(50).IsRequired();

        }
    }
}
