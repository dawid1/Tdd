using System;
using Xunit;
using Shouldly;

namespace TestProject.Tests
{
    public class MathLibraryTests
    {
        
        private MathLibrary Sut;

        public MathLibraryTests()
        {
            
        }

        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data_default_set_to_0__when__init_without_initial_data()
        {
            // Arrange
            var initial = 0; 

            // Act
            Sut = new MathLibrary(initial);

            // Assert
            Sut.Value.ShouldBe(initial);
        }

        public void increase_new_value__when__add_value_to_earlier_value()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
