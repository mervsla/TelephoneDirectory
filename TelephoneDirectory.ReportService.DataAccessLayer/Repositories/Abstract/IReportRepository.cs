using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.DataAccessLayer.Entitites;

namespace TelephoneDirectory.ReportService.DataAccessLayer.Repositories.Abstract
{
   public interface IReportRepository 
    {
        void AddReport(Report report);
        List<Report> GetReports();
        Report GetReportById(Guid id);
        void DeleteReport(Report report);
    }
}
