using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Application.ViewModels
{

    public class TipoPessoasViewModel
    {
        [Key]
        public int id { get; set; }
        
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo Instituição não pode ficar vazio.")]
        public string Descricao { get; set; }
        

    }
}
