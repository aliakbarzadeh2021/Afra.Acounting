using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmCalenderDet : BaseEntity
    {
          
 
		public Int32 HCDHdrRef { get; set; }  
 
		public Int32 HCDDater { get; set; }  
 
		public DateTime HCDWorkBGDate { get; set; }  
 
		public DateTime HCDWorkBGTime { get; set; }  
 
		public DateTime HCDWorkENDate { get; set; }  
 
		public DateTime HCDWorkENTime { get; set; }  
 
		public DateTime HCDOvTimeBGDate { get; set; }  
 
		public DateTime HCDOvTimeBGTime { get; set; }  
 
		public DateTime HCDOvTimeENDate { get; set; }  
 
		public DateTime HCDOvTimeENTime { get; set; }  
 
		public DateTime HCDDelayBGDate { get; set; }  
 
		public DateTime HCDDelayBGTime { get; set; }  
 
		public DateTime HCDDelayENDate { get; set; }  
 
		public DateTime HCDDelayENTime { get; set; }  
 
		public Nullable<Int32> HCDDaySit { get; set; } 
    }
}


