using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleBranchs : BaseEntity
    {
          
 
		public Int32 SleBranchId { get; set; }  
 
		public String SleBranchCode { get; set; }  
 
		public String SleBranchName { get; set; }  
 
		public String SleBranchDLRef { get; set; } 
    }
}


