using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFixAccDet : BaseEntity
    {
          
 
		public String TFADType { get; set; }  
 
		public Int32 TFADRole { get; set; }  
 
		public String TFADSLRef { get; set; } 
    }
}


