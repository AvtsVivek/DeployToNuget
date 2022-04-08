using FluentAssertions;
using Xunit;

namespace SimpleClassLib.Tests
{
    public class MyClassTests
    {
        [Fact]
        public void Test1()
        {
            var class1 = new MyClass();

            class1.Value.Should().Be("Foo");
        }
    }
}