using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccVchDescr : BaseEntity
    {
          
 
		public Int32 AccVchDescrId { get; set; }  
 
		public String AVDType { get; set; }  
 
		public String AVDDebitD { get; set; }  
 
		public String AVDCreditD { get; set; } 
    }
}


