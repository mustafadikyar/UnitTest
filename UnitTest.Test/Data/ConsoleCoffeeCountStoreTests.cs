﻿using UnitTest.Data;
using UnitTest.Models;

namespace UnitTest.Test.Data
{
    public class ConsoleCoffeeCountStoreTests
    {
        [Fact]
        public void ShouldWriteOutputToConsole()
        {
            // Arrange
            var item = new CoffeeCountItem("Cappuccino", 5);
            var stringWriter = new StringWriter();
            var consoleCoffeeCountStore = new ConsoleCoffeeCountStore(stringWriter);

            // Act
            consoleCoffeeCountStore.Save(item);

            // Assert
            var result = stringWriter.ToString();
            Assert.Equal($"{item.CoffeeType}:{item.Count}{Environment.NewLine}", result);
        }
    }
}
