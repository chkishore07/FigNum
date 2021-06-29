using FigNumAPI.Controllers;
using FigNumAPI.Repository;
using System;
using Xunit;

namespace FigNumAPIUnitTest
{
    public class NonPrimeTest
    {
        //Arrange
        ProcessController _controller;
        DataProcessor _dataProcessor;
        string _numList;

        /// <summary>
        /// Constructor for test data
        /// </summary>
        public NonPrimeTest()
        {
            _dataProcessor = new DataProcessor();
            _controller = new ProcessController(_dataProcessor);
            _numList = "1,9,11,7,120,17,4,6,23,a,5,2,25,3";
        }

        /// <summary>
        /// Test method to validate prime numbers elimination
        /// </summary>
        [Fact]
        public void NonPrimeString()
        {
            var expected = "1,4,6,9,25,120";
            var actual = _controller.TrimPrimeNumbers(_numList);

            Assert.Equal(expected, actual);
        }
    }
}
