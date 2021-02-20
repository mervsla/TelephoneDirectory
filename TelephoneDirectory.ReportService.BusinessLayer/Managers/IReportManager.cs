using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.BusinessLayer.DTOs;

namespace TelephoneDirectory.ReportService.BusinessLayer.Managers
{
   public interface IReportManager
    {
        void AddReport(ReportDto reportDto);
        List<ReportDto> GetReports();
        void DeleteReport(Guid id);
    }
}
