using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;

         public ICollection<Order> Orders { get; set; } = new List<Order>();
         // đây là mối quan hệ 1-n giữa Customer và Order, một khách hàng có thể có nhiều đơn hàng
         
    }
}