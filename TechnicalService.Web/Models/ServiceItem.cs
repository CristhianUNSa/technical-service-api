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

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ClientName { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        public virtual ServiceStatus Status { get; set; }

        [NotMapped]
        public string StatusName {
            get
            {
                return Status.ToString();
            }
        }
    }
}
