using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        public int Date { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = default!;
        // đây là mối quan hệ 1-1 giữa Detail và Order, một chi tiết đơn hàng chỉ thuộc về một đơn hàng
    }
}