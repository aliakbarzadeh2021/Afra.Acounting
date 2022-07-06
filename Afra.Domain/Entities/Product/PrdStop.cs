using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdStop : BaseEntity
    {
          
 
		public Int32 PrdStopId { get; set; }  
 
		public Int32 PSNum { get; set; }  
 
		public DateTime PSDate { get; set; }  
 
		public String PSDescr { get; set; }  
 
		public Int32 PSYear { get; set; }  
 
		public Nullable<Int32> PSState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; } 
    }
}


