using System;
using Xunit;
using AzurePipelineDemo.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace AzurePipelineDemo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var logger = Mock.Of<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger);
            var response = controller.Get();
            Assert.NotNull(response);
        }
    }
}
