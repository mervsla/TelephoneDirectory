using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.BusinessLayer.DTOs;
using TelephoneDirectory.ReportService.DataAccessLayer.Entitites;
using TelephoneDirectory.ReportService.DataAccessLayer.Repositories.Concrete;
using TelephoneDirectory.ReportService.DataAccessLayer.RSContext;

namespace TelephoneDirectory.ReportService.BusinessLayer.Managers
{
   public class ReportManager:IReportManager
    {
        ReportRepository reportRepository = new ReportRepository(new ReportServiceContext());
        public Report ConvertToReport(ReportDto reportDto)
        {
            Report report = new Report();
            report.ID = reportDto.ID;
            report.Location = reportDto.Location;
            report.PersonCount = reportDto.PersonCount;
            report.PhoneCount = reportDto.PhoneCount;
            report.RequestedDate = reportDto.RequestedDate;
            report.status = reportDto.status;

            return report;
        }
        public void AddReport(ReportDto reportDto)
        {
            Report report = ConvertToReport(reportDto);
            reportRepository.AddReport(report);

        }
    }
}
