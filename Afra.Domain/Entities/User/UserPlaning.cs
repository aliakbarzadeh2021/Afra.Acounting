using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserPlaning : BaseEntity
    {
          
 
		public Int32 UserPlaningId { get; set; }  
 
		public String UPDescr { get; set; }  
 
		public Int32 UPCreator { get; set; }  
 
		public DateTime UPStartDate { get; set; }  
 
		public DateTime UPStartTime { get; set; }  
 
		public Int32 UPRepeat { get; set; }  
 
		public DateTime UPEndDate { get; set; } 
    }
}


