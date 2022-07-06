using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Archive : BaseEntity
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


