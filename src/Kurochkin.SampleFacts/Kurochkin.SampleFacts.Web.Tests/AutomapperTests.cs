using Kurochkin.SampleFacts.Web.Infrastructure.Mappers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kurochkin.SampleFacts.Web.Tests
{
    public class AutomapperTests
    {
        [Fact]
        [Trait("Automapper", "Mapper Configuration")]
        public void ItShouldPerformCorrectConfiguration()
        {
            var config = MapperRegistration.GetMapperConfiguration();

            config.AssertConfigurationIsValid();
        }
    }
}
