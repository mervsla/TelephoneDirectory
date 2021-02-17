using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.ReportService.BusinessLayer.DTOs;
using TelephoneDirectory.ReportService.BusinessLayer.Managers;

namespace TelephoneDirectory.ReportService.PresentationLayer
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        IReportManager reportManager;
        public ReportController(IReportManager _reportManager)
        {
            reportManager = _reportManager;

        }

        [HttpPost]
        public void AddUser(ReportDto reportDto)
        {
            reportManager.AddReport(reportDto);
        }
    }
}
