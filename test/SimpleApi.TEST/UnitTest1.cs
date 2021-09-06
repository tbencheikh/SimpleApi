using System;
using Moq;
using Xunit;
using SimpleApi.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleApi.TEST
{
    public class UnitTest1
    {
       

        [Fact]
        public void TestName()
        {
            var wc= new WeatherForecastController();
            //Given
            var returnValue = wc.Get();
            //When
            
            //Then
            Assert.NotNull(returnValue);
        }
    }
}
