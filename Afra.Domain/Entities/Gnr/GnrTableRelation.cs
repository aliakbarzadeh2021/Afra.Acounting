using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrTableRelation : BaseEntity
    {
          
 
		public Int32 GnrTableRelationId { get; set; }  
 
		public String RelationName { get; set; }  
 
		public String RelationTitle { get; set; } 
    }
}


