using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.ReportService.DataAccessLayer.Entitites
{
   public class Report
    {
        public Guid ID { get; set; }
        public string ReportName { get; set; }
        public string Location { get; set; }
        public int PersonCount { get; set; }
        public int PhoneCount { get; set; }
        public DateTime RequestedDate { get; set; } = DateTime.Now;

        public ReportEnum status { get; set; }
    }
}
