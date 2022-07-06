using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayUserField : BaseEntity
    {
          
 
		public Int32 PayUserFieldId { get; set; }  
 
		public String PUFTitle { get; set; }  
 
		public String PUFForumula { get; set; } 
    }
}


