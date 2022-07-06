using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsCreditTbl : BaseEntity
    {
          
 
		public Int32 TrsCreditTblId { get; set; }  
 
		public Nullable<Int32> TCTType { get; set; }  
 
		public String TCTDescr { get; set; }  
 
		public DateTime TCTDate { get; set; } 
    }
}


