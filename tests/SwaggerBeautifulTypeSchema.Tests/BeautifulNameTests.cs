using Demo.Api.Models;

namespace SwaggerBeautifulTypeSchema.Tests;

public class BeautifulNameTests
{
    [Theory]
    [InlineData(typeof(int[]), "Int32[]")]
    [InlineData(typeof(uint[][]), "UInt32[][]")]
    public void GenericTypes_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(int[]), "Int32[]")]
    [InlineData(typeof(uint[][]), "UInt32[][]")]
    public void Arrays_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(IEnumerable<string>), "String[]")]
    [InlineData(typeof(ICollection<double>), "Double[]")]
    [InlineData(typeof(List<int>), "Int32[]")]
    [InlineData(typeof(List<int[]>), "Int32[][]")]
    [InlineData(typeof(List<int[][]>), "Int32[][][]")]
    public void Lists_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(bool), null)]
    [InlineData(typeof(byte), null)]
    [InlineData(typeof(sbyte), null)]
    [InlineData(typeof(short), null)]
    [InlineData(typeof(ushort), null)]
    [InlineData(typeof(int), null)]
    [InlineData(typeof(uint), null)]
    [InlineData(typeof(long), null)]
    [InlineData(typeof(ulong), null)]
    [InlineData(typeof(float), null)]
    [InlineData(typeof(double), null)]
    [InlineData(typeof(decimal), null)]
    [InlineData(typeof(char), null)]
    [InlineData(typeof(string), null)]
    [InlineData(typeof(nint), null)]
    [InlineData(typeof(nuint), null)]
    [InlineData(typeof(Guid), null)]
    [InlineData(typeof(DateTime), null)]
    [InlineData(typeof(ValueType), null)]
    [InlineData(typeof(int?), null)]
    [InlineData(typeof(bool?), null)]
    [InlineData(typeof(decimal?), null)]
    [InlineData(typeof(char?), null)]
    [InlineData(typeof(DateTime?), null)]
    [InlineData(typeof(Guid?), null)]
    [InlineData(typeof(float?), null)]
    [InlineData(typeof(CompanyRequest.Address), "CompanyRequest.Address")]
    [InlineData(typeof(ConnectionStringResponse), "ConnectionStringResponse")]
    [InlineData(typeof(CustomerRequest), "CustomerRequest")]
    [InlineData(typeof(CompanyRequest.Department), "CompanyRequest.Department")]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), "CompanyRequest.Department.Stakeholder")]
    [InlineData(typeof(object), "Object")]
    public void Types_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }
}
