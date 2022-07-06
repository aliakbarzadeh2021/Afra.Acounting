using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmTablesDetDto
    {
          
 
		public Int32 HrmTablesDetId { get; set; }  
 
		public Int32 HTDHdrRef { get; set; }  
 
		public Nullable<Double> HTDFVal1 { get; set; }  
 
		public Nullable<Double> HTDEVal1 { get; set; }  
 
		public Nullable<Double> HTDFVal2 { get; set; }  
 
		public Nullable<Double> HTDEVal2 { get; set; }  
 
		public Nullable<Double> HTDFVal3 { get; set; }  
 
		public Nullable<Double> HTDEVal3 { get; set; }  
 
		public Double HTDOutVal { get; set; }  
 
		public String HTDDescr { get; set; } 
    }
}


