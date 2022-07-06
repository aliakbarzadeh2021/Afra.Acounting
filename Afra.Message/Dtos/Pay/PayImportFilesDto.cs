using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayImportFilesDto
    {
          
 
		public Int32 PayImpFileId { get; set; }  
 
		public String PIFTitle { get; set; }  
 
		public Nullable<Int32> PIFFormat { get; set; }  
 
		public String PIFPCFldName { get; set; }  
 
		public Nullable<Int32> PIFPCStart { get; set; }  
 
		public Nullable<Int32> PIFPCCnt { get; set; } 
    }
}


