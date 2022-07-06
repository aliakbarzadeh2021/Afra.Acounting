using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class QcsDocs : BaseEntity
    {
          
 
		public Int32 QcsDocId { get; set; }  
 
		public String QDCode { get; set; }  
 
		public String QDTitle { get; set; }  
 
		public String QDFileExt { get; set; }  
 
		public Byte[] QDImage { get; set; } 
    }
}


