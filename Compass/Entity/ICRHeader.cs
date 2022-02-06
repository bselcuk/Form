using System;
using System.ComponentModel.DataAnnotations;

namespace Compass.Entity
{
    public class ICRHeader
    {
        //REPORT NO
        [Key]
        public int ICRHeaderId { get; set; }
        [Required]
        public int FormID { get; set; }


        public string CountryCode { get; set; }
        public string FacilityCode { get; set; }
        public string MeterialBalanceArea { get; set; }
        public bool ConsiceNoteReportLevel { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportStatus { get; set; }
        public DateTime PeriodCoveredByReportFrom { get; set; }
        public DateTime PeriodCoveredByReportTo { get; set; }
        public string EncoderName { get; set; }


        //kayıt bilgisi

        public string UserCreated { get; set; }
        public DateTime CreationTime { get; set; }
        public string UserUpdated { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}

