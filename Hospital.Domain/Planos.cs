
namespace Hospital.Domain
{
    public class Planos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Plano { get; set; }
        public string Cnpj { get; set; }

        //Fazendo essa sobrescrita de ToString, é possível fazer Nome.ToString e retornar só o nome ao invés do objeto na tela
        public override string ToString()
        {
            return this.Nome; 
        }
    }
}
