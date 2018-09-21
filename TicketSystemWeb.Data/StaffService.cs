using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class StaffService
    {
        public int Id { get; set; }

        
        public int StaffId { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }

        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }
    }
}
