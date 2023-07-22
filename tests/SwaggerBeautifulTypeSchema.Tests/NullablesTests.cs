using Demo.Api.Models;

namespace SwaggerBeautifulTypeSchema.Tests;

public class NullablesTests
{
    [Theory]
    [InlineData(null, false)]
    [InlineData(typeof(Nullable), false)]
    [InlineData(typeof(Nullable<>), true)]
    [InlineData(typeof(bool), false)]
    [InlineData(typeof(byte), false)]
    [InlineData(typeof(sbyte), false)]
    [InlineData(typeof(short), false)]
    [InlineData(typeof(ushort), false)]
    [InlineData(typeof(int), false)]
    [InlineData(typeof(uint), false)]
    [InlineData(typeof(long), false)]
    [InlineData(typeof(ulong), false)]
    [InlineData(typeof(float), false)]
    [InlineData(typeof(double), false)]
    [InlineData(typeof(decimal), false)]
    [InlineData(typeof(char), false)]
    [InlineData(typeof(string), false)]
    [InlineData(typeof(nint), false)]
    [InlineData(typeof(nuint), false)]
    [InlineData(typeof(Guid), false)]
    [InlineData(typeof(DateTime), false)]
    [InlineData(typeof(ValueType), false)]
    [InlineData(typeof(int?), true)]
    [InlineData(typeof(bool?), true)]
    [InlineData(typeof(decimal?), true)]
    [InlineData(typeof(char?), true)]
    [InlineData(typeof(DateTime?), true)]
    [InlineData(typeof(Guid?), true)]
    [InlineData(typeof(float?), true)]
    [InlineData(typeof(CompanyRequest.Address), false)]
    [InlineData(typeof(ConnectionStringResponse), false)]
    [InlineData(typeof(CustomerRequest), false)]
    [InlineData(typeof(CompanyRequest.Department), false)]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), false)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(IDictionary<,>), false)]
    [InlineData(typeof(Dictionary<,>), false)]
    [InlineData(typeof(IReadOnlyList<>), false)]
    [InlineData(typeof(IReadOnlyList<CompanyRequest.Department>), false)]
    [InlineData(typeof(Dictionary<double, string>), false)]
    [InlineData(typeof(IEnumerable<string>), false)]
    [InlineData(typeof(List<int>), false)]
    [InlineData(typeof(ICollection<double>), false)]
    public void Types_IsNullableType_Expected(Type type, bool expected)
    {
        // Arrange && Act
        var act = type.IsNullableType();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(bool), false)]
    [InlineData(typeof(byte), false)]
    [InlineData(typeof(sbyte), false)]
    [InlineData(typeof(short), false)]
    [InlineData(typeof(ushort), false)]
    [InlineData(typeof(int), false)]
    [InlineData(typeof(uint), false)]
    [InlineData(typeof(long), false)]
    [InlineData(typeof(ulong), false)]
    [InlineData(typeof(float), false)]
    [InlineData(typeof(double), false)]
    [InlineData(typeof(decimal), false)]
    [InlineData(typeof(char), false)]
    [InlineData(typeof(string), true)]
    [InlineData(typeof(nint), false)]
    [InlineData(typeof(nuint), false)]
    [InlineData(typeof(Guid), false)]
    [InlineData(typeof(DateTime), false)]
    [InlineData(typeof(ValueType), false)]
    [InlineData(typeof(int?), true)]
    [InlineData(typeof(bool?), true)]
    [InlineData(typeof(decimal?), true)]
    [InlineData(typeof(char?), true)]
    [InlineData(typeof(DateTime?), true)]
    [InlineData(typeof(Guid?), true)]
    [InlineData(typeof(float?), true)]
    [InlineData(typeof(CompanyRequest.Address), true)]
    [InlineData(typeof(ConnectionStringResponse), true)]
    [InlineData(typeof(CustomerRequest), true)]
    [InlineData(typeof(CompanyRequest.Department), false)]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), false)]
    [InlineData(typeof(object), true)]
    [InlineData(typeof(IEnumerable<string>), true)]
    [InlineData(typeof(List<int>), true)]
    [InlineData(typeof(ICollection<double>), true)]
    public void Types_IsNullable_Expected(Type type, bool expected)
    {
        // Arrange && Act
        var act = type.IsNullable();


        // Assert
        act.Should().Be(expected);
    }
}
