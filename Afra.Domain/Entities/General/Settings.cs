using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Settings : BaseEntity
    {
          
 
		public String SettingID { get; set; }  
 
		public String StgValue { get; set; } 
    }
}


