using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserArchive : BaseEntity
    {
          
 
		public Int32 UserArchiveId { get; set; }  
 
		public Int32 UATypeRef { get; set; }  
 
		public String UADescr { get; set; }  
 
		public String UAFileName { get; set; }  
 
		public Byte[] UAData { get; set; } 
    }
}


