using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstProductPackage : BaseEntity
    {
          
 
		public Int32 CstProductPackageId { get; set; }  
 
		public Nullable<Int32> CPPProductRef { get; set; }  
 
		public String CPPTitle { get; set; }  
 
		public DateTime CPPDate { get; set; }  
 
		public Nullable<Int32> CPPPeriodId { get; set; } 
    }
}


