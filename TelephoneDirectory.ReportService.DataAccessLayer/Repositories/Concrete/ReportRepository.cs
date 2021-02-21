using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.ReportService.DataAccessLayer.RSContext;
using TelephoneDirectory.ReportService.DataAccessLayer.Entitites;
using System.Linq;

namespace TelephoneDirectory.ReportService.DataAccessLayer.Repositories.Concrete
{
    public class ReportRepository : IReportRepository
    {

        protected ReportServiceContext _rcontext;
        public ReportRepository(ReportServiceContext context)
        {
            _rcontext = context;
        }

       
        public void AddReport(Report report)
        {
            _rcontext.Reports.Add(report);
            _rcontext.SaveChanges();
        }


        public List<Report> GetReports()
        {
           return _rcontext.Reports.ToList();
        }

        public Report GetReportById(Guid id)
        {
            return _rcontext.Reports.FirstOrDefault(x => x.ID == id);
        }
        public void DeleteReport(Report report)
        {
            _rcontext.Reports.Remove(report);
            _rcontext.SaveChanges();
        }


    }
}
