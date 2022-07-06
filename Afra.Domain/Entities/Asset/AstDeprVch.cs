using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstDeprVch : BaseEntity
    {
          
 
		public Int32 AstDeprVchId { get; set; }  
 
		public Nullable<Int32> ADVFromMonth { get; set; }  
 
		public Nullable<Int32> ADVToMonth { get; set; }  
 
		public Nullable<Int32> ADVYear { get; set; }  
 
		public String ADVDescr { get; set; }  
 
		public Nullable<Int32> ADVPrdRef { get; set; } 
    }
}


