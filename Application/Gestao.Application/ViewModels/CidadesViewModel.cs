using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Application.ViewModels
{
    
    public class CidadesViewModel
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Nome da Cidade")]
        public string NomeCidade { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }

        [DisplayName("CEP")]
        public string Cep { get; set; }

        
    }
}
