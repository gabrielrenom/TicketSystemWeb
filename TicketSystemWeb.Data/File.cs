using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class File:BaseEntity
    {
        public int Id { get; set; }
        public string NameOfFile { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public byte[] Data { get; set; }

        public int TicketId { get;set; }
        public virtual Ticket Ticket { get; set; }

    }
}
