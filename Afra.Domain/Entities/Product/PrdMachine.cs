using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdMachine : BaseEntity
    {
          
 
		public Int32 PrdMachineId { get; set; }  
 
		public String PMTitle { get; set; }  
 
		public Int32 PMWorkStRef { get; set; }  
 
		public DateTime PMStartTime { get; set; }  
 
		public Nullable<Int32> PMDurHour { get; set; } 
    }
}


