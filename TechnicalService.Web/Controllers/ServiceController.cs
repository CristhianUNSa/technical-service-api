using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalService.Web.Models;
using TechnicalService.Web.Services;

namespace TechnicalService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceItemService _service;

        public ServiceController(IServiceItemService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("AddServiceItem")]
        public async Task<ActionResult<ServiceItem>> AddServiceItem(ServiceItem item)
        {
            var response = await _service.AddServiceItem(item);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }

        [HttpGet]
        [Route("GetServiceItem")]
        public ActionResult<ServiceItem> GetServiceItem(string itemId)
        {
            var response = _service.GetWhere(item => item.Code.Equals(itemId));
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }
    }
}