using KataLogic;

namespace CodeKataBase;

public class Tests
{
    Kata classUnderTest;
    
    [SetUp]
    public void Setup()
    {
        classUnderTest = new Kata();
    }

    [Test]
    public void Test1()
    {
        classUnderTest.KataLogic();
    }
}