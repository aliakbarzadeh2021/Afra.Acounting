using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrLCDet : BaseEntity
    {
          
 
		public Int32 CmrLCDetId { get; set; }  
 
		public Int32 CmrLCRef { get; set; }  
 
		public String CLDDescr { get; set; }  
 
		public Double CLDAmount { get; set; } 
    }
}


