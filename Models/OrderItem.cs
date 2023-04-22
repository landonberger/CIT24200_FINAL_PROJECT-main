using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
