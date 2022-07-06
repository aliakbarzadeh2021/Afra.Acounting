using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayImpDet : BaseEntity
    {
          
 
		public Int32 PayImpDetId { get; set; }  
 
		public Int32 PayImpFileRef { get; set; }  
 
		public Int32 PIFElmntRef { get; set; }  
 
		public String PIFFieldName { get; set; }  
 
		public Nullable<Int32> PIFStartInd { get; set; }  
 
		public String PIFDayFldName { get; set; }  
 
		public Nullable<Int32> PIFDayStart { get; set; }  
 
		public Nullable<Int32> PIFDayCnt { get; set; }  
 
		public String PIFHourFldName { get; set; }  
 
		public Nullable<Int32> PIFHourStart { get; set; }  
 
		public Nullable<Int32> PIFHourCnt { get; set; }  
 
		public String PIFMinFldName { get; set; }  
 
		public Nullable<Int32> PIFMinStart { get; set; }  
 
		public Nullable<Int32> PIFMinCnt { get; set; }  
 
		public String PIFAmntFldName { get; set; }  
 
		public Nullable<Int32> PIFAmntStart { get; set; }  
 
		public Nullable<Int32> PIFAmntCnt { get; set; }  
 
		public Nullable<Int32> PIFVacRef { get; set; } 
    }
}


