using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CrossCutting.Identity.Model;

namespace Gestao.Application.ViewModels
{
  
    public class PessoasViewModel
    {
        [Key]
        public int id { get; set; }

        public int? idPessoa { get; set; }

        public int? idTpoPessoa { get; set; }
        
        public string idUsuarioUpdate { get; set; }


        [DisplayName("Nome")]
        [Required]
        public string Nome { get; set; }

        [DisplayName("Rg")]
        public string Rg { get; set; }

        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [DisplayName("Matricula")]
        public string Matricula { get; set; }

        [DisplayName("Idade")]
        public int? Idade { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Profissão")]
        public string Profissao { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Data de Alteração")]
        public DateTime? DataAlteração { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Celular")]
        public string Celular1 { get; set; }

        [DisplayName("Celular")]
        public string Celular2 { get; set; }

        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [DisplayName("Nuumero")]
        public string Numero { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }

        [DisplayName("CEP")]
        public string Cep { get; set; }

        public virtual TipoPessoasViewModel TipoPessoas { get; set; }
        
    }
}
