using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsPayChqItmDto
    {
          
 
		public Int32 PayChqOprItmId { get; set; }  
 
		public Nullable<Int32> PCOHdrRef { get; set; }  
 
		public Int32 PCOIAccOprRef { get; set; }  
 
		public Nullable<Int32> PCOIBankAccRef { get; set; }  
 
		public Nullable<Int32> PCOICashRef { get; set; }  
 
		public Int32 PCOIChqRef { get; set; }  
 
		public Nullable<Int32> PCOISeq { get; set; }  
 
		public String PCOIDescr { get; set; }  
 
		public DateTime PCOIDate { get; set; }  
 
		public String PCOIDLRef { get; set; } 
    }
}


