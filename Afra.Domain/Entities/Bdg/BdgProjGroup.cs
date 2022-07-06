using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProjGroup : BaseEntity
    {
          
 
		public Int32 BdgProjGroupId { get; set; }  
 
		public String BPGTitle { get; set; } 
    }
}


