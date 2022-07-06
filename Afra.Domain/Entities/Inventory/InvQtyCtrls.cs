using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvQtyCtrls : BaseEntity
    {
          
 
		public Int32 InvQtyCtrlId { get; set; }  
 
		public String IQCTitle { get; set; }  
 
		public String IQCBaseType { get; set; }  
 
		public String IQCValType { get; set; }  
 
		public String ICQValRole { get; set; } 
    }
}


