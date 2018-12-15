using System;
using Xunit;
using Shouldly;

namespace TestProject.Tests
{
    public class MathLibraryTests
    {
        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data_default_set_to_0__when__init_without_initial_data()
        {
            // Arrange
            var initial = 0;
            // Act

            // Assert
            initial.ShouldBe(0);
        }
    }
}
