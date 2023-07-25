using System.Collections;
using Demo.Api.Models;

namespace SwaggerBeautifulTypeSchema.Tests;

public class ListsTests
{
    [Theory]
    [InlineData(null, false)]
    [InlineData(typeof(IDictionary<,>), false)]
    [InlineData(typeof(Dictionary<,>), false)]
    [InlineData(typeof(Dictionary<double, string>), false)]
    [InlineData(typeof(IEnumerable<string>), false)]
    [InlineData(typeof(List<int>), false)]
    [InlineData(typeof(IReadOnlyList<CompanyRequest.Department.Stakeholder>), false)]
    [InlineData(typeof(int[]), true)]
    [InlineData(typeof(ConnectionStringResponse[]), true)]
    [InlineData(typeof(ICollection<double>), false)]
    [InlineData(typeof(List<double>), false)]
    [InlineData(typeof(ArrayList), true)]
    [InlineData(typeof(Array), true)]
    [InlineData(typeof(ListSummary), false)]
    [InlineData(typeof(ResponseSummary<ProductResponse>), false)]
    public void Types_IsArray_Expected(Type? type, bool expected)
    {
        // Arrange && Act
        var act = type.IsArray();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(null, false)]
    [InlineData(typeof(Nullable), false)]
    [InlineData(typeof(Nullable<>), false)]
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
    [InlineData(typeof(int?), false)]
    [InlineData(typeof(bool?), false)]
    [InlineData(typeof(decimal?), false)]
    [InlineData(typeof(char?), false)]
    [InlineData(typeof(DateTime?), false)]
    [InlineData(typeof(Guid?), false)]
    [InlineData(typeof(float?), false)]
    [InlineData(typeof(CompanyRequest.Address), false)]
    [InlineData(typeof(ConnectionStringResponse), false)]
    [InlineData(typeof(CustomerRequest), false)]
    [InlineData(typeof(CompanyRequest.Department), false)]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), false)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(IDictionary<,>), false)]
    [InlineData(typeof(Dictionary<,>), false)]
    [InlineData(typeof(Dictionary<double, string>), false)]
    [InlineData(typeof(IEnumerable<string>), true)]
    [InlineData(typeof(List<int>), true)]
    [InlineData(typeof(IReadOnlyList<CompanyRequest.Department.Stakeholder>), true)]
    [InlineData(typeof(int[]), true)]
    [InlineData(typeof(ConnectionStringResponse[]), true)]
    [InlineData(typeof(ICollection<double>), true)]
    [InlineData(typeof(List<double>), true)]
    [InlineData(typeof(ArrayList), true)]
    [InlineData(typeof(Array), true)]
    [InlineData(typeof(ListSummary), false)]
    [InlineData(typeof(ResponseSummary<ProductResponse>), false)]
    public void Types_IsListingType_Expected(Type type, bool expected)
    {
        // Arrange && Act
        var act = type.IsListingType();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(null, false)]
    [InlineData(typeof(Nullable), false)]
    [InlineData(typeof(Nullable<>), false)]
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
    [InlineData(typeof(int?), false)]
    [InlineData(typeof(bool?), false)]
    [InlineData(typeof(decimal?), false)]
    [InlineData(typeof(char?), false)]
    [InlineData(typeof(DateTime?), false)]
    [InlineData(typeof(Guid?), false)]
    [InlineData(typeof(float?), false)]
    [InlineData(typeof(CompanyRequest.Address), false)]
    [InlineData(typeof(ConnectionStringResponse), false)]
    [InlineData(typeof(CustomerRequest), false)]
    [InlineData(typeof(CompanyRequest.Department), false)]
    [InlineData(typeof(CompanyRequest.Department.Stakeholder), false)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(IDictionary<,>), true)]
    [InlineData(typeof(Dictionary<,>), true)]
    [InlineData(typeof(Dictionary<double, string>), true)]
    [InlineData(typeof(IEnumerable<string>), false)]
    [InlineData(typeof(List<int>), false)]
    [InlineData(typeof(IReadOnlyList<CompanyRequest.Department.Stakeholder>), false)]
    [InlineData(typeof(int[]), false)]
    [InlineData(typeof(ConnectionStringResponse[]), false)]
    [InlineData(typeof(ICollection<double>), false)]
    [InlineData(typeof(List<double>), false)]
    [InlineData(typeof(ArrayList), false)]
    [InlineData(typeof(Array), false)]
    [InlineData(typeof(ListSummary), false)]
    [InlineData(typeof(ResponseSummary<ProductResponse>), false)]
    public void Types_IsIndexedListType_Expected(Type type, bool expected)
    {
        // Arrange && Act
        var act = type.IsIndexedListType();


        // Assert
        act.Should().Be(expected);
    }
}
