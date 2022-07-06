using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AstRatioDocsDto
    {
          
 
		public Int32 AstRatioDocId { get; set; }  
 
		public String AsDRType { get; set; }  
 
		public DateTime AsDRDate { get; set; }  
 
		public Int32 AsDRNum { get; set; }  
 
		public Nullable<Int32> AsDRLocalNum { get; set; }  
 
		public String AsDRDepType { get; set; }  
 
		public Nullable<Double> AsDRRatio { get; set; }  
 
		public String AsDRDescr { get; set; }  
 
		public Nullable<Int32> AsDRState { get; set; }  
 
		public Nullable<Int32> AsDRAccPrdRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


