using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExtendInf : BaseEntity
    {
          
 
		public Int32 CntExtendInfId { get; set; }  
 
		public Int32 CEIBaseItm { get; set; }  
 
		public Int32 CEIBaseType { get; set; }  
 
		public DateTime CEIFromDate { get; set; }  
 
		public String CEIDur { get; set; }  
 
		public Nullable<Double> CEIAmnt { get; set; }  
 
		public String CEIExtType { get; set; } 
    }
}


