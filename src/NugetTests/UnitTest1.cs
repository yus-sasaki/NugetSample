using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SlackNotification;

namespace NugetTests
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
