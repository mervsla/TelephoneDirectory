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
            report.ReportName = reportDto.ReportName;
            report.Location = reportDto.Location;
            report.PersonCount = reportDto.PersonCount;
            report.PhoneCount = reportDto.PhoneCount;
            report.RequestedDate = reportDto.RequestedDate;
            report.status = reportDto.status;

            return report;
        }


        public ReportDto ConvertToDto(Report report)
        {
            ReportDto reportDto = new ReportDto();
            reportDto.ID = report.ID;
            reportDto.ReportName = report.ReportName;
            reportDto.PersonCount = report.PersonCount;
            reportDto.PhoneCount = report.PhoneCount;
            reportDto.RequestedDate = report.RequestedDate;
            reportDto.status = report.status;

            return reportDto;
        }


        public void AddReport(ReportDto reportDto)
        {
            Report report = ConvertToReport(reportDto);
            reportRepository.AddReport(report);
        }

        public List<ReportDto> GetReports()
        {
            List<Report> reports = reportRepository.GetReports();

            List<ReportDto> reportDtos = new List<ReportDto>();

            foreach(Report r in reports)
            {
                ReportDto reportDto = new ReportDto();
                reportDto.ID = r.ID;
                reportDto.Location = r.Location;
                reportDto.ReportName = r.ReportName;
                reportDto.PersonCount = r.PersonCount;
                reportDto.PhoneCount = r.PhoneCount;
                reportDto.CreatedDate = r.RequestedDate.ToShortDateString() + "-" + r.RequestedDate.ToShortTimeString();
                reportDto.status = r.status;

                reportDtos.Add(reportDto);

            }


            return reportDtos;
        }



        public void DeleteReport(Guid id)
        {
            Report report = reportRepository.GetReportById(id);
            reportRepository.DeleteReport(report);
        }



    }
}
