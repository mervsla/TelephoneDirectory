using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.ReportBusConfigurator;
using TelephoneDirectory.ReportBusConfigurator.Models;
using TelephoneDirectory.ReportService.BusinessLayer.DTOs;
using TelephoneDirectory.ReportService.BusinessLayer.Managers;

namespace TelephoneDirectory.ReportService.PresentationLayer
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        IReportManager reportManager;
        public ReportController(IReportManager _reportManager)
        {
            reportManager = _reportManager;

        }


        [HttpPost]
        public async Task<IActionResult> AddNewReport(ReportDto reportDto)
        {
            Guid ID = Guid.NewGuid();
            reportDto.ID = ID;
            reportDto.ReportName = reportDto.Location.ToUpper() + " REPORT";
            reportDto.RequestedDate = DateTime.Now;
            reportDto.Location = reportDto.Location.ToUpper();

            reportManager.AddReport(reportDto);



            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMqConstants.RabbitMqUri}/{RabbitMqConstants.ConsumerQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IReportConsumer>(reportDto);
            return Ok("Your report request has been received ");

        }

        [HttpGet]
        public List<ReportDto> GetReports()
        {
            List<ReportDto> reports = reportManager.GetReports();
            return reports;
        }

        [HttpDelete]
        public void DeleteReport(ReportDto reportDto)
        {
            reportManager.DeleteReport(reportDto.ID);
        }


    }
}
