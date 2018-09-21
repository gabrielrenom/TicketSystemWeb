using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class Ticket:BaseEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public StatusType Status { get; set; }
        public int StudentId { get; set; }
        public int? StaffId { get; set; }
        public int ServiceId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }

    public enum StatusType {Close=0, Open=1,Pending=2,Return=3 }
}
