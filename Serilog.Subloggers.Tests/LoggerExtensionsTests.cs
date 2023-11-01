using Microsoft.Extensions.Logging;


namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class LoggerExtensionsTests
    {
        [TestMethod]
        public void Write_Debug()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Debug, "test");
            instance.AssertContains(LogLevel.Debug, "test");
        }

        [TestMethod]
        public void Write_Info()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Information, "test");
            instance.AssertContains(LogLevel.Information, "test");
        }

        [TestMethod]
        public void Write_Warning()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Warning, "test");
            instance.AssertContains(LogLevel.Warning, "test");
        }

        [TestMethod]
        public void Write_Critical()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Critical, "test");
            instance.AssertContains(LogLevel.Critical, "test");
        }

        [TestMethod]
        public void Write_Error()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Error, "test");
            instance.AssertContains(LogLevel.Error, "test");
        }

        [TestMethod]
        public void Write_Trace()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Trace, "test");
            instance.AssertContains(LogLevel.Trace, "test");
        }

        [TestMethod]
        public void Write_Debug_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Debug, "test {0}", "param");
            instance.AssertContains(LogLevel.Debug, "test param");
        }

        [TestMethod]
        public void Write_Info_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Information, "test {0}", "param");
            instance.AssertContains(LogLevel.Information, "test param");
        }

        [TestMethod]
        public void Write_Warning_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Warning, "test {0}", "param");
            instance.AssertContains(LogLevel.Warning, "test param");
        }

        [TestMethod]
        public void Write_Critical_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Critical, "test {0}", "param");
            instance.AssertContains(LogLevel.Critical, "test param");
        }

        [TestMethod]
        public void Write_Error_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Error, "test {0}", "param");
            instance.AssertContains(LogLevel.Error, "test param");
        }

        [TestMethod]
        public void Write_Trace_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Trace, "test {0}", "param");
            instance.AssertContains(LogLevel.Trace, "test param");
        }

        [TestMethod]
        public void Write_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Trace, new Exception("WriteEx"), "test {0}", "write");
            instance.AssertContainsException(LogLevel.Trace, "test write", "WriteEx");
        }

        [TestMethod]
        public void Write_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Write(LogLevel.Trace, new Exception("WriteEx"), "test write");
            instance.AssertContainsException(LogLevel.Trace, "test write", "WriteEx");
        }

        [TestMethod]
        public void Verbose()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Verbose("test");
            instance.AssertContains(LogLevel.Debug, "test");

        }

        [TestMethod]
        public void Verbose_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Verbose("{0}", "param");
            instance.AssertContains(LogLevel.Debug, "param");

        }

        [TestMethod]
        public void Verbose_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Verbose(new Exception("VerboseEx"), "test");
            instance.AssertContainsException(LogLevel.Debug, "test", "VerboseEx");

        }

        [TestMethod]
        public void Verbose_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Verbose(new Exception("VerboseEx"), "{0}", "param");
            instance.AssertContainsException(LogLevel.Debug, "param", "VerboseEx");

        }

        [TestMethod]
        public void Info()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Info("test Info");
            instance.AssertContains(LogLevel.Information, "test Info");

        }

        [TestMethod]
        public void Info_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Info("test {0}", "Info");
            instance.AssertContains(LogLevel.Information, "test Info");
        }

        [TestMethod]
        public void Info_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Info(new Exception("InfoEx"), "test");
            instance.AssertContainsException(LogLevel.Information, "test", "InfoEx");
        }

        [TestMethod]
        public void Info_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Info(new Exception("InfoEx"), "test {0}", "param");
            instance.AssertContainsException(LogLevel.Information, "test param", "InfoEx");
        }

        [TestMethod]
        public void Debug()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Debug("test Debug");
            instance.AssertContains(LogLevel.Debug, "test Debug");
        }

        [TestMethod]
        public void Debug_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Debug("{0}", "Debug");
            instance.AssertContains(LogLevel.Debug, "Debug");
        }

        [TestMethod]
        public void Debug_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Debug(new Exception("DebugEx"), "test Debug");
            instance.AssertContainsException(LogLevel.Debug, "test Debug", "DebugEx");
        }

        [TestMethod]
        public void Debug_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Debug(new Exception("DebugEx"), "{0}", "Debug");
            instance.AssertContainsException(LogLevel.Debug, "Debug", "DebugEx");
        }

        [TestMethod]
        public void Information()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Information("test Information");
            instance.AssertContains(LogLevel.Information, "test Information");
        }

        [TestMethod]
        public void Information_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Information("{0}", "Information");
            instance.AssertContains(LogLevel.Information, "Information");
        }

        [TestMethod]
        public void Information_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Information(new Exception("InformationEx"), "test Information");
            instance.AssertContainsException(LogLevel.Information, "test Information", "InformationEx");
        }

        [TestMethod]
        public void Information_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Information(new Exception("InformationEx"), "{0}", "Information");
            instance.AssertContainsException(LogLevel.Information, "Information", "InformationEx");
        }

        [TestMethod]
        public void Warning()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Warning("test Warning");
            instance.AssertContains(LogLevel.Warning, "test Warning");
        }

        [TestMethod]
        public void Warning_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Warning("{0}", "Warning");
            instance.AssertContains(LogLevel.Warning, "Warning");
        }

        [TestMethod]
        public void Warning_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Warning(new Exception("WarningEx"), "test Warning");
            instance.AssertContainsException(LogLevel.Warning, "test Warning", "WarningEx");
        }

        [TestMethod]
        public void Warning_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Warning(new Exception("WarningEx"), "{0}", "Warning");
            instance.AssertContainsException(LogLevel.Warning, "Warning", "WarningEx");
        }

        [TestMethod]
        public void Error()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Error("test Error");
            instance.AssertContains(LogLevel.Error, "test Error");
        }

        [TestMethod]
        public void Error_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Error("{0}", "Error");
            instance.AssertContains(LogLevel.Error, "Error");
        }

        [TestMethod]
        public void Error_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Error(new Exception("ErrorEx"), "test Error");
            instance.AssertContainsException(LogLevel.Error, "test Error", "ErrorEx");
        }

        [TestMethod]
        public void Error_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Error(new Exception("ErrorEx"), "{0}", "Error");
            instance.AssertContainsException(LogLevel.Error, "Error", "ErrorEx");
        }

        [TestMethod]
        public void Fatal()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Fatal("test Fatal");
            instance.AssertContains(LogLevel.Critical, "test Fatal");
        }

        [TestMethod]
        public void Fatal_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Fatal("{0}", "Fatal");
            instance.AssertContains(LogLevel.Critical, "Fatal");
        }

        [TestMethod]
        public void Fatal_Exception()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Fatal(new Exception("FatalEx"), "test Fatal");
            instance.AssertContainsException(LogLevel.Critical, "test Fatal", "FatalEx");
        }

        [TestMethod]
        public void Fatal_Exception_Params()
        {
            var instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Fatal(new Exception("FatalEx"), "{0}", "Fatal");
            instance.AssertContainsException(LogLevel.Critical, "Fatal", "FatalEx");
        }
    }
}