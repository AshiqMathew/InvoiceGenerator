using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceGenerator.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Customer Name")]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerName { get; set; }

        [DisplayName("Customer Address")]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerAddress { get; set; }
        public DateTime InvoiceDate { get; set; }

        [DisplayName("Items")]
        [Column(TypeName = "nvarchar(100)")]
        public string ItemNames { get; set; }

        [DisplayName("Total Bill")]
        public decimal TotalAmount { get; set; }
    }
}
