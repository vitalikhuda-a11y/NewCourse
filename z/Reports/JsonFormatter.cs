using System;
using System.Collections.Generic;
using System.Text;

namespace z.Reports
{
    public class JsonFormatter: IReportFormatter
    {

        public string Format(List<Measurement> data)
        {
            var items = data.Select(d => $"{{\"t\":\"{d.Timestamp}\",\"v\":\"{d.Value}\"}}");
            return "[" + string.Join(",", items) + "]";
        }

    }
}
