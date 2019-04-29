using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalService.Web.Models;

namespace TechnicalService.Web.Services
{
    public interface IServiceItemService
    {
        Task<ServiceItem> AddServiceItem(ServiceItem item);
        ServiceItem GetWhere(Func<ServiceItem, bool> satisfyThis);
    }
}
