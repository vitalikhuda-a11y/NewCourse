using System;
using System.Collections.Generic;
using System.Text;

namespace z.Reports
{
    public class CsvFormatter: IReportFormatter
    {

        public string Format(List<Measurement> data)
        {
            return string.Join("\n", data.Select(d => $"{d.Timestamp},{d.Value}"));
        }

    }
}
