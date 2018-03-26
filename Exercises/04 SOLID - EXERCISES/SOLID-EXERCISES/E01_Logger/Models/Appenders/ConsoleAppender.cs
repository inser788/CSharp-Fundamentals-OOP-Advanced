using System;
using E01_Logger.Enums;
using E01_Logger.Interfaces;

namespace E01_Logger.Models.Appenders
{
   public class ConsoleAppender:IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, string reportLevel, string message)
        {
            var formattedMessage = this.Layout.FormatMessage(dateTime, reportLevel, message);

            Console.WriteLine(formattedMessage);
        }
    }
}
