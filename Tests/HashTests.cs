namespace HashEndpoint.Tests;

public class HashTests
{
    [Fact]
    public void TestGenerateHash()
    {
        string input = "test string";

        var generatedHash = Hash.GenerateHash(input);

        Assert.NotNull(generatedHash);
        Assert.NotNull(generatedHash.Value);
        Assert.Equal(64, generatedHash.Value.Length);
    }
}