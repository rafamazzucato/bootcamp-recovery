using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    [Table("TB_TODO_ITEM")]
    public class TodoItem
    {
        [Key]
        [Column("ID_TODO_ITEM")]
        public int Id { get; set; }
        [Column("NM_TODO_ITEM", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }
        [Column("IS_COMPLETE")]
        public bool IsComplete { get; set; }
    }
}
