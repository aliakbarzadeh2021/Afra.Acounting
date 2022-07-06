using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankReconcile : BaseEntity
    {
          
 
		public Int32 TrsBankReconcileId { get; set; }  
 
		public Int32 TBRBankBillRef { get; set; }  
 
		public String TBRNum { get; set; }  
 
		public DateTime TBRDate { get; set; } 
    }
}


