using Demo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[ApiController]
[Route("demo")]
public class DemoController : ControllerBase
{
    /// <summary>
    /// Hello world
    /// </summary>
    /// <returns></returns>
    [HttpGet(nameof(CustomerRequest))]
    public CustomerRequest CustomerRequest()
        => new();

    [HttpGet(nameof(GetProducts))]
    public List<ProductResponse> GetProducts()
        => new();

    [HttpGet(nameof(CompanyRequest))]
    public CompanyRequest CompanyRequest()
        => new();

    [HttpGet(nameof(ConnectionStringResponse))]
    public ConnectionStringResponse ConnectionStringResponse()
        => new();

    [HttpGet(nameof(ListAge))]
    public List<int> ListAge()
        => new();

    [HttpGet(nameof(ListName))]
    public List<string> ListName()
        => new();

    [HttpGet(nameof(GetName))]
    public string GetName()
        => "hello";

    [HttpGet(nameof(GenericClient))]
    public Response<Client> GenericClient()
        => new()
        {
            Data = new()
            {
                Name = "Nelson",
                Age = 18,
            }
        };

    [HttpGet(nameof(GenericString))]
    public Response<string> GenericString()
        => new()
        {
            Data = "hello"
        };

    [HttpGet(nameof(GenericClientList))]
    public ListResponse<Client, ListMetadata> GenericClientList()
        => new()
        {
            Data = new List<Client>
            {
                new()
                {
                    Name = "Nelson",
                    Age = 18,
                },
                new()
                {
                    Name = "Rui",
                    Age = 21,
                },
                new()
                {
                    Name = "Pedro",
                    Age = 10,
                },
            },

            Metadata = new()
            {
                Count = 3,
                Total = 30,
            }
        };

    [HttpGet(nameof(GenericClientListSummary))]
    public ListSummaryResponse<Client, ListMetadata, ListSummary> GenericClientListSummary()
        => new()
        {
            Data = new List<Client>
            {
                new()
                {
                    Name = "Nelson",
                    Age = 18,
                },
                new()
                {
                    Name = "Rui",
                    Age = 21,
                },
                new()
                {
                    Name = "Pedro",
                    Age = 10,
                },
            },

            Metadata = new()
            {
                Count = 3,
                Total = 30,
            },

            Summary = new()
            {
                Message = "Summary of clients",
            }
        };

    [HttpGet(nameof(GetOrderResponse))]
    public OrderResponse GetOrderResponse()
        => new()
        {
            Data1 = new()
            {
                Date = DateTime.Now,
                UserId = 132,
            },
            Data2 = new()
            {
                Date = DateTime.Now.AddDays(1).AddHours(3),
                Cost = 123.45,
            },
            Items = new()
            {
                new()
                {
                    Name = "Item 1",
                    Quantity = 1,
                },
                new()
                {
                    Name = "Item 2",
                    Quantity = 2,
                },
            }
        };
}
