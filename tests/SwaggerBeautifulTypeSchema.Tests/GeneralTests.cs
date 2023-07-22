namespace SwaggerBeautifulTypeSchema.Tests;

public class GeneralTests
{
    [Theory]
    [InlineData(null, false)]
    [InlineData(typeof(bool), false)]
    [InlineData(typeof(byte), false)]
    [InlineData(typeof(Guid?), false)]
    [InlineData(typeof(float?), false)]
    [InlineData(typeof(object), true)]
    public void Types_IsObjectType_Expected(Type? type, bool expected)
    {
        // Arrange && Act
        var act = type.IsObjectType();


        // Assert
        act.Should().Be(expected);
    }
}
