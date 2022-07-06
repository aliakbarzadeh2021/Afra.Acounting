using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccVchKindDescr : BaseEntity
    {
          
 
		public Int32 AccVchKindDescrId { get; set; }  
 
		public String AVKDSysRef { get; set; }  
 
		public String AVKDType { get; set; }  
 
		public String AVKDDebitD { get; set; }  
 
		public String AVKDCreditD { get; set; } 
    }
}


