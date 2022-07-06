using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpAcntData : BaseEntity
    {
          
 
		public Int32 CntExpAcntDataId { get; set; }  
 
		public Int32 CEADExpAcntRef { get; set; }  
 
		public Int32 CEADFldRef { get; set; }  
 
		public Nullable<Double> CEADAmount { get; set; } 
    }
}


