using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayRepLists : BaseEntity
    {
          
 
		public Int32 PayRepListId { get; set; }  
 
		public String PRLTitle { get; set; }  
 
		public String PRLFileName { get; set; } 
    }
}


