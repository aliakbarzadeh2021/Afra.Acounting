using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacCrdTbl : BaseEntity
    {
          
 
		public Int32 TrsFacCrdTblId { get; set; }  
 
		public String TFCTDescr { get; set; }  
 
		public DateTime TFCTDate { get; set; } 
    }
}


