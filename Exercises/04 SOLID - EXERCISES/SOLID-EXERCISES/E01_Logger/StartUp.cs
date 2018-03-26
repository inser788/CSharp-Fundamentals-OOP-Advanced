using System;
using E01_Logger.Controllers;

namespace E01_Logger
{
  public  class StartUp
    {
        static void Main()
        {
            var simpleCodeManualTester = new SimpleCodeManualTester();
            simpleCodeManualTester.FirstSample();
            simpleCodeManualTester.Implementations();
            simpleCodeManualTester.Extensibility();
            simpleCodeManualTester.ReportThreshold();

            var controller = new Controller();
            controller.GetAppendersFromConsole();
            controller.ExecuteCommands();
            controller.PrintAppenders();
        }

    }
}
