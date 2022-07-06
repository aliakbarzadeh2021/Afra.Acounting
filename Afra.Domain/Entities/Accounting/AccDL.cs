using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccDL : BaseEntity
    {
          
 
		public String dl_Code { get; set; }  
 
		public String dl_Title { get; set; }  
 
		public String dl_type { get; set; }  
 
		public Nullable<Int32> dl_disable { get; set; } 
    }
}


