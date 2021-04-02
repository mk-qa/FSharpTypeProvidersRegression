using ClassLibrary1;
using FluentAssertions;
using Xunit;
using RegexTypeProvider;

namespace TestCSharpWithFSharp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyEnum a = MyEnum.Item1;
            var test = TestRegex.value1;
            a.Should().Be(MyEnum.Item1);
        }
    }
}
