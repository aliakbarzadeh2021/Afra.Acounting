using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvFormTypes : BaseEntity
    {
          
 
		public Int32 InvFormTypeID { get; set; }  
 
		public String IFTTitle { get; set; }  
 
		public String IFDLType { get; set; } 
    }
}


