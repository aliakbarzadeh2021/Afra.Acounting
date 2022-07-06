using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrInvoiceItm : BaseEntity
    {
          
 
		public Int32 CmrInvoiceItmId { get; set; }  
 
		public Int32 CIISeq { get; set; }  
 
		public Int32 CmrInvoiceHdrRef { get; set; }  
 
		public Nullable<Double> CIIOthQty { get; set; }  
 
		public Nullable<Double> CIIMainQty { get; set; }  
 
		public String CIIDescr { get; set; }  
 
		public Nullable<Int32> CIIStatus { get; set; }  
 
		public Nullable<Int32> CIIRefID { get; set; }  
 
		public Nullable<Int32> CIIRefType { get; set; }  
 
		public Nullable<Int32> CIIBaseType { get; set; } 
    }
}


