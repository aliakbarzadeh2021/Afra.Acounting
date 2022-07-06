using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersSldr : BaseEntity
    {
          
 
		public Int32 PersSoldrId { get; set; }  
 
		public Int32 PersSoldrPersRef { get; set; }  
 
		public DateTime PersSoldrDate { get; set; }  
 
		public String PersSoldrSit { get; set; }  
 
		public String PersSoldrDescr { get; set; } 
    }
}


