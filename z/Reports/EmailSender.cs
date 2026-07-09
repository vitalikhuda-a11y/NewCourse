using System;
using System.Collections.Generic;
using System.Text;

namespace z.Reports
{
    public class EmailSender:IReportSender
    {


        public void Send(string content)
        {
            var smtp = new System.Net.Mail.SmtpClient("smtp.company.local");
            smtp.Send("reports@company.local", "target@email.com", "Звіт", content);
        }

    }
}
