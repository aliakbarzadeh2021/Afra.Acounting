using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserFormOprs : BaseEntity
    {
          
 
		public Int32 GUFOItmType { get; set; }  
 
		public Int32 GUFOItmId { get; set; }  
 
		public String GUFOCmd { get; set; } 
    }
}


