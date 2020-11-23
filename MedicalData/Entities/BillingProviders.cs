using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData
{
    class BillingProviders
    {
        public int ProviderId { get; set; }
        public string ProviderCode { get; set; }
        public string ReferenceIdQualifier { get; set; }
        public string ReferenceID { get; set; }
        public string EntityTypeQualifier { get; set; }
        public string NameLast { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string IdentificationCodeQualifier { get; set; }
        public string IdentificationCode { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string TaxReferenceIdQualifier { get; set; }
        public string TaxReferenceId { get; set; }
    }
}
