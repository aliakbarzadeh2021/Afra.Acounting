using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class ArchiveDto
    {
          
 
		public Int32 ArchiveId { get; set; }  
 
		public String AcTitle { get; set; }  
 
		public Nullable<Int32> AcTypeRef { get; set; }  
 
		public Nullable<Int32> TableItmId { get; set; }  
 
		public Nullable<Int32> FileKind { get; set; }  
 
		public Byte[] FileContent { get; set; }  
 
		public String FilePath { get; set; } 
    }
}


