using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstProductPackageDto
    {
          
 
		public Int32 CstProductPackageId { get; set; }  
 
		public Nullable<Int32> CPPProductRef { get; set; }  
 
		public String CPPTitle { get; set; }  
 
		public DateTime CPPDate { get; set; }  
 
		public Nullable<Int32> CPPPeriodId { get; set; } 
    }
}


