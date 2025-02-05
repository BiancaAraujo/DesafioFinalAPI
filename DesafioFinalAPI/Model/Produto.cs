using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioFinalAPI.Model
{
    [Table("produto")]
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int estoque { get; set; }
    }
}
