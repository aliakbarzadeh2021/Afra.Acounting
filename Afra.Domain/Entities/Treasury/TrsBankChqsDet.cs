using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankChqsDet : BaseEntity
    {
          
 
		public Int32 TrsBankChqDetId { get; set; }  
 
		public Int32 TBCDHdrRef { get; set; }  
 
		public Int32 TBCDChqNo { get; set; }  
 
		public Int32 TBCDSit { get; set; } 
    }
}


