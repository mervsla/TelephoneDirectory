using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.ReportService.BusinessLayer.DTOs
{
   public class ReportInfoFromUserDto
    {
        public string Location { get; set; }
        public int UserCount { get; set; }
        public int PhoneCount { get; set; }
    }
}
