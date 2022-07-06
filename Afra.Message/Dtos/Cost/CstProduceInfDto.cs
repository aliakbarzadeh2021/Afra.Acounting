using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstProduceInfDto
    {
          
 
		public Int32 CstProduceInfId { get; set; }  
 
		public Nullable<Int32> CPIProductRef { get; set; }  
 
		public Nullable<Double> CPIMaintQty { get; set; }  
 
		public Nullable<Double> CPIProfitPrc { get; set; }  
 
		public Nullable<Int32> CPICostCenter { get; set; }  
 
		public Nullable<Double> CPIProdTime { get; set; }  
 
		public Nullable<Double> CPIWatePrc { get; set; }  
 
		public Nullable<Int32> CPIPeriodId { get; set; }  
 
		public Nullable<Double> CPIAbsorbPrc { get; set; }  
 
		public Nullable<Double> CPIBkgTime { get; set; } 
    }
}


