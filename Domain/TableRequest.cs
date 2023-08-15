using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class TableRequest
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public AppUser Author { get; set; }
        public Table Table { get; set; }
        public Guid TableId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}