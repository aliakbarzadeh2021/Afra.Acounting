using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayCtrl : BaseEntity
    {
          
 
		public Int32 PayCtrlId { get; set; }  
 
		public Int32 PCtYear { get; set; }  
 
		public Int32 PCtMonth { get; set; } 
    }
}


