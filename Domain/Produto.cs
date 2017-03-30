using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //data anotation pra transformar a tabela em produto
    [Table("Produto")]
    public class Produto
    {
        //o key nao seria necessario pq o entity ja entende q id é o id da tabela
        [Key]
        public int Id { get; set; }
        
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(2000)]
        [Required]
        public string Descricao { get; set; }

        [Range(-999999999999.99, 999999999999.99)]
        public decimal Valor { get; set; }

        //chave estrangeira da tabela loja
        [ForeignKey("Loja")]
        public int LojaId { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
