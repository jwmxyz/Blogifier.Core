using Blogifier.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Core.Tests.Services
{
    public class EmailServiceTests
    {
        [Fact]
        public async Task CanImportFromRssFeed()
        {
            var sut = GetSut();

            await sut.SendEmail("rtur.net@gmail.com", "test", "testing blogifier");

            Assert.NotNull(sut);
        }

        private SendGridService GetSut()
        {
            var data = new Mock<IDataService>();
            var logger = new Mock<ILogger<SendGridService>>();
            var storage = new Mock<IStorageService>();
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            return new SendGridService(data.Object, config, logger.Object, storage.Object);
        }
    }
}
