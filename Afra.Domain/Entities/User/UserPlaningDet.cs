using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserPlaningDet : BaseEntity
    {
          
 
		public Int32 UserPlaningDetId { get; set; }  
 
		public Int32 UPDPlanRef { get; set; }  
 
		public Nullable<Int32> UPDUserRef { get; set; }  
 
		public String UPDDescr { get; set; }  
 
		public DateTime UPDEndDate { get; set; }  
 
		public Nullable<Double> UPDProgress { get; set; } 
    }
}


