using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmTables : BaseEntity
    {
          
 
		public Int32 HrmTablesId { get; set; }  
 
		public String HTTitle { get; set; }  
 
		public Int32 HTLevel { get; set; }  
 
		public Int32 HTKind { get; set; }  
 
		public String HTField1 { get; set; }  
 
		public String HTField2 { get; set; }  
 
		public String HTField3 { get; set; } 
    }
}


