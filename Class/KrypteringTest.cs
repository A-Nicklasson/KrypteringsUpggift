global using Xunit;

public class KrypteringTest
{
    [Fact]

    public void KrypteringFormatTest() {

        string encryptedInput = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string expectedResult = "DEFGHIJKLMNOPQRSTUVWXYZABC";

        string result = Encrypt.kryptering(encryptedInput);

        Assert.Equal(expectedResult, result);

    }

    [Fact]
    public void AvKrypteringFormatTest()
    {

        string encryptedInput = "DEFGHIJKLMNOPQRSTUVWXYZABC";
        string expectedResult = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string result = Decrypt.AvKryptering(encryptedInput);

        Assert.Equal(expectedResult, result);

    }
}