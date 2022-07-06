using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayGrpValStatDto
    {
          
 
		public Int32 PayGrpValStatId { get; set; }  
 
		public Nullable<Int32> PGVSNum { get; set; }  
 
		public DateTime PGVSIssueDate { get; set; }  
 
		public DateTime PGVSEffectDate { get; set; }  
 
		public String PGVSDescr { get; set; } 
    }
}


