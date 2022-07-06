using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrReports : BaseEntity
    {
          
 
		public Int32 RptId { get; set; }  
 
		public Int32 RptGroupRef { get; set; }  
 
		public String RptTitle { get; set; }  
 
		public String RptQuery { get; set; }  
 
		public String RptFile { get; set; }  
 
		public String RptDef { get; set; } 
    }
}


