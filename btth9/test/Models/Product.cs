namespace test.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = default!;
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        // đây là mối quan hệ n-n giữa Product và Order, một sản phẩm có thể thuộc về nhiều đơn hàng và một đơn hàng có thể chứa nhiều sản phẩm
    }
}