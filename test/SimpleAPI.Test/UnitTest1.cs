using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        [Fact]
        public void TEST_GET()
        {


          //Arrange
            var newSum=2;

            //Act
             var neDat=1+3;

            //Assert

            Assert.Equal(neDat,newSum);

        }
    }
}
