using Hospital.Domain;
using Hospital.Infra.Mappings;
using System;
using System.Data.Entity;

namespace Hospital.Infra
{
    public class HospitalDataContext : DbContext
    {
        public HospitalDataContext()
            : base("DevStoreConnectionString")
        {
            //Primeira fase de Dev, para incializar o novo Banco
            Database.SetInitializer<HospitalDataContext>(new HospitalDataContextInitializer());
        }

        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Planos> Planos { get; set; }

        //Especificação par ao mapeamento do banco assim que gerado
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MedicosMap());
            modelBuilder.Configurations.Add(new PlanosMap());
            base.OnModelCreating(modelBuilder);
        }
    }


    public class HospitalDataContextInitializer : DropCreateDatabaseIfModelChanges<HospitalDataContext>
    {
        protected override void Seed(HospitalDataContext context)
        {
            base.Seed(context);

            context.Medicos.Add(new Medicos { Nome = "Eduardo Amorim", CRM = "153/588", Email = "medico.eduardo@clinica.com.br", Telefone = "(11) 99888-8188", DataContratacao = DateTime.Now, Ativo = true, IdPlano = 1 });
            context.SaveChanges();

            context.Planos.Add(new Planos { Nome = "Unimed SP", Cnpj = "4408882/0001", Plano = "Unimed Flex"});
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
