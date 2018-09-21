using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class Service:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public virtual ICollection<StaffService> StaffService { get; set; }
        public virtual Department Department { get; set; }
    }
}
