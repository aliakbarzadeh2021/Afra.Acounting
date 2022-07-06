using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvFormItmDto
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


