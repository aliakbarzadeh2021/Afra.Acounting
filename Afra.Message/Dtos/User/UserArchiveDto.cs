using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UserArchiveDto
    {
          
 
		public Int32 UserArchiveId { get; set; }  
 
		public Int32 UATypeRef { get; set; }  
 
		public String UADescr { get; set; }  
 
		public String UAFileName { get; set; }  
 
		public Byte[] UAData { get; set; } 
    }
}


