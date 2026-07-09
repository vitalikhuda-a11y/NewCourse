using System;
using System.Collections.Generic;
using System.Text;

namespace z.Reports
{
    public class ReportGenerator
    {
        private readonly IReportFormatter _formatter;
        private readonly IReportSender _sender;

        public ReportGenerator(IReportFormatter formatter, IReportSender sender)
        {
            _formatter = formatter;
            _sender = sender;
        }

        public void GenerateAndSend(List<Measurement> data)
        {
            string content = _formatter.Format(data);
            _sender.Send(content);
        }
    }
}
