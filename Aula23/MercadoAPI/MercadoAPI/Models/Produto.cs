using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MercadoAPI.Models
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Key]
        [Column("ID_PRODUTO")]
        public int Id { get; set; }

        [Column("NM_PRODUTO", TypeName = "VARCHAR(50)")]
        public string Nome { get; set; }

        [Column("DT_VALIDADE_PRODUTO")]
        [DataType(DataType.Date)]

        public DateTime DataValidade { get; set; }
        [Column("VLR_PRODUTO", TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        [JsonIgnore]
        public virtual ICollection<VendaItem> VendasDoProduto { get; set; }
    }
}
