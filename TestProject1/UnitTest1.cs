namespace TestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var config = Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.CreateDefault();

            Assert.IsNotNull(config);
            Assert.IsNotNull(config.TelemetryChannel);
            Assert.AreEqual(1, config.TelemetryProcessors.Count);
        }
    }
}
