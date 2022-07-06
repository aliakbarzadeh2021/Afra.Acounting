using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class OtoAttachDto
    {
          
 
		public Int32 OtoAttachId { get; set; }  
 
		public Int32 OARefType { get; set; }  
 
		public Int32 OARefId { get; set; }  
 
		public Int32 OAType { get; set; }  
 
		public Nullable<Int32> OABaseId { get; set; }  
 
		public String OADescr { get; set; }  
 
		public Byte[] OAFileContent { get; set; }  
 
		public String OAFileExt { get; set; } 
    }
}


