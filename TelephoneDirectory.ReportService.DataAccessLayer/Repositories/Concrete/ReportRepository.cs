using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.ReportService.DataAccessLayer.RSContext;
using TelephoneDirectory.ReportService.DataAccessLayer.Entitites;

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

      
    }
}
