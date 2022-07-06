using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvQtPartRels : BaseEntity
    {
          
 
		public Int32 InvQtPartRef { get; set; }  
 
		public Int32 InvQtCtrlRef { get; set; } 
    }
}


