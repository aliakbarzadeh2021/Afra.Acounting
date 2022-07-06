using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayCalcCtrlDet : BaseEntity
    {
          
 
		public Int32 PCCDCtrlRef { get; set; }  
 
		public Int32 PCCDYearNum { get; set; }  
 
		public Int32 PCCDMonthNum { get; set; }  
 
		public Int32 PCCDPersRef { get; set; }  
 
		public Nullable<Int32> PCCDUserRef { get; set; }  
 
		public Nullable<Int32> PCCDSit { get; set; } 
    }
}


