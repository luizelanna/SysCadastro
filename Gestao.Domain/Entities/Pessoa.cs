using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Domain.Entities
{
    public class Pessoa
    {
        public int id { get; set; }
        public Nullable<int> idPessoa { get; set; }
        public Nullable<int> idTpoPessoa { get; set; }
        public string idUsuarioUpdate { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Matricula { get; set; }
        public Nullable<int> Idade { get; set; }
        public string Sexo { get; set; }
        public string Profissao { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<System.DateTime> DataAlteração { get; set; }
        public string Telefone { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        //public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual TipoPessoa TipoPessoas { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
