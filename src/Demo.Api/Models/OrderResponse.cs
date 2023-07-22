using static Demo.Api.Models.OrderResponse;

namespace Demo.Api.Models;

public class OrderResponse : Response<Order, Invoice>
{
    public List<Item> Items { get; set; } = new();

    public sealed class Order
    {
        public DateTime Date { get; set; }
        public uint UserId { get; set; }
    }

    public sealed class Invoice
    {
        public DateTime Date { get; set; }
        public double Cost { get; set; }
    }

    public sealed class Item
    {
        public string Name { get; set; } = default!;
        public int Quantity { get; set; }
    }
}
