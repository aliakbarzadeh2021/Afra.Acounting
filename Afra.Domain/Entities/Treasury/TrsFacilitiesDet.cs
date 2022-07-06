using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacilitiesDet : BaseEntity
    {
          
 
		public Int32 TrsFacilitiesDetId { get; set; }  
 
		public Int32 TFDFacRef { get; set; }  
 
		public Int32 TFDNum { get; set; }  
 
		public String TFDPaySerial { get; set; }  
 
		public DateTime TFDDate { get; set; }  
 
		public Double TFDInstAmnt { get; set; }  
 
		public Nullable<Double> TFDShareAmnt { get; set; }  
 
		public Nullable<Double> TFDTaxAmnt { get; set; }  
 
		public Nullable<Double> TFDDutyAmnt { get; set; }  
 
		public Nullable<Double> TFDLateAmnt { get; set; }  
 
		public Nullable<Double> TFDPayAmnt { get; set; }  
 
		public String TFDDescr { get; set; }  
 
		public DateTime TFDPayDate { get; set; }  
 
		public Nullable<Int32> TFDAccPrdRef { get; set; } 
    }
}


