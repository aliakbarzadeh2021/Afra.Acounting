using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WebDocs : BaseEntity
    {
          
 
		public Int32 WebDocsId { get; set; }  
 
		public Int32 WDType { get; set; }  
 
		public String WDTitle { get; set; }  
 
		public String WDFileName { get; set; } 
    }
}


