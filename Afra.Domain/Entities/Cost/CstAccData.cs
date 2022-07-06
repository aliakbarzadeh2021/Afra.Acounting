using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstAccData : BaseEntity
    {
          
 
		public Int32 CADPeriodRef { get; set; }  
 
		public String CADSLRef { get; set; }  
 
		public String CADDLRef { get; set; }  
 
		public String CADDLFive { get; set; }  
 
		public String CADDLSix { get; set; }  
 
		public Nullable<Double> CADDebit { get; set; }  
 
		public Nullable<Double> CADCredit { get; set; } 
    }
}


