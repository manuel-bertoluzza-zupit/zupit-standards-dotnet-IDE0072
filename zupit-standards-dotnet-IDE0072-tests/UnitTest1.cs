using zupit_standards_dotnet_IDE0072;

namespace zupit_standards_dotnet_IDE0072_tests;

public class Tests
{

    [Test]
    public void TestGetValueEnumItem1()
    {
        Assert.That(MyProgram.GetValue(MyEnum.Item1), Is.EqualTo(1));
    }
    
    [Test]
    public void TestGetValueEnumItem2()
    {
        Assert.That(MyProgram.GetValue(MyEnum.Item2), Is.EqualTo(1));
    }
    
    [Test]
    public void TestGetValueEnumItem3()
    {
        Assert.That(MyProgram.GetValue(MyEnum.Item3), Is.EqualTo(1));
    }
    
    [Test]
    public void TestGetValueEnumItem4()
    {
        Assert.That(MyProgram.GetValue(MyEnum.Item4), Is.EqualTo(2));
    }
    
    [Test]
    public void TestGetValueEnumItem5()
    {
        Assert.That(MyProgram.GetValue(MyEnum.Item5), Is.EqualTo(0));
    }
}