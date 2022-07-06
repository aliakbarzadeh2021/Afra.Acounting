using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrRef2FormLinkHdrDto
    {
          
 
		public Int32 LinkRefHdrId { get; set; }  
 
		public String LRHTitle { get; set; }  
 
		public Int32 LRHSysFormRef { get; set; }  
 
		public Int32 LRHRefFormRef { get; set; }  
 
		public Nullable<Int32> LRHVchType { get; set; }  
 
		public String LRHRefQryCond { get; set; } 
    }
}


