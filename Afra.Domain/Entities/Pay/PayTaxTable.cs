using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayTaxTable : BaseEntity
    {
          
 
		public Int32 PayTaxTblId { get; set; }  
 
		public String PTTTitle { get; set; }  
 
		public Int32 PTTIssueYear { get; set; }  
 
		public Int32 PTTIssueMonth { get; set; }  
 
		public String PTTGrpType { get; set; }  
 
		public Nullable<Int32> PTTIYearMonth { get; set; } 
    }
}


