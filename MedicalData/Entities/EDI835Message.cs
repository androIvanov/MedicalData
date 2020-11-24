using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class EDI835Message
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
