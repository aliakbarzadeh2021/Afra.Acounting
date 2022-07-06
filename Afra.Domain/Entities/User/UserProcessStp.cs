using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserProcessStp : BaseEntity
    {
          
 
		public Int32 UserProcessStpId { get; set; }  
 
		public Int32 UPSHdrRef { get; set; }  
 
		public Int32 UPSStepRef { get; set; }  
 
		public Int32 UPSUserRef { get; set; }  
 
		public Nullable<Int32> UPSRefId { get; set; }  
 
		public DateTime UPSCrDate { get; set; }  
 
		public DateTime UPSShDate { get; set; }  
 
		public DateTime UPSEnDate { get; set; } 
    }
}


