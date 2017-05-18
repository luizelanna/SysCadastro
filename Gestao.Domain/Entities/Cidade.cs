

namespace Gestao.Domain.Entities
{
    public class Cidade
    {
        public int id { get; set; }
        public string NomeCidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
