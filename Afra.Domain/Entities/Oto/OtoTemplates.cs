using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoTemplates : BaseEntity
    {
          
 
		public Int32 OtoTemplateId { get; set; }  
 
		public String OTTitle { get; set; }  
 
		public Int32 OTDocType { get; set; }  
 
		public Byte[] OTContent { get; set; } 
    }
}


