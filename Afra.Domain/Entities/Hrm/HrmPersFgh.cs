using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersFgh : BaseEntity
    {
          
 
		public Int32 PersFghId { get; set; }  
 
		public Nullable<Int32> PersFghPersRef { get; set; }  
 
		public DateTime PersFghDate { get; set; }  
 
		public String PersFghType { get; set; }  
 
		public Nullable<Int32> PersFghDay { get; set; }  
 
		public String PersFghDescr { get; set; } 
    }
}


