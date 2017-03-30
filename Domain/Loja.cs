using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //data anotation pra transformar em tabela loja
    [Table("Loja")]
    public class Loja
    {
        public Loja()
        {
            Produtos = new List<Produto>();
        }
        //o key nao seria necessario pq o entity ja entende q id é o id da tabela
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(2000)]
        public string Descricao { get; set; }

        //trazendo a lista de produtos da loja
        public virtual IList<Produto> Produtos { get; set; }
    }
}
