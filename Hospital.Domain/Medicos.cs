
using System;
using System.Collections.Generic;
namespace Hospital.Domain
{
    public class Medicos
    {
        public Medicos()
        {
            this.DataContratacao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataContratacao { get; set; }
        public bool Ativo { get; set; }
        public int IdPlano { get; set; }
        public virtual ICollection<Planos> Planos { get; set; }

        //Fazendo essa sobrescrita de ToString, é possível fazer Nome.ToString e retornar só o nome ao invés do objeto na tela
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
