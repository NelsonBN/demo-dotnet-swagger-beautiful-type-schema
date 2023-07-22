namespace Demo.Api.Models;

public record CompanyRequest
{
    /// <summary>
    /// Gets or sets the name of the company.
    /// </summary>
    public string Name { get; init; } = default!;
    public Address? CompanyAddress { get; init; }

    public record Address
    {
        public string Street { get; init; } = default!;
        public string City { get; init; } = default!;
        public string State { get; init; } = default!;
        public string ZipCode { get; init; } = default!;
    }

    public struct Department
    {
        /// <summary>
        /// Test documentation
        /// </summary>
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public Stakeholder? Manager { get; init; }

        public Department()
        {

        }


        public struct Stakeholder
        {
            public Stakeholder()
            {
            }

            public string Name { get; init; } = default!;
            public string Email { get; init; } = default!;
        }
    }
}
