using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccVchItmDto
    {
          
 
		public Int32 AccVchItmId { get; set; }  
 
		public Nullable<Int32> AccVchHdrRef { get; set; }  
 
		public Nullable<Int32> AVISeq { get; set; }  
 
		public String AVIGlRef { get; set; }  
 
		public String AVISLRef { get; set; }  
 
		public String AVIDLRef { get; set; }  
 
		public String AVIDL5Ref { get; set; }  
 
		public String AVIDL6Ref { get; set; }  
 
		public String AVIDL7Ref { get; set; }  
 
		public String AVIDescr { get; set; }  
 
		public Double AVIDebit { get; set; }  
 
		public Double AVICredit { get; set; }  
 
		public Nullable<Int32> AVIRMainPart { get; set; }  
 
		public String AVIRType { get; set; }  
 
		public Nullable<Double> AVIQty { get; set; }  
 
		public DateTime AVIDate { get; set; }  
 
		public Nullable<Int32> AVICurRef { get; set; }  
 
		public Nullable<Double> AVICurVal { get; set; } 
    }
}


