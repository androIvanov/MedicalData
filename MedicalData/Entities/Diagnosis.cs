﻿using System;
using System.Collections.Generic;
namespace MedicalData.Entities
{
    class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string SetID { get; set; }
        public string DiagnosisCodingMethod { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisDescription { get; set; }
        public DateTime? DiagnosisDateTime { get; set; }
        public string DiagnosisType { get; set; }
        public string DiagnosticRelatedGroup { get; set; }
        public int AccountId { get; set; }

        // navigational properties

        public PatientAccount PatientAccount { get; set; }
        public ICollection<Procedure> Procedures { get; set; }
    }
}
