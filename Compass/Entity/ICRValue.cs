using System;
using System.ComponentModel.DataAnnotations;

namespace Compass.Entity
{
    public class ICRValue
    {
        //ENTRY NO
        [Key]
        public int ICRValueId { get; set; }
        [Required]
        public int ICRHeaderId { get; set; }

        public string EntryStatus { get; set; }
        public DateTime DateOfInventoryChange { get; set; }
        public string MbaCountryFrom { get; set; }
        public string MbaCountryTo { get; set; }
        public string TypeOfInventoryChange { get; set; }
        public string KmpCode { get; set; }
        [MaxLength(16)]
        public string NameOrNumberOfBatch { get; set; }
        public string NumberOfItemsInBatch { get; set; }
        [MaxLength(16)]
        public string ShipperBatch { get; set; }
        [MaxLength(10)]
        public double BurnUp { get; set; }
        public string MeterialDesc { get; set; }
        public string Element { get; set; }
        [MaxLength(16)]
        public double WeightOfElement { get; set; }
        [MaxLength(16)]
        public double WeightOfFissileIsotopes { get; set; }
        public string IsotopeCode { get; set; }
        public string MeasurBasis { get; set; }
        public string ConciseNoteEntry { get; set; }
        public int CorrectionToReportNo { get; set; }
        public int CorrectionToEntryNo { get; set; }


        //kayıt bilgisi

        public string UserCreated { get; set; }
        public DateTime CreationTime { get; set; }
        public string UserUpdated { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
