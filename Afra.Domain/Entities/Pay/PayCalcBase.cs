using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayCalcBase : BaseEntity
    {
          
 
		public Int32 PayCalcBaseId { get; set; }  
 
		public Nullable<Int32> PCBType { get; set; }  
 
		public Nullable<Int32> PCBPersRef { get; set; }  
 
		public Nullable<Int32> PCBElmntRef { get; set; }  
 
		public Nullable<Int32> PCBYearNum { get; set; }  
 
		public Nullable<Int32> PCBMonthNum { get; set; }  
 
		public Nullable<Int32> PCBVal { get; set; }  
 
		public Nullable<Int32> PCBYearMonth { get; set; } 
    }
}


