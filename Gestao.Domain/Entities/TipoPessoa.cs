

namespace Gestao.Domain.Entities
{
    public class TipoPessoa
    {
        public int id { get; set; }
        public string Descricao { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
