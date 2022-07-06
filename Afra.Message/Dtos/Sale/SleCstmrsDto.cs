using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleCstmrsDto
    {
          
 
		public Int32 SleCstmrId { get; set; }  
 
		public String SleCstmrCode { get; set; }  
 
		public Nullable<Int32> SCGroupRef { get; set; }  
 
		public Int32 SCCrspndRef { get; set; }  
 
		public String SCSaleType { get; set; }  
 
		public Nullable<Int32> SCLimitType { get; set; }  
 
		public Nullable<Int32> SCType { get; set; } 
    }
}


