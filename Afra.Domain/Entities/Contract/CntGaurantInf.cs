using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntGaurantInf : BaseEntity
    {
          
 
		public Int32 CntGaurantInfId { get; set; }  
 
		public Int32 CGIBaseItm { get; set; }  
 
		public Int32 CGIBaseType { get; set; }  
 
		public DateTime CGIFromDate { get; set; }  
 
		public String CGIDur { get; set; }  
 
		public String CGIDescr { get; set; }  
 
		public Nullable<Double> CGIAmount { get; set; } 
    }
}


