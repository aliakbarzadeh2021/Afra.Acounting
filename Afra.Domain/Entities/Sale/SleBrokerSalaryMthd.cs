using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleBrokerSalaryMthd : BaseEntity
    {
          
 
		public Int32 SleBrokerSalaryMthdId { get; set; }  
 
		public Int32 SleBrokerSalaryRef { get; set; }  
 
		public Nullable<Int32> SBSMCstmrGrpRef { get; set; }  
 
		public Nullable<Int32> SBSMCstmrRef { get; set; }  
 
		public Nullable<Int32> SBSMPartGrpRef { get; set; }  
 
		public Nullable<Int32> SBSMPartRef { get; set; }  
 
		public Nullable<Int32> SBSMPlaceRef { get; set; }  
 
		public Nullable<Int32> SBSMSaleType { get; set; }  
 
		public Double SBSMFVal { get; set; }  
 
		public Double SBSMTVal { get; set; }  
 
		public Double SBSMValue { get; set; } 
    }
}


