using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleFixAcc : BaseEntity
    {
          
 
		public Int32 SFAGroupRef { get; set; }  
 
		public String SFACstmrRcv { get; set; }  
 
		public String SFACstmrPay { get; set; }  
 
		public String SFACstmrPre { get; set; }  
 
		public Nullable<Int32> SFADL4Type { get; set; }  
 
		public Nullable<Int32> SFADL5Type { get; set; }  
 
		public Nullable<Int32> SFADL6Type { get; set; } 
    }
}


