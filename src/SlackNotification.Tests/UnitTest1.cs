using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SlackNotification.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
	        var slackNotificationService = new SlackNotificationService();
            Assert.IsNotNull(slackNotificationService);
        }
    }
}
