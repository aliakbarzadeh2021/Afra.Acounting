using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstStdAccData : BaseEntity
    {
          
 
		public Int32 CSADPeriodRef { get; set; }  
 
		public String CSADSLRef { get; set; }  
 
		public String CSADDLRef { get; set; }  
 
		public String CSADDLFive { get; set; }  
 
		public String CSADDLSix { get; set; }  
 
		public Nullable<Double> CSADDebit { get; set; }  
 
		public Nullable<Double> CSADCredit { get; set; } 
    }
}


