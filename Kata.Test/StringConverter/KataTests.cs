using NUnit.Framework;
using KataStringConverter = Kata.Code.StringConverter;

namespace KataTest.StringConverter;

[TestFixture]
public class StringToNumberTest
{ 
    [Test]
    public void test1()
    {
        Assert.AreEqual(1234 , KataStringConverter.StringToNumber("1234"));
    }

    [Test]
    public void test2()
    {
        Assert.AreEqual(605 , KataStringConverter.StringToNumber("605"));
    }

    [Test]
    public void test3()
    {
        Assert.AreEqual(1405 , KataStringConverter.StringToNumber("1405"));
    }

    [Test]
    public void test4()
    {
        Assert.AreEqual(-7 , KataStringConverter.StringToNumber("-7"));
    }  
}