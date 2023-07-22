namespace Demo.Api.Models;

public record CustomerRequest
{
    /// <summary>
    /// My id is guid
    /// </summary>
    public Guid Id { get; init; } = Guid.NewGuid();
    /// <summary>
    /// My name is string
    /// </summary>
    public string Name { get; init; } = default!;

    /// <summary>
    /// My date of birth is date
    /// </summary>
    public DateTime DateOfBirth { get; init; }

    /// <summary>
    /// My email is email
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// My ...
    /// </summary>
    public Address? PersonalAddress { get; init; }


    public record Address
    {
        public string Country { get; init; } = default!;
        public string City { get; init; } = default!;
    }
}
