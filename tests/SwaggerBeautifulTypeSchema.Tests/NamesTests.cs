using Demo.Api.Models;

namespace SwaggerBeautifulTypeSchema.Tests;

public class NamesTests
{
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
    [InlineData(typeof(CompanyRequest.Address), "Address")]
    [InlineData(typeof(ConnectionStringResponse), "ConnectionStringResponse")]
    [InlineData(typeof(CustomerRequest), "CustomerRequest")]
    [InlineData(typeof(CompanyRequest.Department), "Department")]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), "Stakeholder")]
    [InlineData(typeof(object), null)]
    public void Types_GetNameIfNotPrimitive_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.GetNameIfNotPrimitive();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(bool), "Boolean")]
    [InlineData(typeof(byte), "Byte")]
    [InlineData(typeof(sbyte), "SByte")]
    [InlineData(typeof(short), "Int16")]
    [InlineData(typeof(ushort), "UInt16")]
    [InlineData(typeof(int), "Int32")]
    [InlineData(typeof(uint), "UInt32")]
    [InlineData(typeof(long), "Int64")]
    [InlineData(typeof(ulong), "UInt64")]
    [InlineData(typeof(float), "Float")]
    [InlineData(typeof(double), "Double")]
    [InlineData(typeof(decimal), "Decimal")]
    [InlineData(typeof(char), "Char")]
    [InlineData(typeof(string), "String")]
    [InlineData(typeof(Guid), "Guid")]
    [InlineData(typeof(DateTime), "DateTime")]
    [InlineData(typeof(CompanyRequest.Address), "Address")]
    [InlineData(typeof(ConnectionStringResponse), "ConnectionStringResponse")]
    [InlineData(typeof(CustomerRequest), "CustomerRequest")]
    [InlineData(typeof(CompanyRequest.Department), "Department")]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), "Stakeholder")]
    [InlineData(typeof(object), "Object")]
    public void Types_GetRawName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.GetRawName();


        // Assert
        act.Should().Be(expected);
    }
}
