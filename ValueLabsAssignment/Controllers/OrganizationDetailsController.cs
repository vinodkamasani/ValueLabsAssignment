using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ValueLabsAssignment.Services;

namespace ValueLabsAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganizationDetailsController : ControllerBase
    {
        private static readonly string[] organizations = new[]
        {
            "AAWW", "AAL", "CPAAW", "PRAA", "PAAS", "RYAAY"
        };


        private readonly ILogger<OrganizationDetailsController> _logger;
        private ResponseDTO ResponseDTO;
        private readonly IOrgDetailsService service;

        public OrganizationDetailsController(ILogger<OrganizationDetailsController> logger, IOrgDetailsService service)
        {
            _logger = logger;
            this.service = service;
            ResponseDTO = new ResponseDTO();
        }


        [HttpGet]
        public IActionResult GetMaximumQuotePriceAndAveragePriceChange()
        {
            try
            {

                this.ResponseDTO.Data = service.GetMaximumQuotePrice(organizations.ToList());
                this.ResponseDTO.IsSuccess = true;

            }
            catch (Exception ex)
            {
                this.ResponseDTO.Message = ex.Message;
                this._logger.LogError(ex.Message, ex);
            }
            return this.Ok(this.ResponseDTO);
        }

        [HttpGet("GetAveragePricesForAllOrgs")]
        public IActionResult GetAveragePricesForAllOrgs()
        {
            try
            {

                this.ResponseDTO.Data = service.AverageQuotesFromAllOrgs(organizations.ToList());
                this.ResponseDTO.IsSuccess = true;

            }
            catch (Exception ex)
            {
                this.ResponseDTO.Message = ex.Message;
                this._logger.LogError(ex.Message, ex);
            }
            return this.Ok(this.ResponseDTO);
        }
    }
}