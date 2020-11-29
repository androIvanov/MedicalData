using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
    class EDI837Message
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }

        public ICollection<Subscriber> Subscribers { get; set; }
    }
}
