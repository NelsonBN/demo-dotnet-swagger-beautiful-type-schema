using Demo.Api.Models;

namespace SwaggerBeautifulTypeSchema.Tests;

public class GenericTypeTests
{
    [Theory]
    [InlineData(typeof(Response<Client>), "Response<Client>")]
    [InlineData(typeof(Response<string>), "Response<String>")]
    [InlineData(typeof(Response<int>), "Response<Int32>")]
    [InlineData(typeof(Response<List<int>>), "Response<Int32[]>")]
    [InlineData(typeof(Response<Response<int>>), "Response<Response<Int32>>")]
    [InlineData(typeof(Response<Response<Client>>), "Response<Response<Client>>")]
    public void OneGeneric_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(ListResponse<string, ListMetadata>), "ListResponse<String,ListMetadata>")]
    [InlineData(typeof(ListResponse<Client, ListMetadata>), "ListResponse<Client,ListMetadata>")]
    [InlineData(typeof(Response<int, double>), "Response<Int32,Double>")]
    [InlineData(typeof(Response<int, int>), "Response<Int32,Int32>")]
    [InlineData(typeof(Response<int, uint>), "Response<Int32,UInt32>")]
    [InlineData(typeof(Response<Response<List<int>, uint>>), "Response<Response<Int32[],UInt32>>")]
    [InlineData(typeof(Response<Response<int[], uint>>), "Response<Response<Int32[],UInt32>>")]
    public void TwoGeneric_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }

    [Theory]
    [InlineData(typeof(ListSummaryResponse<Client, ListMetadata, ListSummary>), "ListSummaryResponse<Client,ListMetadata,ListSummary>")]
    [InlineData(typeof(ResponseThree<long, long, long>), "ResponseThree<Int64,Int64,Int64>")]
    [InlineData(typeof(ResponseThree<float, uint, float>), "ResponseThree<Float,UInt32,Float>")]
    public void ThreeGeneric_BeautifulName_Expected(Type type, string expected)
    {
        // Arrange && Act
        var act = type.BeautifulName();


        // Assert
        act.Should().Be(expected);
    }
}
