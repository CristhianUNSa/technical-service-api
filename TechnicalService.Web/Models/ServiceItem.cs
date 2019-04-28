using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalService.Web.Models
{
    public class ServiceItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string ProductName { get; set; }
        public string ClientName { get; set; }
        public virtual ServiceStatus Status { get; set; }
    }
}
