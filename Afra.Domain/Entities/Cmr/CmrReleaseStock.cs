using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrReleaseStock : BaseEntity
    {
          
 
		public Int32 CmrReleaseStockId { get; set; }  
 
		public Int32 CRSItmRef { get; set; }  
 
		public String CRSNum { get; set; }  
 
		public DateTime CRSDate { get; set; }  
 
		public String CRSDescr { get; set; } 
    }
}


