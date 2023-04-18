using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain.Models.Incomes.States;

namespace HomeBudget.Domain.Models.Incomes
{
    [Table("income")]
    public class Income
    {
        [Key]
        [Column("income_id")]
        public Guid Id { get; set; }

        [Column("income_category")]
        public IncomeCategory IncomeCategory { get; set; }

        [Column("income_amount")]
        public decimal Amount { get; set; }

        [Column("income_comment")]
        public string Comment { get; set; }

        [Column("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Column("updated_date")]
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
