using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class OtoLttrDocDto
    {
          
 
		public Int32 OtoLttrDocId { get; set; }  
 
		public Int32 OLDLttrRef { get; set; }  
 
		public Int32 OLDDocType { get; set; }  
 
		public Byte[] OLDContent { get; set; }  
 
		public String OLDExt { get; set; }  
 
		public Nullable<Int32> OLDTemplate { get; set; } 
    }
}


