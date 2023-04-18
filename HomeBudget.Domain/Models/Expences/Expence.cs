using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain.Models.Expences.States;

namespace HomeBudget.Domain.Models.Expences
{
    [Table("expence")]
    public class Expence
    {
        [Key]
        [Column("expence_id")]
        public Guid Id { get; set; }

        [Column("expence_category")]
        public ExpenceCategory ExpenceCategory { get; set; }

        [Column("expence_amount")]
        public decimal Amount { get; set; }

        [Column("expence_comment")]
        public string Comment { get; set; }

        [Column("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Column("updated_date")]
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
