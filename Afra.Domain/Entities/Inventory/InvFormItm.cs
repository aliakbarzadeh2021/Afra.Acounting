using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvFormItm : BaseEntity
    {
          
 
		public Int32 InvFormItmId { get; set; }  
 
		public Nullable<Int32> InvFormHdrRef { get; set; }  
 
		public Nullable<Int32> IFISeq { get; set; }  
 
		public Int32 IFIPartRef { get; set; }  
 
		public Nullable<Int32> IFIUnitRef { get; set; }  
 
		public Double IFIQty { get; set; }  
 
		public String IFIDescr { get; set; }  
 
		public Nullable<Int32> IFIRefID { get; set; }  
 
		public Nullable<Int32> IFIRefType { get; set; } 
    }
}


