using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Application.ViewModels
{

    public class TipoPessoasViewModel
    {
        [Key]
        public int id { get; set; }
        
        [DisplayName("Descri��o")]
        [Required(ErrorMessage = "O campo Institui��o n�o pode ficar vazio.")]
        public string Descricao { get; set; }
        

    }
}
