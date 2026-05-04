using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public decimal Sum { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        // đây là mối quan hệ n-n giữa Order và Customer, một đơn hàng thuộc về một khách hàng

        public ICollection<Product> Products { get; set; } = new List<Product>();
        // 1 đơn hàng có thể chứa nhiều sản phẩm, đây là mối quan hệ 1-n giữa Order và Product

    }
}