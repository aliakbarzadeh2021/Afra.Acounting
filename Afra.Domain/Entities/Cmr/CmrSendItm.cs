using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrSendItm : BaseEntity
    {
          
 
		public Int32 CmrSendItmId { get; set; }  
 
		public Int32 CSISeq { get; set; }  
 
		public Int32 CmrSendHdrRef { get; set; }  
 
		public Nullable<Double> CSIOthQty { get; set; }  
 
		public Nullable<Double> CSIMainQty { get; set; }  
 
		public String CSIDescr { get; set; }  
 
		public Nullable<Int32> CSIStatus { get; set; }  
 
		public Nullable<Int32> CSIRefID { get; set; }  
 
		public Nullable<Int32> CSIRefType { get; set; }  
 
		public Nullable<Int32> CSIBaseType { get; set; } 
    }
}


