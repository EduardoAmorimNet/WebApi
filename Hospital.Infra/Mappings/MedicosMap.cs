
using Hospital.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Hospital.Infra.Mappings
{
    public class MedicosMap : EntityTypeConfiguration<Medicos>
    {
        public MedicosMap()
        {
            ToTable("Medico");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Property(x => x.CRM).HasMaxLength(50).IsRequired();
            Property(x => x.Email).HasMaxLength(50);
            Property(x => x.Telefone).HasMaxLength(20);

            HasMany(x => x.Planos);

        }
    }
}
