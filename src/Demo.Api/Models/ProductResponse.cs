namespace Demo.Api.Models;

public class ProductResponse
{
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public List<string>? Tags { get; set; }
}
