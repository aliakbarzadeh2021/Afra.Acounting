using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdCalender : BaseEntity
    {
          
 
		public Int32 PrdCalenderId { get; set; }  
 
		public DateTime PCDate { get; set; }  
 
		public Int32 PCDayType { get; set; }  
 
		public DateTime PCPrdSTime { get; set; }  
 
		public DateTime PCPrdETime { get; set; } 
    }
}


