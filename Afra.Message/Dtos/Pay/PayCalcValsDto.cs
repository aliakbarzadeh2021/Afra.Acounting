using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayCalcValsDto
    {
          
 
		public Int32 PayCalcValId { get; set; }  
 
		public Int32 PCVPersRef { get; set; }  
 
		public Int32 PCVElmntRef { get; set; }  
 
		public Int32 PCVIssueYear { get; set; }  
 
		public Int32 PCVIssueMonth { get; set; }  
 
		public Int32 PCVEffectYear { get; set; }  
 
		public Int32 PCVEffectMonth { get; set; }  
 
		public Nullable<Double> PCVAmount { get; set; }  
 
		public Nullable<Int32> PCVIYearMonth { get; set; }  
 
		public Nullable<Int32> PCVEYearMonth { get; set; } 
    }
}


