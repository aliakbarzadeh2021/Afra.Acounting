using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleAftSrv : BaseEntity
    {
          
 
		public Int32 SleAftSrvId { get; set; }  
 
		public String SASNum { get; set; }  
 
		public DateTime SASDate { get; set; }  
 
		public Int32 SASCstmrRef { get; set; }  
 
		public String SASResp { get; set; }  
 
		public Int32 SASPartRef { get; set; }  
 
		public Int32 SASQty { get; set; }  
 
		public String SASDescr { get; set; }  
 
		public Int32 SASGuaRef { get; set; }  
 
		public Int32 SASPrdRef { get; set; } 
    }
}


