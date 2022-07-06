using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsGroupRepAccess : BaseEntity
    {
          
 
		public Int32 GroupRef { get; set; }  
 
		public Int32 ReportRef { get; set; }  
 
		public Nullable<Int32> Access { get; set; } 
    }
}


