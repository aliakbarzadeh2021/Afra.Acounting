using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayCalcState : BaseEntity
    {
          
 
		public Int32 PayCalcStateId { get; set; }  
 
		public Int32 PCSPersRef { get; set; }  
 
		public Int32 PCSYearNum { get; set; }  
 
		public Int32 PCSMonthNum { get; set; }  
 
		public Nullable<Int32> PCSCalcType { get; set; }  
 
		public Nullable<Int32> PCSYearMonth { get; set; }  
 
		public Nullable<Int32> PCSUserRef { get; set; }  
 
		public Nullable<Int32> PCSOrgType { get; set; } 
    }
}


