using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalService.Web.Data;
using TechnicalService.Web.Models;

namespace TechnicalService.Web.Services
{
    public class ServiceItemService : IServiceItemService
    {
        private readonly ApplicationDbContext context;

        public ServiceItemService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ServiceItem> AddServiceItem(ServiceItem item)
        {
            item.Code = Helpers.StringHelper.Get5CharacterRandomString();
            context.ServiceItems.Add(item);
            await context.SaveChangesAsync();
            return item;
        }

        public ServiceItem GetWhere(Func<ServiceItem, bool> satisfyThis)
        {
            return context.ServiceItems.FirstOrDefault(satisfyThis);
        }
    }
}
