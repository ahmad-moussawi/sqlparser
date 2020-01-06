using System;
using Xunit;

namespace SqlParser.Test
{
    public class BasicTests
    {
        [Fact]
        public void IsInsert()
        {
            var parser = new Parser();
            Assert.True(parser.IsInsert("insert into table values('a', 'b')"));
        }
    }
}
