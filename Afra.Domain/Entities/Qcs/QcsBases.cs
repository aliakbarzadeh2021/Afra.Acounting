using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class QcsBases : BaseEntity
    {
          
 
		public Int32 QBCode { get; set; }  
 
		public String QBType { get; set; }  
 
		public String QBTItle { get; set; } 
    }
}


